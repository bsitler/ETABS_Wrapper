using System;
using ETABS2016;

namespace ETABS2016
{
    public static class cAreaElmExtension
    {
		public static (int NumberItems, string[] AreaName, string[] LoadPat, int[] MyType, double[] Value, string[] PatternName)
		    GetLoadTemperature(this cAreaElm obj, string Name, eItemTypeElm ItemTypeElm = eItemTypeElm.Element) {
			int NumberItems;
			NumberItems = default(int);
			string[] AreaName, LoadPat, PatternName;
			AreaName = LoadPat = PatternName = default(string[]);
			int[] MyType;
			MyType = default(int[]);
			double[] Value;
			Value = default(double[]);
		    var res = obj.GetLoadTemperature(Name, ref NumberItems, ref AreaName, ref LoadPat, ref MyType, ref Value, ref PatternName, ItemTypeElm);
		    return (NumberItems, AreaName, LoadPat, MyType, Value, PatternName);
		}
		public static (int NumberItems, string[] AreaName, string[] LoadPat, string[] CSys, int[] Dir, double[] Value)
		    GetLoadUniform(this cAreaElm obj, string Name, eItemTypeElm ItemTypeElm = eItemTypeElm.Element) {
			int NumberItems;
			NumberItems = default(int);
			string[] AreaName, LoadPat, CSys;
			AreaName = LoadPat = CSys = default(string[]);
			int[] Dir;
			Dir = default(int[]);
			double[] Value;
			Value = default(double[]);
		    var res = obj.GetLoadUniform(Name, ref NumberItems, ref AreaName, ref LoadPat, ref CSys, ref Dir, ref Value, ItemTypeElm);
		    return (NumberItems, AreaName, LoadPat, CSys, Dir, Value);
		}
		public static double
		    GetLocalAxes(this cAreaElm obj, string Name) {
			double Ang;
			Ang = default(double);
		    var res = obj.GetLocalAxes(Name, ref Ang);
		    return Ang;
		}
		public static string
		    GetMaterialOverwrite(this cAreaElm obj, string Name) {
			string PropName;
			PropName = default(string);
		    var res = obj.GetMaterialOverwrite(Name, ref PropName);
		    return PropName;
		}
		public static double[]
		    GetModifiers(this cAreaElm obj, string Name) {
			double[] Value;
			Value = default(double[]);
		    var res = obj.GetModifiers(Name, ref Value);
		    return Value;
		}
		public static (int NumberNames, string[] MyName)
		    GetNameList(this cAreaElm obj) {
			int NumberNames;
			NumberNames = default(int);
			string[] MyName;
			MyName = default(string[]);
		    var res = obj.GetNameList(ref NumberNames, ref MyName);
		    return (NumberNames, MyName);
		}
		public static string
		    GetObj(this cAreaElm obj, string Name) {
			string Obj;
			Obj = default(string);
		    var res = obj.GetObj(Name, ref Obj);
		    return Obj;
		}
		public static (int OffsetType, string OffsetPattern, double OffsetPatternSF, double[] Offset)
		    GetOffsets(this cAreaElm obj, string Name) {
			int OffsetType;
			OffsetType = default(int);
			string OffsetPattern;
			OffsetPattern = default(string);
			double OffsetPatternSF;
			OffsetPatternSF = default(double);
			double[] Offset;
			Offset = default(double[]);
		    var res = obj.GetOffsets(Name, ref OffsetType, ref OffsetPattern, ref OffsetPatternSF, ref Offset);
		    return (OffsetType, OffsetPattern, OffsetPatternSF, Offset);
		}
		public static (int NumberPoints, string[] Point)
		    GetPoints(this cAreaElm obj, string Name) {
			int NumberPoints;
			NumberPoints = default(int);
			string[] Point;
			Point = default(string[]);
		    var res = obj.GetPoints(Name, ref NumberPoints, ref Point);
		    return (NumberPoints, Point);
		}
		public static string
		    GetProperty(this cAreaElm obj, string Name) {
			string PropName;
			PropName = default(string);
		    var res = obj.GetProperty(Name, ref PropName);
		    return PropName;
		}
		public static (int ThicknessType, string ThicknessPattern, double ThicknessPatternSF, double[] Thickness)
		    GetThickness(this cAreaElm obj, string Name) {
			int ThicknessType;
			ThicknessType = default(int);
			string ThicknessPattern;
			ThicknessPattern = default(string);
			double ThicknessPatternSF;
			ThicknessPatternSF = default(double);
			double[] Thickness;
			Thickness = default(double[]);
		    var res = obj.GetThickness(Name, ref ThicknessType, ref ThicknessPattern, ref ThicknessPatternSF, ref Thickness);
		    return (ThicknessType, ThicknessPattern, ThicknessPatternSF, Thickness);
		}
		public static double[]
		    GetTransformationMatrix(this cAreaElm obj, string Name) {
			double[] Value;
			Value = default(double[]);
		    var res = obj.GetTransformationMatrix(Name, ref Value);
		    return Value;
		}

    }
}