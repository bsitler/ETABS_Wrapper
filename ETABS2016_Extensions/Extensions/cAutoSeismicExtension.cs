using System;
using ETABS2016;

namespace ETABS2016
{
    public static class cAutoSeismicExtension
    {
		public static (int DirFlag, double Eccen, int PeriodFlag, int CtType, double UserT, bool UserZ, double TopZ, double BottomZ, double R, double Omega, double Cd, double I, int IBC2006Option, double Latitude, double Longitude, string ZipCode, double Ss, double S1, double Tl, int SiteClass, double Fa, double Fv)
		    GetIBC2006(this cAutoSeismic obj, string Name) {
			int DirFlag, PeriodFlag, CtType, IBC2006Option, SiteClass;
			DirFlag = PeriodFlag = CtType = IBC2006Option = SiteClass = default(int);
			double Eccen, UserT, TopZ, BottomZ, R, Omega, Cd, I, Latitude, Longitude, Ss, S1, Tl, Fa, Fv;
			Eccen = UserT = TopZ = BottomZ = R = Omega = Cd = I = Latitude = Longitude = Ss = S1 = Tl = Fa = Fv = default(double);
			bool UserZ;
			UserZ = default(bool);
			string ZipCode;
			ZipCode = default(string);
		    var res = obj.GetIBC2006(Name, ref DirFlag, ref Eccen, ref PeriodFlag, ref CtType, ref UserT, ref UserZ, ref TopZ, ref BottomZ, ref R, ref Omega, ref Cd, ref I, ref IBC2006Option, ref Latitude, ref Longitude, ref ZipCode, ref Ss, ref S1, ref Tl, ref SiteClass, ref Fa, ref Fv);
		    return (DirFlag, Eccen, PeriodFlag, CtType, UserT, UserZ, TopZ, BottomZ, R, Omega, Cd, I, IBC2006Option, Latitude, Longitude, ZipCode, Ss, S1, Tl, SiteClass, Fa, Fv);
		}

    }
}