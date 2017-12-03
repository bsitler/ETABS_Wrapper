
using System;
using ETABS2016;

namespace ETABS2016
{
    public static class cPointElmExtension
    {
		public static int CountConstraint(this cPointElm obj, string Name) {
			int Count;
			Count = default(int);
		    var res = obj.CountConstraint(ref Count, Name);
		    return Count;
		}
		public static int CountLoadDispl(this cPointElm obj, string Name, string LoadPat) {
			int Count;
			Count = default(int);
		    var res = obj.CountLoadDispl(ref Count, Name, LoadPat);
		    return Count;
		}
		public static int CountLoadForce(this cPointElm obj, string Name, string LoadPat) {
			int Count;
			Count = default(int);
		    var res = obj.CountLoadForce(ref Count, Name, LoadPat);
		    return Count;
		}
		public static (int NumberItems, int[] ObjectType, string[] ObjectName, int[] PointNumber) GetConnectivity(this cPointElm obj, string Name) {
			int NumberItems;
			NumberItems = default(int);
			int[] ObjectType, PointNumber;
			ObjectType = PointNumber = default(int[]);
			string[] ObjectName;
			ObjectName = default(string[]);
		    var res = obj.GetConnectivity(Name, ref NumberItems, ref ObjectType, ref ObjectName, ref PointNumber);
		    return (NumberItems, ObjectType, ObjectName, PointNumber);
		}
		public static (int NumberItems, string[] PointName, string[] ConstraintName) GetConstraint(this cPointElm obj, string Name, eItemTypeElm ItemTypeElm) {
			int NumberItems;
			NumberItems = default(int);
			string[] PointName, ConstraintName;
			PointName = ConstraintName = default(string[]);
		    var res = obj.GetConstraint(Name, ref NumberItems, ref PointName, ref ConstraintName, ItemTypeElm);
		    return (NumberItems, PointName, ConstraintName);
		}
		public static (double X, double Y, double Z) GetCoordCartesian(this cPointElm obj, string Name, string CSys) {
			double X, Y, Z;
			X = Y = Z = default(double);
		    var res = obj.GetCoordCartesian(Name, ref X, ref Y, ref Z, CSys);
		    return (X, Y, Z);
		}
		public static (int NumberItems, string[] PointName, string[] LoadPat, int[] LcStep, string[] CSys, double[] U1, double[] U2, double[] U3, double[] R1, double[] R2, double[] R3) GetLoadDispl(this cPointElm obj, string Name, eItemTypeElm ItemTypeElm) {
			int NumberItems;
			NumberItems = default(int);
			string[] PointName, LoadPat, CSys;
			PointName = LoadPat = CSys = default(string[]);
			int[] LcStep;
			LcStep = default(int[]);
			double[] U1, U2, U3, R1, R2, R3;
			U1 = U2 = U3 = R1 = R2 = R3 = default(double[]);
		    var res = obj.GetLoadDispl(Name, ref NumberItems, ref PointName, ref LoadPat, ref LcStep, ref CSys, ref U1, ref U2, ref U3, ref R1, ref R2, ref R3, ItemTypeElm);
		    return (NumberItems, PointName, LoadPat, LcStep, CSys, U1, U2, U3, R1, R2, R3);
		}
		public static (int NumberItems, string[] PointName, string[] LoadPat, int[] LcStep, string[] CSys, double[] F1, double[] F2, double[] F3, double[] M1, double[] M2, double[] M3) GetLoadForce(this cPointElm obj, string Name, eItemTypeElm ItemTypeElm) {
			int NumberItems;
			NumberItems = default(int);
			string[] PointName, LoadPat, CSys;
			PointName = LoadPat = CSys = default(string[]);
			int[] LcStep;
			LcStep = default(int[]);
			double[] F1, F2, F3, M1, M2, M3;
			F1 = F2 = F3 = M1 = M2 = M3 = default(double[]);
		    var res = obj.GetLoadForce(Name, ref NumberItems, ref PointName, ref LoadPat, ref LcStep, ref CSys, ref F1, ref F2, ref F3, ref M1, ref M2, ref M3, ItemTypeElm);
		    return (NumberItems, PointName, LoadPat, LcStep, CSys, F1, F2, F3, M1, M2, M3);
		}
		public static (double A, double B, double C) GetLocalAxes(this cPointElm obj, string Name) {
			double A, B, C;
			A = B = C = default(double);
		    var res = obj.GetLocalAxes(Name, ref A, ref B, ref C);
		    return (A, B, C);
		}
		public static (int NumberNames, string[] MyName) GetNameList(this cPointElm obj) {
			int NumberNames;
			NumberNames = default(int);
			string[] MyName;
			MyName = default(string[]);
		    var res = obj.GetNameList(ref NumberNames, ref MyName);
		    return (NumberNames, MyName);
		}
		public static (string Obj, int ObjType) GetObj(this cPointElm obj, string Name) {
			string Obj;
			Obj = default(string);
			int ObjType;
			ObjType = default(int);
		    var res = obj.GetObj(Name, ref Obj, ref ObjType);
		    return (Obj, ObjType);
		}
		public static double GetPatternValue(this cPointElm obj, string Name, string PatternName) {
			double Value;
			Value = default(double);
		    var res = obj.GetPatternValue(Name, PatternName, ref Value);
		    return Value;
		}
		public static bool[] GetRestraint(this cPointElm obj, string Name) {
			bool[] Value;
			Value = default(bool[]);
		    var res = obj.GetRestraint(Name, ref Value);
		    return Value;
		}
		public static double[] GetSpring(this cPointElm obj, string Name) {
			double[] K;
			K = default(double[]);
		    var res = obj.GetSpring(Name, ref K);
		    return K;
		}
		public static double[] GetSpringCoupled(this cPointElm obj, string Name) {
			double[] K;
			K = default(double[]);
		    var res = obj.GetSpringCoupled(Name, ref K);
		    return K;
		}
		public static double[] GetTransformationMatrix(this cPointElm obj, string Name) {
			double[] Value;
			Value = default(double[]);
		    var res = obj.GetTransformationMatrix(Name, ref Value);
		    return Value;
		}
		public static bool IsSpringCoupled(this cPointElm obj, string Name) {
			bool IsCoupled;
			IsCoupled = default(bool);
		    var res = obj.IsSpringCoupled(Name, ref IsCoupled);
		    return IsCoupled;
		}

    }
}