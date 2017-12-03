
using System;
using ETABS2016;

namespace ETABS2016
{
    public static class cDiaphragmExtension
    {
		public static bool GetDiaphragm(this cDiaphragm obj, string Name) {
			bool SemiRigid;
			SemiRigid = default(bool);
		    var res = obj.GetDiaphragm(Name, ref SemiRigid);
		    return SemiRigid;
		}
		public static (int NumberNames, string[] MyName) GetNameList(this cDiaphragm obj) {
			int NumberNames;
			NumberNames = default(int);
			string[] MyName;
			MyName = default(string[]);
		    var res = obj.GetNameList(ref NumberNames, ref MyName);
		    return (NumberNames, MyName);
		}

    }
}