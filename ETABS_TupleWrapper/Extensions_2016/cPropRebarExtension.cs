
using System;
using ETABS2016;

namespace ETABS2016
{
    public static class cPropRebarExtension
    {
		public static (double Area, double Diameter) GetRebarProps(this cPropRebar obj, string Name) {
			double Area, Diameter;
			Area = Diameter = default(double);
		    var res = obj.GetRebarProps(Name, ref Area, ref Diameter);
		    return (Area, Diameter);
		}
		public static (double Area, double Diameter, string MyGUID) GetRebarPropsWithGUID(this cPropRebar obj, string Name) {
			double Area, Diameter;
			Area = Diameter = default(double);
			string MyGUID;
			MyGUID = default(string);
		    var res = obj.GetRebarPropsWithGUID(Name, ref Area, ref Diameter, ref MyGUID);
		    return (Area, Diameter, MyGUID);
		}
		public static (int NumberNames, string[] MyName) GetNameList(this cPropRebar obj) {
			int NumberNames;
			NumberNames = default(int);
			string[] MyName;
			MyName = default(string[]);
		    var res = obj.GetNameList(ref NumberNames, ref MyName);
		    return (NumberNames, MyName);
		}
		public static (int NumberNames, string[] MyName, double[] Areas, double[] Diameters, string[] MyGUID) GetNameListWithData(this cPropRebar obj) {
			int NumberNames;
			NumberNames = default(int);
			string[] MyName, MyGUID;
			MyName = MyGUID = default(string[]);
			double[] Areas, Diameters;
			Areas = Diameters = default(double[]);
		    var res = obj.GetNameListWithData(ref NumberNames, ref MyName, ref Areas, ref Diameters, ref MyGUID);
		    return (NumberNames, MyName, Areas, Diameters, MyGUID);
		}

    }
}