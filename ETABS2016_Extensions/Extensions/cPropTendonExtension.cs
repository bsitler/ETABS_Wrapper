using System;
using ETABS2016;

namespace ETABS2016
{
    public static class cPropTendonExtension
    {
		public static (int NumberNames, string[] MyName)
		    GetNameList(this cPropTendon obj) {
			int NumberNames;
			NumberNames = default(int);
			string[] MyName;
			MyName = default(string[]);
		    var res = obj.GetNameList(ref NumberNames, ref MyName);
		    return (NumberNames, MyName);
		}
		public static (string MatProp, int ModelingOption, double Area, int Color, string Notes, string GUID)
		    GetProp(this cPropTendon obj, string Name) {
			string MatProp, Notes, GUID;
			MatProp = Notes = GUID = default(string);
			int ModelingOption, Color;
			ModelingOption = Color = default(int);
			double Area;
			Area = default(double);
		    var res = obj.GetProp(Name, ref MatProp, ref ModelingOption, ref Area, ref Color, ref Notes, ref GUID);
		    return (MatProp, ModelingOption, Area, Color, Notes, GUID);
		}

    }
}