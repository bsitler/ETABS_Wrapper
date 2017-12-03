using System;
using ETABS2016;

namespace ETABS2016
{
    public static class cLineElmExtension
    {
		public static (double Length1, double Length2, double RZ)
		    GetEndLengthOffset(this cLineElm obj, string Name) {
			double Length1, Length2, RZ;
			Length1 = Length2 = RZ = default(double);
		    var res = obj.GetEndLengthOffset(Name, ref Length1, ref Length2, ref RZ);
		    return (Length1, Length2, RZ);
		}
		public static (double[] Offset1, double[] Offset2)
		    GetInsertionPoint(this cLineElm obj, string Name) {
			double[] Offset1, Offset2;
			Offset1 = Offset2 = default(double[]);
		    var res = obj.GetInsertionPoint(Name, ref Offset1, ref Offset2);
		    return (Offset1, Offset2);
		}
		public static (int NumberItems, string[] LineName, string[] LoadPat, int[] MyType, string[] CSys, int[] Dir, double[] RD1, double[] RD2, double[] Dist1, double[] Dist2, double[] Val1, double[] Val2)
		    GetLoadDistributed(this cLineElm obj, string Name, eItemTypeElm ItemTypeElm = eItemTypeElm.Element) {
			int NumberItems;
			NumberItems = default(int);
			string[] LineName, LoadPat, CSys;
			LineName = LoadPat = CSys = default(string[]);
			int[] MyType, Dir;
			MyType = Dir = default(int[]);
			double[] RD1, RD2, Dist1, Dist2, Val1, Val2;
			RD1 = RD2 = Dist1 = Dist2 = Val1 = Val2 = default(double[]);
		    var res = obj.GetLoadDistributed(Name, ref NumberItems, ref LineName, ref LoadPat, ref MyType, ref CSys, ref Dir, ref RD1, ref RD2, ref Dist1, ref Dist2, ref Val1, ref Val2, ItemTypeElm);
		    return (NumberItems, LineName, LoadPat, MyType, CSys, Dir, RD1, RD2, Dist1, Dist2, Val1, Val2);
		}
		public static (int NumberItems, string[] LineName, string[] LoadPat, int[] MyType, string[] CSys, int[] Dir, double[] RelDist, double[] Dist, double[] Val)
		    GetLoadPoint(this cLineElm obj, string Name, eItemTypeElm ItemTypeElm = eItemTypeElm.Element) {
			int NumberItems;
			NumberItems = default(int);
			string[] LineName, LoadPat, CSys;
			LineName = LoadPat = CSys = default(string[]);
			int[] MyType, Dir;
			MyType = Dir = default(int[]);
			double[] RelDist, Dist, Val;
			RelDist = Dist = Val = default(double[]);
		    var res = obj.GetLoadPoint(Name, ref NumberItems, ref LineName, ref LoadPat, ref MyType, ref CSys, ref Dir, ref RelDist, ref Dist, ref Val, ItemTypeElm);
		    return (NumberItems, LineName, LoadPat, MyType, CSys, Dir, RelDist, Dist, Val);
		}
		public static (int NumberItems, string[] LineName, string[] LoadPat, int[] MyType, double[] Val, string[] PatternName)
		    GetLoadTemperature(this cLineElm obj, string Name, eItemTypeElm ItemTypeElm = eItemTypeElm.Element) {
			int NumberItems;
			NumberItems = default(int);
			string[] LineName, LoadPat, PatternName;
			LineName = LoadPat = PatternName = default(string[]);
			int[] MyType;
			MyType = default(int[]);
			double[] Val;
			Val = default(double[]);
		    var res = obj.GetLoadTemperature(Name, ref NumberItems, ref LineName, ref LoadPat, ref MyType, ref Val, ref PatternName, ItemTypeElm);
		    return (NumberItems, LineName, LoadPat, MyType, Val, PatternName);
		}
		public static double
		    GetLocalAxes(this cLineElm obj, string Name) {
			double Ang;
			Ang = default(double);
		    var res = obj.GetLocalAxes(Name, ref Ang);
		    return Ang;
		}
		public static string
		    GetMaterialOverwrite(this cLineElm obj, string Name) {
			string PropName;
			PropName = default(string);
		    var res = obj.GetMaterialOverwrite(Name, ref PropName);
		    return PropName;
		}
		public static double[]
		    GetModifiers(this cLineElm obj, string Name) {
			double[] Value;
			Value = default(double[]);
		    var res = obj.GetModifiers(Name, ref Value);
		    return Value;
		}
		public static (int NumberNames, string[] MyName)
		    GetNameList(this cLineElm obj) {
			int NumberNames;
			NumberNames = default(int);
			string[] MyName;
			MyName = default(string[]);
		    var res = obj.GetNameList(ref NumberNames, ref MyName);
		    return (NumberNames, MyName);
		}
		public static (string Obj, int ObjType, double RDI, double RDJ)
		    GetObj(this cLineElm obj, string Name) {
			string Obj;
			Obj = default(string);
			int ObjType;
			ObjType = default(int);
			double RDI, RDJ;
			RDI = RDJ = default(double);
		    var res = obj.GetObj(Name, ref Obj, ref ObjType, ref RDI, ref RDJ);
		    return (Obj, ObjType, RDI, RDJ);
		}
		public static (string Point1, string Point2)
		    GetPoints(this cLineElm obj, string Name) {
			string Point1, Point2;
			Point1 = Point2 = default(string);
		    var res = obj.GetPoints(Name, ref Point1, ref Point2);
		    return (Point1, Point2);
		}
		public static (string PropName, int ObjType, bool Var, double SVarRelStartLoc, double SVarTotalLength)
		    GetProperty(this cLineElm obj, string Name) {
			string PropName;
			PropName = default(string);
			int ObjType;
			ObjType = default(int);
			bool Var;
			Var = default(bool);
			double SVarRelStartLoc, SVarTotalLength;
			SVarRelStartLoc = SVarTotalLength = default(double);
		    var res = obj.GetProperty(Name, ref PropName, ref ObjType, ref Var, ref SVarRelStartLoc, ref SVarTotalLength);
		    return (PropName, ObjType, Var, SVarRelStartLoc, SVarTotalLength);
		}
		public static (bool[] II, bool[] JJ, double[] StartValue, double[] EndValue)
		    GetReleases(this cLineElm obj, string Name) {
			bool[] II, JJ;
			II = JJ = default(bool[]);
			double[] StartValue, EndValue;
			StartValue = EndValue = default(double[]);
		    var res = obj.GetReleases(Name, ref II, ref JJ, ref StartValue, ref EndValue);
		    return (II, JJ, StartValue, EndValue);
		}
		public static (bool LimitCompressionExists, double LimitCompression, bool LimitTensionExists, double LimitTension)
		    GetTCLimits(this cLineElm obj, string Name) {
			bool LimitCompressionExists, LimitTensionExists;
			LimitCompressionExists = LimitTensionExists = default(bool);
			double LimitCompression, LimitTension;
			LimitCompression = LimitTension = default(double);
		    var res = obj.GetTCLimits(Name, ref LimitCompressionExists, ref LimitCompression, ref LimitTensionExists, ref LimitTension);
		    return (LimitCompressionExists, LimitCompression, LimitTensionExists, LimitTension);
		}
		public static double[]
		    GetTransformationMatrix(this cLineElm obj, string Name) {
			double[] Value;
			Value = default(double[]);
		    var res = obj.GetTransformationMatrix(Name, ref Value);
		    return Value;
		}

    }
}