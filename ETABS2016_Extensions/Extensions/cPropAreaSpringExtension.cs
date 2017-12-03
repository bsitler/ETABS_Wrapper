using System;
using ETABS2016;

namespace ETABS2016
{
    public static class cPropAreaSpringExtension
    {
		public static (double U1, double U2, double U3, int NonlinearOption3, int SpringOption, string SoilProfile, double EndLengthRatio, double Period, int color, string notes, string iGUID)
		    GetAreaSpringProp(this cPropAreaSpring obj, string Name) {
			double U1, U2, U3, EndLengthRatio, Period;
			U1 = U2 = U3 = EndLengthRatio = Period = default(double);
			int NonlinearOption3, SpringOption, color;
			NonlinearOption3 = SpringOption = color = default(int);
			string SoilProfile, notes, iGUID;
			SoilProfile = notes = iGUID = default(string);
		    var res = obj.GetAreaSpringProp(Name, ref U1, ref U2, ref U3, ref NonlinearOption3, ref SpringOption, ref SoilProfile, ref EndLengthRatio, ref Period, ref color, ref notes, ref iGUID);
		    return (U1, U2, U3, NonlinearOption3, SpringOption, SoilProfile, EndLengthRatio, Period, color, notes, iGUID);
		}
		public static (int NumberNames, string[] MyName)
		    GetNameList(this cPropAreaSpring obj) {
			int NumberNames;
			NumberNames = default(int);
			string[] MyName;
			MyName = default(string[]);
		    var res = obj.GetNameList(ref NumberNames, ref MyName);
		    return (NumberNames, MyName);
		}

    }
}