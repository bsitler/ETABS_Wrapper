
using System;
using ETABS2016;

namespace ETABS2016
{
    public static class cPropLinkExtension
    {
		public static (bool[] DOF, bool[] Fixed, bool[] Nonlinear, double[] Ke, double[] Ce, double[] K, double[] C, double[] CExp, double DJ2, double DJ3, string Notes, string GUID) GetDamper(this cPropLink obj, string Name) {
			bool[] DOF, Fixed, Nonlinear;
			DOF = Fixed = Nonlinear = default(bool[]);
			double[] Ke, Ce, K, C, CExp;
			Ke = Ce = K = C = CExp = default(double[]);
			double DJ2, DJ3;
			DJ2 = DJ3 = default(double);
			string Notes, GUID;
			Notes = GUID = default(string);
		    var res = obj.GetDamper(Name, ref DOF, ref Fixed, ref Nonlinear, ref Ke, ref Ce, ref K, ref C, ref CExp, ref DJ2, ref DJ3, ref Notes, ref GUID);
		    return (DOF, Fixed, Nonlinear, Ke, Ce, K, C, CExp, DJ2, DJ3, Notes, GUID);
		}
		public static (bool[] DOF, bool[] Fixed, bool[] Nonlinear, double[] Ke, double[] Ce, double[] K, double[] Slow, double[] Fast, double[] Rate, double[] Radius, double Damping, double DJ2, double DJ3, string Notes, string GUID) GetFrictionIsolator(this cPropLink obj, string Name) {
			bool[] DOF, Fixed, Nonlinear;
			DOF = Fixed = Nonlinear = default(bool[]);
			double[] Ke, Ce, K, Slow, Fast, Rate, Radius;
			Ke = Ce = K = Slow = Fast = Rate = Radius = default(double[]);
			double Damping, DJ2, DJ3;
			Damping = DJ2 = DJ3 = default(double);
			string Notes, GUID;
			Notes = GUID = default(string);
		    var res = obj.GetFrictionIsolator(Name, ref DOF, ref Fixed, ref Nonlinear, ref Ke, ref Ce, ref K, ref Slow, ref Fast, ref Rate, ref Radius, ref Damping, ref DJ2, ref DJ3, ref Notes, ref GUID);
		    return (DOF, Fixed, Nonlinear, Ke, Ce, K, Slow, Fast, Rate, Radius, Damping, DJ2, DJ3, Notes, GUID);
		}
		public static (bool[] DOF, bool[] Fixed, bool[] Nonlinear, double[] Ke, double[] Ce, double[] K, double[] Dis, double DJ2, double DJ3, string Notes, string GUID) GetGap(this cPropLink obj, string Name) {
			bool[] DOF, Fixed, Nonlinear;
			DOF = Fixed = Nonlinear = default(bool[]);
			double[] Ke, Ce, K, Dis;
			Ke = Ce = K = Dis = default(double[]);
			double DJ2, DJ3;
			DJ2 = DJ3 = default(double);
			string Notes, GUID;
			Notes = GUID = default(string);
		    var res = obj.GetGap(Name, ref DOF, ref Fixed, ref Nonlinear, ref Ke, ref Ce, ref K, ref Dis, ref DJ2, ref DJ3, ref Notes, ref GUID);
		    return (DOF, Fixed, Nonlinear, Ke, Ce, K, Dis, DJ2, DJ3, Notes, GUID);
		}
		public static (bool[] DOF, bool[] Fixed, bool[] Nonlinear, double[] Ke, double[] Ce, double[] K, double[] Dis, double DJ2, double DJ3, string Notes, string GUID) GetHook(this cPropLink obj, string Name) {
			bool[] DOF, Fixed, Nonlinear;
			DOF = Fixed = Nonlinear = default(bool[]);
			double[] Ke, Ce, K, Dis;
			Ke = Ce = K = Dis = default(double[]);
			double DJ2, DJ3;
			DJ2 = DJ3 = default(double);
			string Notes, GUID;
			Notes = GUID = default(string);
		    var res = obj.GetHook(Name, ref DOF, ref Fixed, ref Nonlinear, ref Ke, ref Ce, ref K, ref Dis, ref DJ2, ref DJ3, ref Notes, ref GUID);
		    return (DOF, Fixed, Nonlinear, Ke, Ce, K, Dis, DJ2, DJ3, Notes, GUID);
		}
		public static (bool[] DOF, bool[] Fixed, double[] Ke, double[] Ce, double DJ2, double DJ3, bool KeCoupled, bool CeCoupled, string Notes, string GUID) GetLinear(this cPropLink obj, string Name) {
			bool[] DOF, Fixed;
			DOF = Fixed = default(bool[]);
			double[] Ke, Ce;
			Ke = Ce = default(double[]);
			double DJ2, DJ3;
			DJ2 = DJ3 = default(double);
			bool KeCoupled, CeCoupled;
			KeCoupled = CeCoupled = default(bool);
			string Notes, GUID;
			Notes = GUID = default(string);
		    var res = obj.GetLinear(Name, ref DOF, ref Fixed, ref Ke, ref Ce, ref DJ2, ref DJ3, ref KeCoupled, ref CeCoupled, ref Notes, ref GUID);
		    return (DOF, Fixed, Ke, Ce, DJ2, DJ3, KeCoupled, CeCoupled, Notes, GUID);
		}
		public static (bool[] DOF, bool[] Fixed, bool[] Nonlinear, double[] Ke, double[] Ce, double DJ2, double DJ3, string Notes, string GUID) GetMultiLinearElastic(this cPropLink obj, string Name) {
			bool[] DOF, Fixed, Nonlinear;
			DOF = Fixed = Nonlinear = default(bool[]);
			double[] Ke, Ce;
			Ke = Ce = default(double[]);
			double DJ2, DJ3;
			DJ2 = DJ3 = default(double);
			string Notes, GUID;
			Notes = GUID = default(string);
		    var res = obj.GetMultiLinearElastic(Name, ref DOF, ref Fixed, ref Nonlinear, ref Ke, ref Ce, ref DJ2, ref DJ3, ref Notes, ref GUID);
		    return (DOF, Fixed, Nonlinear, Ke, Ce, DJ2, DJ3, Notes, GUID);
		}
		public static (bool[] DOF, bool[] Fixed, bool[] Nonlinear, double[] Ke, double[] Ce, double DJ2, double DJ3, string Notes, string GUID) GetMultiLinearPlastic(this cPropLink obj, string Name) {
			bool[] DOF, Fixed, Nonlinear;
			DOF = Fixed = Nonlinear = default(bool[]);
			double[] Ke, Ce;
			Ke = Ce = default(double[]);
			double DJ2, DJ3;
			DJ2 = DJ3 = default(double);
			string Notes, GUID;
			Notes = GUID = default(string);
		    var res = obj.GetMultiLinearPlastic(Name, ref DOF, ref Fixed, ref Nonlinear, ref Ke, ref Ce, ref DJ2, ref DJ3, ref Notes, ref GUID);
		    return (DOF, Fixed, Nonlinear, Ke, Ce, DJ2, DJ3, Notes, GUID);
		}
		public static (int NumberPoints, double[] F, double[] D, int MyType, double A1, double A2, double B1, double B2, double Eta) GetMultiLinearPoints(this cPropLink obj, string Name, int DOF) {
			int NumberPoints, MyType;
			NumberPoints = MyType = default(int);
			double[] F, D;
			F = D = default(double[]);
			double A1, A2, B1, B2, Eta;
			A1 = A2 = B1 = B2 = Eta = default(double);
		    var res = obj.GetMultiLinearPoints(Name, DOF, ref NumberPoints, ref F, ref D, ref MyType, ref A1, ref A2, ref B1, ref B2, ref Eta);
		    return (NumberPoints, F, D, MyType, A1, A2, B1, B2, Eta);
		}
		public static (int NumberNames, string[] MyName) GetNameList(this cPropLink obj, eLinkPropType PropType) {
			int NumberNames;
			NumberNames = default(int);
			string[] MyName;
			MyName = default(string[]);
		    var res = obj.GetNameList(ref NumberNames, ref MyName, PropType);
		    return (NumberNames, MyName);
		}
		public static double[] GetPDelta(this cPropLink obj, string Name) {
			double[] Value;
			Value = default(double[]);
		    var res = obj.GetPDelta(Name, ref Value);
		    return Value;
		}
		public static (bool[] DOF, bool[] Fixed, bool[] Nonlinear, double[] Ke, double[] Ce, double[] K, double[] Yield, double[] Ratio, double[] Exp, double DJ2, double DJ3, string Notes, string GUID) GetPlasticWen(this cPropLink obj, string Name) {
			bool[] DOF, Fixed, Nonlinear;
			DOF = Fixed = Nonlinear = default(bool[]);
			double[] Ke, Ce, K, Yield, Ratio, Exp;
			Ke = Ce = K = Yield = Ratio = Exp = default(double[]);
			double DJ2, DJ3;
			DJ2 = DJ3 = default(double);
			string Notes, GUID;
			Notes = GUID = default(string);
		    var res = obj.GetPlasticWen(Name, ref DOF, ref Fixed, ref Nonlinear, ref Ke, ref Ce, ref K, ref Yield, ref Ratio, ref Exp, ref DJ2, ref DJ3, ref Notes, ref GUID);
		    return (DOF, Fixed, Nonlinear, Ke, Ce, K, Yield, Ratio, Exp, DJ2, DJ3, Notes, GUID);
		}
		public static (bool[] DOF, bool[] Fixed, bool[] Nonlinear, double[] Ke, double[] Ce, double[] K, double[] Yield, double[] Ratio, double DJ2, double DJ3, string Notes, string GUID) GetRubberIsolator(this cPropLink obj, string Name) {
			bool[] DOF, Fixed, Nonlinear;
			DOF = Fixed = Nonlinear = default(bool[]);
			double[] Ke, Ce, K, Yield, Ratio;
			Ke = Ce = K = Yield = Ratio = default(double[]);
			double DJ2, DJ3;
			DJ2 = DJ3 = default(double);
			string Notes, GUID;
			Notes = GUID = default(string);
		    var res = obj.GetRubberIsolator(Name, ref DOF, ref Fixed, ref Nonlinear, ref Ke, ref Ce, ref K, ref Yield, ref Ratio, ref DJ2, ref DJ3, ref Notes, ref GUID);
		    return (DOF, Fixed, Nonlinear, Ke, Ce, K, Yield, Ratio, DJ2, DJ3, Notes, GUID);
		}
		public static (double DefinedForThisLength, double DefinedForThisArea) GetSpringData(this cPropLink obj, string Name) {
			double DefinedForThisLength, DefinedForThisArea;
			DefinedForThisLength = DefinedForThisArea = default(double);
		    var res = obj.GetSpringData(Name, ref DefinedForThisLength, ref DefinedForThisArea);
		    return (DefinedForThisLength, DefinedForThisArea);
		}
		public static (bool[] DOF, bool[] Fixed, bool[] Nonlinear, double[] Ke, double[] Ce, double[] K, double[] Slow, double[] Fast, double[] Rate, double[] Radius, double[] SlowT, double[] FastT, double[] RateT, double Kt, double Dis, double Dist, double Damping, double DJ2, double DJ3, string Notes, string GUID) GetTCFrictionIsolator(this cPropLink obj, string Name) {
			bool[] DOF, Fixed, Nonlinear;
			DOF = Fixed = Nonlinear = default(bool[]);
			double[] Ke, Ce, K, Slow, Fast, Rate, Radius, SlowT, FastT, RateT;
			Ke = Ce = K = Slow = Fast = Rate = Radius = SlowT = FastT = RateT = default(double[]);
			double Kt, Dis, Dist, Damping, DJ2, DJ3;
			Kt = Dis = Dist = Damping = DJ2 = DJ3 = default(double);
			string Notes, GUID;
			Notes = GUID = default(string);
		    var res = obj.GetTCFrictionIsolator(Name, ref DOF, ref Fixed, ref Nonlinear, ref Ke, ref Ce, ref K, ref Slow, ref Fast, ref Rate, ref Radius, ref SlowT, ref FastT, ref RateT, ref Kt, ref Dis, ref Dist, ref Damping, ref DJ2, ref DJ3, ref Notes, ref GUID);
		    return (DOF, Fixed, Nonlinear, Ke, Ce, K, Slow, Fast, Rate, Radius, SlowT, FastT, RateT, Kt, Dis, Dist, Damping, DJ2, DJ3, Notes, GUID);
		}
		public static eLinkPropType GetTypeOAPI(this cPropLink obj, string Name) {
			eLinkPropType PropType;
			PropType = default(eLinkPropType);
		    var res = obj.GetTypeOAPI(Name, ref PropType);
		    return PropType;
		}
		public static (double W, double M, double R1, double R2, double R3) GetWeightAndMass(this cPropLink obj, string Name) {
			double W, M, R1, R2, R3;
			W = M = R1 = R2 = R3 = default(double);
		    var res = obj.GetWeightAndMass(Name, ref W, ref M, ref R1, ref R2, ref R3);
		    return (W, M, R1, R2, R3);
		}
		public static (bool[] dof, bool[] Fixed, bool[] Nonlinear, double[] ke, double[] ce, double[] k, double[] c, double[] CY, double[] ForceLimit, double dj2, double dj3, string notes, string GUID) GetDamperBilinear(this cPropLink obj, string Name) {
			bool[] dof, Fixed, Nonlinear;
			dof = Fixed = Nonlinear = default(bool[]);
			double[] ke, ce, k, c, CY, ForceLimit;
			ke = ce = k = c = CY = ForceLimit = default(double[]);
			double dj2, dj3;
			dj2 = dj3 = default(double);
			string notes, GUID;
			notes = GUID = default(string);
		    var res = obj.GetDamperBilinear(Name, ref dof, ref Fixed, ref Nonlinear, ref ke, ref ce, ref k, ref c, ref CY, ref ForceLimit, ref dj2, ref dj3, ref notes, ref GUID);
		    return (dof, Fixed, Nonlinear, ke, ce, k, c, CY, ForceLimit, dj2, dj3, notes, GUID);
		}
		public static (bool[] dof, bool[] Fixed, bool[] Nonlinear, double[] ke, double[] ce, double[] k, double[] K1, double[] K2, double[] u0, double[] us, int[] direction, double dj2, double dj3, string notes, string GUID) GetDamperFrictionSpring(this cPropLink obj, string Name) {
			bool[] dof, Fixed, Nonlinear;
			dof = Fixed = Nonlinear = default(bool[]);
			double[] ke, ce, k, K1, K2, u0, us;
			ke = ce = k = K1 = K2 = u0 = us = default(double[]);
			int[] direction;
			direction = default(int[]);
			double dj2, dj3;
			dj2 = dj3 = default(double);
			string notes, GUID;
			notes = GUID = default(string);
		    var res = obj.GetDamperFrictionSpring(Name, ref dof, ref Fixed, ref Nonlinear, ref ke, ref ce, ref k, ref K1, ref K2, ref u0, ref us, ref direction, ref dj2, ref dj3, ref notes, ref GUID);
		    return (dof, Fixed, Nonlinear, ke, ce, k, K1, K2, u0, us, direction, dj2, dj3, notes, GUID);
		}

    }
}