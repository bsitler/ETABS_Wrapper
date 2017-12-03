using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.IO;
using System.Windows.Forms;

namespace ETABS_TupleWrapper
{
    /// <summary>
    /// Generates extension methods to simplify ETABS functions using C# 7.0 Tuples
    /// simplified method:
    ///     (PropName,_) = cFrameObj.GetSetion(Name);
    /// original method:
    ///     string PropName, SAuto;
    ///     PropName = SAuto = default(string);    
    ///     cFrameObj.GetSetion(Name, ref PropName, ref SAuto):
    /// </summary>
    public static class WrapperGenerator
    {
        /// <summary>Create Extension Methods for full ETABS API</summary>
        /// <param name="etabsNamespace">Add reference to new ETABS API before running</param>
        public static void CreateWrapper(string etabsNamespace = "ETABS2016",string etabsAssembly="ETABS2016") {
            // Console Script
            var dir = "Extensions_" + new String(etabsAssembly.Where(c => Char.IsDigit(c)).ToArray());
            if (Directory.Exists(dir))
            {
                if (MessageBox.Show("Directory {0} already exists, OK to overwrite?",
                    "Overwrite directory?", MessageBoxButtons.OKCancel) == DialogResult.Cancel) return;
            }
            else Directory.CreateDirectory(dir);

            var assembly = GetAssembly(etabsAssembly);
            foreach (var t in GetTypes("c", assembly))
            {
                var methods = GetMethods(t, assembly, "set", false, true);
                if (methods == null || methods.Count() == 0) continue;
                var wrappers = methods.Select(m => WrapMethod(m, t)).Where(m => m != null);
                if (wrappers == null || wrappers.Count() == 0) continue;

                using (System.IO.StreamWriter file = new StreamWriter(string.Format("{0}\\{1}Extension.cs", dir,t)))
                {
                    file.Write(CreateWrapperClass(t + "Extension", wrappers,etabsNamespace));
                }
            };
        }

        /// <summary>Create Extension Methods for specified ETABS Type</summary>
        public static string CreateWrapperClass(string className, IEnumerable<string> wrapperMethods,string etabsNamespace)
        {
            var methods = new StringBuilder();
            foreach (var m in wrapperMethods)
                methods.AppendLine(TabFront(m));
            
            return string.Format(@"
using System;
using {0};

namespace {0}
{{
    public static class {1}
    {{
{2}
    }}
}}" ,etabsNamespace, className,methods);
        }

        // Wrappers (Extension Methods)
        public static string WrapMethod(string objType, string methodName, Assembly etabsAssembly)
        {
            // Get Object
            var obj = etabsAssembly.GetTypes().FirstOrDefault(t => t.Name == objType);
            if (obj == null) return null;

            // Get Type Methods
            var method = obj.GetMethods().FirstOrDefault(m => m.Name == methodName);
            if (method == null) return null;

            return WrapMethod(method,objType);
        }
        public static string WrapMethod(MethodInfo method, string objType)
        {
            // Get Method Args
            var valArgs = GetArgs(method, false);
            var refArgs = GetArgs(method, true);
            if (refArgs.Count() == 0) return null;

            string methodName = method.Name;
            string methodArgs = valArgs.Count() > 0 ? ", " + ListArgs(valArgs, true) : "";
            string initializers = InitializeArgs(refArgs);
            string inputArgs = ListArgs(method.GetParameters(), false,true);
            string returnVals =refArgs.Count()==1?  refArgs.First().Name:"(" + ListArgs(refArgs,false,false)+")" ;
            string returnTuple = refArgs.Count() == 1 ? ParamType(refArgs.First()): "(" + ListArgs(refArgs, true, false)+")" ;
            
            // Code boilerplate
            return string.Format(
@"public static {6} {0}(this {1} obj{2}) {{
{3}
    var res = obj.{0}({4});
    return {5};
}}", methodName, objType, methodArgs, TabFront(initializers,"\t{0}\n"), inputArgs, returnVals, returnTuple);

        }

        public static string WrapObjectProperties(string obj, List<(string prop, string alias, string method)> properties, Assembly etabsAssembly)
        {
            var extMethods = new StringBuilder();
            foreach (var p in properties)
            {
                var newMethod = WrapIndividualProperty(obj, p.prop, etabsAssembly, p.alias, p.method);
                if (newMethod != null) extMethods.AppendLine(newMethod);
            }
            return extMethods.ToString();
        }
        public static string WrapIndividualProperty(string objType, string property, Assembly etabsAssembly, string propAlias = null, string methodName = null)
        {
            // Get Object
            var obj = etabsAssembly.GetTypes().FirstOrDefault(t => t.Name == objType);
            if (obj == null) return null;

            // Get Type Methods
            var methods = obj.GetMethods().Where(m => m.GetParameters().Select(p => p.Name).Contains(property));
            MethodInfo method;
            if (methodName == null)
                method = methods.Where(m => m.Name.StartsWith("get", StringComparison.CurrentCultureIgnoreCase))
                    .OrderBy(m => m.GetParameters().Count()).FirstOrDefault();
            else method = methods.FirstOrDefault(m => m.Name == methodName);

            if (method == null) return null;
            else methodName = method.Name;

            // Get Method Args
            var arg = method.GetParameters().First(p => p.Name == property);
            var valArgs = GetArgs(method, false);
            var refArgs = GetArgs(method, true);
            
            string returnType = ParamType(arg);
            string methodArgs = valArgs.Count() > 0 ? ", " + ListArgs(valArgs, true) : "";
            string initializers = InitializeArgs(refArgs);
            string inputArgs = ListArgs(method.GetParameters(), false, true);
            string newMethodName = propAlias ?? property;

            // Code boilerplate
            return string.Format(
@"public static {4} {1}(this {0} obj{5}) {{
{6}
    var res = obj.{3}({7});
    return {2};
}}", objType, newMethodName, property, methodName, returnType,methodArgs, TabFront(initializers, "\t{0}\n"), inputArgs);
        }
        
        // Method getters
        public static Assembly GetAssembly(string etabsAssembly)
        {
            var assembly = AppDomain.CurrentDomain.GetAssemblies().FirstOrDefault(a => a.GetName().Name == etabsAssembly);
            if (assembly == null)
            {
                assembly = Assembly.Load(etabsAssembly);
                if (assembly == null) throw new Exception(string.Format("Assembly {0} is not loaded in current AppDomain",etabsAssembly));
            }
            return assembly;
        }
        public static IEnumerable<string> GetTypes(string objPrefix, Assembly etabsAssembly)
        {
            return etabsAssembly.GetTypes()
                .Where(t => t.Name.StartsWith(objPrefix, StringComparison.CurrentCultureIgnoreCase))
                .Select(t => t.Name);
        }
        public static IEnumerable<MethodInfo> GetMethods(string objType, Assembly etabsAssembly, string methodPrefix = "get", bool includePrefix = true, bool mustHaveRefArgs = true)
        {
            var obj = etabsAssembly.GetTypes().FirstOrDefault(t => t.Name == objType);
            if (obj == null) return null;

            // Get Type Methods
            var wrappers = new List<string>();
            return obj.GetMethods()
                .Where(m => String.IsNullOrWhiteSpace(methodPrefix) || m.Name.StartsWith(methodPrefix, StringComparison.CurrentCultureIgnoreCase) == includePrefix)
                .Where(m => !mustHaveRefArgs || m.GetParameters().Any(p => p.ParameterType.IsByRef));
        }

        // String processing
        private static IEnumerable<ParameterInfo> GetArgs(MethodInfo m, bool isByRef = false)
        {
            return m.GetParameters()
                    .Where(p => p.ParameterType.IsByRef == isByRef);
        }
        private static string InitializeArgs(IEnumerable<ParameterInfo> byRefArgs)
        {
            if (byRefArgs.Count() == 0) return "";
            // type arg1, arg2, arg3;
            // arg1 = arg2 = arg3 = default(type);
            return byRefArgs.GroupBy(a => ParamType(a))
                .Select(g => new { type = g.Key, names = g.Select(a => a.Name) })
                .Select(g => string.Format("{0} {1};\n{2} = default({0});",
                    g.type, g.names.Aggregate((i, j) => i + ", " + j),
                    g.names.Aggregate((i, j) => i + " = " + j)))
                .Aggregate((i, j) => i + "\n" + j);
        }
        private static string ListArgs(IEnumerable<ParameterInfo> args, bool includeType = false, bool includeByRef = true)
        {
            if (args.Count() == 0) return "";
            // [includeType=false] arg1, arg2, ref arg3, ref arg4;
            // [includeType=true] type1 arg1, type2 arg2;
            return args.Select(a => string.Format("{0}{1}{2}",
                                    includeByRef && a.ParameterType.IsByRef ? "ref " : "",
                                    includeType ? ParamType(a) + " " : "",
                                    a.Name))
                       .Aggregate((i, j) => i + ", " + j);
        }
        private static string ParamType(ParameterInfo info)
        {
            string type = info.ParameterType.Name;
            if (info.ParameterType.IsByRef) type = type.TrimEnd('&');
            switch (type)
            {
                case "Double":
                    return "double";
                case "Int32":
                    return "int";
                case "String":
                    return "string";
                case "Boolean":
                    return "bool";
                case "Double[]":
                    return "double[]";
                case "Int32[]":
                    return "int[]";
                case "String[]":
                    return "string[]";
                case "Boolean[]":
                    return "bool[]";
                default:
                    return type;
            }
        }
        private static string TabFront(string text, string pattern = "\t\t{0}\n")
        {
            var writer = new StringBuilder();
            using (StringReader reader = new StringReader(text))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    writer.AppendFormat(pattern, line);
                }
            }
            
            return writer.ToString().TrimEnd();
        }

        //public static string GetMethodList(string namesp = "ETABS2016", string assemblyName = "ETABS2016")
        //{
        //    // Load Assembly
        //    var assembly = AppDomain.CurrentDomain.GetAssemblies().FirstOrDefault(a => a.GetName().Name == assemblyName);
        //    if (assembly == null)
        //    {
        //        assembly = Assembly.Load(assemblyName);
        //        if (assembly == null) return null;
        //    }

        //    // Summarize Method Parameters
        //    var methods = new StringBuilder();
        //    foreach (var t in assembly.GetTypes())
        //    {
        //        var typeName = t.Name;
        //        foreach (var m in t.GetMethods())
        //        {
        //            var methodName = m.Name;
        //            foreach (var p in m.GetParameters())
        //            {
        //                methods.AppendLine(string.Format("{0}\t{1}\t{2}\t{3}\t{4}", typeName, methodName,
        //                    p.Name, p.ParameterType.Name, p.ParameterType.IsByRef ? "ref" : ""));
        //                typeName = ""; methodName = "";
        //            }
        //        }
        //    }
        //    return methods.ToString();
        //}
    }
}
