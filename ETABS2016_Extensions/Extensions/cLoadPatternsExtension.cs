using System;
using ETABS2016;

namespace ETABS2016
{
    public static class cLoadPatternsExtension
    {
		public static string
		    GetAutoSeismicCode(this cLoadPatterns obj, string Name) {
			string CodeName;
			CodeName = default(string);
		    var res = obj.GetAutoSeismicCode(Name, ref CodeName);
		    return CodeName;
		}
		public static string
		    GetAutoWindCode(this cLoadPatterns obj, string Name) {
			string CodeName;
			CodeName = default(string);
		    var res = obj.GetAutoWindCode(Name, ref CodeName);
		    return CodeName;
		}
		public static eLoadPatternType
		    GetLoadType(this cLoadPatterns obj, string Name) {
			eLoadPatternType MyType;
			MyType = default(eLoadPatternType);
		    var res = obj.GetLoadType(Name, ref MyType);
		    return MyType;
		}
		public static (int NumberNames, string[] MyName)
		    GetNameList(this cLoadPatterns obj) {
			int NumberNames;
			NumberNames = default(int);
			string[] MyName;
			MyName = default(string[]);
		    var res = obj.GetNameList(ref NumberNames, ref MyName);
		    return (NumberNames, MyName);
		}
		public static double
		    GetSelfWTMultiplier(this cLoadPatterns obj, string Name) {
			double SelfWTMultiplier;
			SelfWTMultiplier = default(double);
		    var res = obj.GetSelfWTMultiplier(Name, ref SelfWTMultiplier);
		    return SelfWTMultiplier;
		}

    }
}