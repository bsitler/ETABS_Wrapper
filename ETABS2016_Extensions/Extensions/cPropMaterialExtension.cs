using System;
using ETABS2016;

namespace ETABS2016
{
    public static class cPropMaterialExtension
    {
		public static string
		    AddMaterial(this cPropMaterial obj, eMatType MatType, string Region, string Standard, string Grade, string UserName = "") {
			string Name;
			Name = default(string);
		    var res = obj.AddMaterial(ref Name, MatType, Region, Standard, Grade, UserName);
		    return Name;
		}
		public static (double ModalRatio, double ViscousMassCoeff, double ViscousStiffCoeff, double HystereticMassCoeff, double HystereticStiffCoeff)
		    GetDamping(this cPropMaterial obj, string Name, double Temp = 0) {
			double ModalRatio, ViscousMassCoeff, ViscousStiffCoeff, HystereticMassCoeff, HystereticStiffCoeff;
			ModalRatio = ViscousMassCoeff = ViscousStiffCoeff = HystereticMassCoeff = HystereticStiffCoeff = default(double);
		    var res = obj.GetDamping(Name, ref ModalRatio, ref ViscousMassCoeff, ref ViscousStiffCoeff, ref HystereticMassCoeff, ref HystereticStiffCoeff, Temp);
		    return (ModalRatio, ViscousMassCoeff, ViscousStiffCoeff, HystereticMassCoeff, HystereticStiffCoeff);
		}
		public static (int MyOption, int NumberLoads, string[] LoadPat, double[] SF)
		    GetMassSource(this cPropMaterial obj) {
			int MyOption, NumberLoads;
			MyOption = NumberLoads = default(int);
			string[] LoadPat;
			LoadPat = default(string[]);
			double[] SF;
			SF = default(double[]);
		    var res = obj.GetMassSource(ref MyOption, ref NumberLoads, ref LoadPat, ref SF);
		    return (MyOption, NumberLoads, LoadPat, SF);
		}
		public static (eMatType MatType, int Color, string Notes, string GUID)
		    GetMaterial(this cPropMaterial obj, string Name) {
			eMatType MatType;
			MatType = default(eMatType);
			int Color;
			Color = default(int);
			string Notes, GUID;
			Notes = GUID = default(string);
		    var res = obj.GetMaterial(Name, ref MatType, ref Color, ref Notes, ref GUID);
		    return (MatType, Color, Notes, GUID);
		}
		public static (double[] E, double[] U, double[] A, double[] G)
		    GetMPAnisotropic(this cPropMaterial obj, string Name, double Temp = 0) {
			double[] E, U, A, G;
			E = U = A = G = default(double[]);
		    var res = obj.GetMPAnisotropic(Name, ref E, ref U, ref A, ref G, Temp);
		    return (E, U, A, G);
		}
		public static (double E, double U, double A, double G)
		    GetMPIsotropic(this cPropMaterial obj, string Name, double Temp = 0) {
			double E, U, A, G;
			E = U = A = G = default(double);
		    var res = obj.GetMPIsotropic(Name, ref E, ref U, ref A, ref G, Temp);
		    return (E, U, A, G);
		}
		public static (double[] E, double[] U, double[] A, double[] G)
		    GetMPOrthotropic(this cPropMaterial obj, string Name, double Temp = 0) {
			double[] E, U, A, G;
			E = U = A = G = default(double[]);
		    var res = obj.GetMPOrthotropic(Name, ref E, ref U, ref A, ref G, Temp);
		    return (E, U, A, G);
		}
		public static (double E, double A)
		    GetMPUniaxial(this cPropMaterial obj, string Name, double Temp = 0) {
			double E, A;
			E = A = default(double);
		    var res = obj.GetMPUniaxial(Name, ref E, ref A, Temp);
		    return (E, A);
		}
		public static (int NumberNames, string[] MyName)
		    GetNameList(this cPropMaterial obj, eMatType MatType = (eMatType)0) {
			int NumberNames;
			NumberNames = default(int);
			string[] MyName;
			MyName = default(string[]);
		    var res = obj.GetNameList(ref NumberNames, ref MyName, MatType);
		    return (NumberNames, MyName);
		}
		public static (double Fc, bool IsLightweight, double FcsFactor, int SSType, int SSHysType, double StrainAtFc, double StrainUltimate, double FrictionAngle, double DilatationalAngle)
		    GetOConcrete(this cPropMaterial obj, string Name, double Temp = 0) {
			double Fc, FcsFactor, StrainAtFc, StrainUltimate, FrictionAngle, DilatationalAngle;
			Fc = FcsFactor = StrainAtFc = StrainUltimate = FrictionAngle = DilatationalAngle = default(double);
			bool IsLightweight;
			IsLightweight = default(bool);
			int SSType, SSHysType;
			SSType = SSHysType = default(int);
		    var res = obj.GetOConcrete(Name, ref Fc, ref IsLightweight, ref FcsFactor, ref SSType, ref SSHysType, ref StrainAtFc, ref StrainUltimate, ref FrictionAngle, ref DilatationalAngle, Temp);
		    return (Fc, IsLightweight, FcsFactor, SSType, SSHysType, StrainAtFc, StrainUltimate, FrictionAngle, DilatationalAngle);
		}
		public static (double Fc, bool IsLightweight, double FcsFactor, int SSType, int SSHysType, double StrainAtFc, double StrainUltimate, double FinalSlope, double FrictionAngle, double DilatationalAngle)
		    GetOConcrete_1(this cPropMaterial obj, string Name, double Temp = 0) {
			double Fc, FcsFactor, StrainAtFc, StrainUltimate, FinalSlope, FrictionAngle, DilatationalAngle;
			Fc = FcsFactor = StrainAtFc = StrainUltimate = FinalSlope = FrictionAngle = DilatationalAngle = default(double);
			bool IsLightweight;
			IsLightweight = default(bool);
			int SSType, SSHysType;
			SSType = SSHysType = default(int);
		    var res = obj.GetOConcrete_1(Name, ref Fc, ref IsLightweight, ref FcsFactor, ref SSType, ref SSHysType, ref StrainAtFc, ref StrainUltimate, ref FinalSlope, ref FrictionAngle, ref DilatationalAngle, Temp);
		    return (Fc, IsLightweight, FcsFactor, SSType, SSHysType, StrainAtFc, StrainUltimate, FinalSlope, FrictionAngle, DilatationalAngle);
		}
		public static (double FrictionAngle, double DilatationalAngle)
		    GetONoDesign(this cPropMaterial obj, string Name, double Temp = 0) {
			double FrictionAngle, DilatationalAngle;
			FrictionAngle = DilatationalAngle = default(double);
		    var res = obj.GetONoDesign(Name, ref FrictionAngle, ref DilatationalAngle, Temp);
		    return (FrictionAngle, DilatationalAngle);
		}
		public static (double Fy, double Fu, double EFy, double EFu, int SSType, int SSHysType, double StrainAtHardening, double StrainUltimate, bool UseCaltransSSDefaults)
		    GetORebar(this cPropMaterial obj, string Name, double Temp = 0) {
			double Fy, Fu, EFy, EFu, StrainAtHardening, StrainUltimate;
			Fy = Fu = EFy = EFu = StrainAtHardening = StrainUltimate = default(double);
			int SSType, SSHysType;
			SSType = SSHysType = default(int);
			bool UseCaltransSSDefaults;
			UseCaltransSSDefaults = default(bool);
		    var res = obj.GetORebar(Name, ref Fy, ref Fu, ref EFy, ref EFu, ref SSType, ref SSHysType, ref StrainAtHardening, ref StrainUltimate, ref UseCaltransSSDefaults, Temp);
		    return (Fy, Fu, EFy, EFu, SSType, SSHysType, StrainAtHardening, StrainUltimate, UseCaltransSSDefaults);
		}
		public static (double Fy, double Fu, double EFy, double EFu, int SSType, int SSHysType, double StrainAtHardening, double StrainUltimate, double FinalSlope, bool UseCaltransSSDefaults)
		    GetORebar_1(this cPropMaterial obj, string Name, double Temp = 0) {
			double Fy, Fu, EFy, EFu, StrainAtHardening, StrainUltimate, FinalSlope;
			Fy = Fu = EFy = EFu = StrainAtHardening = StrainUltimate = FinalSlope = default(double);
			int SSType, SSHysType;
			SSType = SSHysType = default(int);
			bool UseCaltransSSDefaults;
			UseCaltransSSDefaults = default(bool);
		    var res = obj.GetORebar_1(Name, ref Fy, ref Fu, ref EFy, ref EFu, ref SSType, ref SSHysType, ref StrainAtHardening, ref StrainUltimate, ref FinalSlope, ref UseCaltransSSDefaults, Temp);
		    return (Fy, Fu, EFy, EFu, SSType, SSHysType, StrainAtHardening, StrainUltimate, FinalSlope, UseCaltransSSDefaults);
		}
		public static (double Fy, double Fu, double EFy, double EFu, int SSType, int SSHysType, double StrainAtHardening, double StrainAtMaxStress, double StrainAtRupture)
		    GetOSteel(this cPropMaterial obj, string Name, double Temp = 0) {
			double Fy, Fu, EFy, EFu, StrainAtHardening, StrainAtMaxStress, StrainAtRupture;
			Fy = Fu = EFy = EFu = StrainAtHardening = StrainAtMaxStress = StrainAtRupture = default(double);
			int SSType, SSHysType;
			SSType = SSHysType = default(int);
		    var res = obj.GetOSteel(Name, ref Fy, ref Fu, ref EFy, ref EFu, ref SSType, ref SSHysType, ref StrainAtHardening, ref StrainAtMaxStress, ref StrainAtRupture, Temp);
		    return (Fy, Fu, EFy, EFu, SSType, SSHysType, StrainAtHardening, StrainAtMaxStress, StrainAtRupture);
		}
		public static (double Fy, double Fu, double EFy, double EFu, int SSType, int SSHysType, double StrainAtHardening, double StrainAtMaxStress, double StrainAtRupture, double FinalSlope)
		    GetOSteel_1(this cPropMaterial obj, string Name, double Temp = 0) {
			double Fy, Fu, EFy, EFu, StrainAtHardening, StrainAtMaxStress, StrainAtRupture, FinalSlope;
			Fy = Fu = EFy = EFu = StrainAtHardening = StrainAtMaxStress = StrainAtRupture = FinalSlope = default(double);
			int SSType, SSHysType;
			SSType = SSHysType = default(int);
		    var res = obj.GetOSteel_1(Name, ref Fy, ref Fu, ref EFy, ref EFu, ref SSType, ref SSHysType, ref StrainAtHardening, ref StrainAtMaxStress, ref StrainAtRupture, ref FinalSlope, Temp);
		    return (Fy, Fu, EFy, EFu, SSType, SSHysType, StrainAtHardening, StrainAtMaxStress, StrainAtRupture, FinalSlope);
		}
		public static (double Fy, double Fu, int SSType, int SSHysType)
		    GetOTendon(this cPropMaterial obj, string Name, double Temp = 0) {
			double Fy, Fu;
			Fy = Fu = default(double);
			int SSType, SSHysType;
			SSType = SSHysType = default(int);
		    var res = obj.GetOTendon(Name, ref Fy, ref Fu, ref SSType, ref SSHysType, Temp);
		    return (Fy, Fu, SSType, SSHysType);
		}
		public static (double Fy, double Fu, int SSType, int SSHysType, double FinalSlope)
		    GetOTendon_1(this cPropMaterial obj, string Name, double Temp = 0) {
			double Fy, Fu, FinalSlope;
			Fy = Fu = FinalSlope = default(double);
			int SSType, SSHysType;
			SSType = SSHysType = default(int);
		    var res = obj.GetOTendon_1(Name, ref Fy, ref Fu, ref SSType, ref SSHysType, ref FinalSlope, Temp);
		    return (Fy, Fu, SSType, SSHysType, FinalSlope);
		}
		public static (int NumberPoints, int[] PointID, double[] Strain, double[] Stress)
		    GetSSCurve(this cPropMaterial obj, string Name, string SectName = "", double RebarArea = 0, double Temp = 0) {
			int NumberPoints;
			NumberPoints = default(int);
			int[] PointID;
			PointID = default(int[]);
			double[] Strain, Stress;
			Strain = Stress = default(double[]);
		    var res = obj.GetSSCurve(Name, ref NumberPoints, ref PointID, ref Strain, ref Stress, SectName, RebarArea, Temp);
		    return (NumberPoints, PointID, Strain, Stress);
		}
		public static (int NumberItems, double[] Temp)
		    GetTemp(this cPropMaterial obj, string Name) {
			int NumberItems;
			NumberItems = default(int);
			double[] Temp;
			Temp = default(double[]);
		    var res = obj.GetTemp(Name, ref NumberItems, ref Temp);
		    return (NumberItems, Temp);
		}
		public static (eMatType MatType, int SymType)
		    GetTypeOAPI(this cPropMaterial obj, string Name) {
			eMatType MatType;
			MatType = default(eMatType);
			int SymType;
			SymType = default(int);
		    var res = obj.GetTypeOAPI(Name, ref MatType, ref SymType);
		    return (MatType, SymType);
		}
		public static (double W, double M)
		    GetWeightAndMass(this cPropMaterial obj, string Name, double Temp = 0) {
			double W, M;
			W = M = default(double);
		    var res = obj.GetWeightAndMass(Name, ref W, ref M, Temp);
		    return (W, M);
		}
		public static (bool IncludeElements, bool IncludeAddedMass, bool IncludeLoads, int NumberLoads, string[] LoadPat, double[] sf)
		    GetMassSource_1(this cPropMaterial obj) {
			bool IncludeElements, IncludeAddedMass, IncludeLoads;
			IncludeElements = IncludeAddedMass = IncludeLoads = default(bool);
			int NumberLoads;
			NumberLoads = default(int);
			string[] LoadPat;
			LoadPat = default(string[]);
			double[] sf;
			sf = default(double[]);
		    var res = obj.GetMassSource_1(ref IncludeElements, ref IncludeAddedMass, ref IncludeLoads, ref NumberLoads, ref LoadPat, ref sf);
		    return (IncludeElements, IncludeAddedMass, IncludeLoads, NumberLoads, LoadPat, sf);
		}

    }
}