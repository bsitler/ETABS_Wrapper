using System;
using ETABS2016;

namespace ETABS2016
{
    public static class cCaseResponseSpectrumExtension
    {
		public static double
		    GetDampConstant(this cCaseResponseSpectrum obj, string Name) {
			double Damp;
			Damp = default(double);
		    var res = obj.GetDampConstant(Name, ref Damp);
		    return Damp;
		}
		public static (int DampType, int NumberItems, double[] Time, double[] Damp)
		    GetDampInterpolated(this cCaseResponseSpectrum obj, string Name) {
			int DampType, NumberItems;
			DampType = NumberItems = default(int);
			double[] Time, Damp;
			Time = Damp = default(double[]);
		    var res = obj.GetDampInterpolated(Name, ref DampType, ref NumberItems, ref Time, ref Damp);
		    return (DampType, NumberItems, Time, Damp);
		}
		public static (int NumberItems, int[] Mode, double[] Damp)
		    GetDampOverrides(this cCaseResponseSpectrum obj, string Name) {
			int NumberItems;
			NumberItems = default(int);
			int[] Mode;
			Mode = default(int[]);
			double[] Damp;
			Damp = default(double[]);
		    var res = obj.GetDampOverrides(Name, ref NumberItems, ref Mode, ref Damp);
		    return (NumberItems, Mode, Damp);
		}
		public static (int DampType, double DampA, double DampB, double DampF1, double DampF2, double DampD1, double DampD2)
		    GetDampProportional(this cCaseResponseSpectrum obj, string Name) {
			int DampType;
			DampType = default(int);
			double DampA, DampB, DampF1, DampF2, DampD1, DampD2;
			DampA = DampB = DampF1 = DampF2 = DampD1 = DampD2 = default(double);
		    var res = obj.GetDampProportional(Name, ref DampType, ref DampA, ref DampB, ref DampF1, ref DampF2, ref DampD1, ref DampD2);
		    return (DampType, DampA, DampB, DampF1, DampF2, DampD1, DampD2);
		}
		public static int
		    GetDampType(this cCaseResponseSpectrum obj, string Name) {
			int DampType;
			DampType = default(int);
		    var res = obj.GetDampType(Name, ref DampType);
		    return DampType;
		}
		public static (int Num, string[] Diaph, double[] Eccen)
		    GetDiaphragmEccentricityOverride(this cCaseResponseSpectrum obj, string Name) {
			int Num;
			Num = default(int);
			string[] Diaph;
			Diaph = default(string[]);
			double[] Eccen;
			Eccen = default(double[]);
		    var res = obj.GetDiaphragmEccentricityOverride(Name, ref Num, ref Diaph, ref Eccen);
		    return (Num, Diaph, Eccen);
		}
		public static (int MyType, double SF)
		    GetDirComb(this cCaseResponseSpectrum obj, string Name) {
			int MyType;
			MyType = default(int);
			double SF;
			SF = default(double);
		    var res = obj.GetDirComb(Name, ref MyType, ref SF);
		    return (MyType, SF);
		}
		public static double
		    GetEccentricity(this cCaseResponseSpectrum obj, string Name) {
			double Eccen;
			Eccen = default(double);
		    var res = obj.GetEccentricity(Name, ref Eccen);
		    return Eccen;
		}
		public static (int NumberLoads, string[] LoadName, string[] Func, double[] SF, string[] CSys, double[] Ang)
		    GetLoads(this cCaseResponseSpectrum obj, string Name) {
			int NumberLoads;
			NumberLoads = default(int);
			string[] LoadName, Func, CSys;
			LoadName = Func = CSys = default(string[]);
			double[] SF, Ang;
			SF = Ang = default(double[]);
		    var res = obj.GetLoads(Name, ref NumberLoads, ref LoadName, ref Func, ref SF, ref CSys, ref Ang);
		    return (NumberLoads, LoadName, Func, SF, CSys, Ang);
		}
		public static string
		    GetModalCase(this cCaseResponseSpectrum obj, string Name) {
			string ModalCase;
			ModalCase = default(string);
		    var res = obj.GetModalCase(Name, ref ModalCase);
		    return ModalCase;
		}
		public static (int MyType, double F1, double F2, double Td)
		    GetModalComb(this cCaseResponseSpectrum obj, string Name) {
			int MyType;
			MyType = default(int);
			double F1, F2, Td;
			F1 = F2 = Td = default(double);
		    var res = obj.GetModalComb(Name, ref MyType, ref F1, ref F2, ref Td);
		    return (MyType, F1, F2, Td);
		}
		public static (int MyType, double F1, double F2, int PeriodicRigidCombType, double Td)
		    GetModalComb_1(this cCaseResponseSpectrum obj, string Name) {
			int MyType, PeriodicRigidCombType;
			MyType = PeriodicRigidCombType = default(int);
			double F1, F2, Td;
			F1 = F2 = Td = default(double);
		    var res = obj.GetModalComb_1(Name, ref MyType, ref F1, ref F2, ref PeriodicRigidCombType, ref Td);
		    return (MyType, F1, F2, PeriodicRigidCombType, Td);
		}

    }
}