
using System;
using ETABS2016;

namespace ETABS2016
{
    public static class cPropPointSpringExtension
    {
		public static (int NumberLinks, string[] LinkNames, int[] LinkAxialDirs, double[] LinkAngles) GetLinks(this cPropPointSpring obj, string Name) {
			int NumberLinks;
			NumberLinks = default(int);
			string[] LinkNames;
			LinkNames = default(string[]);
			int[] LinkAxialDirs;
			LinkAxialDirs = default(int[]);
			double[] LinkAngles;
			LinkAngles = default(double[]);
		    var res = obj.GetLinks(Name, ref NumberLinks, ref LinkNames, ref LinkAxialDirs, ref LinkAngles);
		    return (NumberLinks, LinkNames, LinkAxialDirs, LinkAngles);
		}
		public static (int NumberNames, string[] MyName) GetNameList(this cPropPointSpring obj) {
			int NumberNames;
			NumberNames = default(int);
			string[] MyName;
			MyName = default(string[]);
		    var res = obj.GetNameList(ref NumberNames, ref MyName);
		    return (NumberNames, MyName);
		}
		public static (int SpringOption, double[] k, string CSys, string SoilProfile, string Footing, double Period, int color, string notes, string iGUID) GetPointSpringProp(this cPropPointSpring obj, string Name) {
			int SpringOption, color;
			SpringOption = color = default(int);
			double[] k;
			k = default(double[]);
			string CSys, SoilProfile, Footing, notes, iGUID;
			CSys = SoilProfile = Footing = notes = iGUID = default(string);
			double Period;
			Period = default(double);
		    var res = obj.GetPointSpringProp(Name, ref SpringOption, ref k, ref CSys, ref SoilProfile, ref Footing, ref Period, ref color, ref notes, ref iGUID);
		    return (SpringOption, k, CSys, SoilProfile, Footing, Period, color, notes, iGUID);
		}

    }
}