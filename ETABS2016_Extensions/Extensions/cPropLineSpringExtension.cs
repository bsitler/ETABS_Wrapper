using System;
using ETABS2016;

namespace ETABS2016
{
    public static class cPropLineSpringExtension
    {
		public static (double U1, double U2, double U3, double R1, int NonlinearOption2, int NonlinearOption3, int color, string notes, string iGUID)
		    GetLineSpringProp(this cPropLineSpring obj, string Name) {
			double U1, U2, U3, R1;
			U1 = U2 = U3 = R1 = default(double);
			int NonlinearOption2, NonlinearOption3, color;
			NonlinearOption2 = NonlinearOption3 = color = default(int);
			string notes, iGUID;
			notes = iGUID = default(string);
		    var res = obj.GetLineSpringProp(Name, ref U1, ref U2, ref U3, ref R1, ref NonlinearOption2, ref NonlinearOption3, ref color, ref notes, ref iGUID);
		    return (U1, U2, U3, R1, NonlinearOption2, NonlinearOption3, color, notes, iGUID);
		}
		public static (int NumberNames, string[] MyName)
		    GetNameList(this cPropLineSpring obj) {
			int NumberNames;
			NumberNames = default(int);
			string[] MyName;
			MyName = default(string[]);
		    var res = obj.GetNameList(ref NumberNames, ref MyName);
		    return (NumberNames, MyName);
		}

    }
}