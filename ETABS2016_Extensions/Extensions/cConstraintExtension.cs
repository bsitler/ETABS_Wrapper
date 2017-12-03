using System;
using ETABS2016;

namespace ETABS2016
{
    public static class cConstraintExtension
    {
		public static (eConstraintAxis Axis, string CSys)
		    GetDiaphragm(this cConstraint obj, string Name) {
			eConstraintAxis Axis;
			Axis = default(eConstraintAxis);
			string CSys;
			CSys = default(string);
		    var res = obj.GetDiaphragm(Name, ref Axis, ref CSys);
		    return (Axis, CSys);
		}
		public static (int NumberNames, string[] MyName)
		    GetNameList(this cConstraint obj) {
			int NumberNames;
			NumberNames = default(int);
			string[] MyName;
			MyName = default(string[]);
		    var res = obj.GetNameList(ref NumberNames, ref MyName);
		    return (NumberNames, MyName);
		}

    }
}