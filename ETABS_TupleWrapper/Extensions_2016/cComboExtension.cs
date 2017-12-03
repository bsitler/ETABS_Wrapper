
using System;
using ETABS2016;

namespace ETABS2016
{
    public static class cComboExtension
    {
		public static (int NumberItems, eCNameType[] CNameType, string[] CName, double[] SF) GetCaseList(this cCombo obj, string Name) {
			int NumberItems;
			NumberItems = default(int);
			eCNameType[] CNameType;
			CNameType = default(eCNameType[]);
			string[] CName;
			CName = default(string[]);
			double[] SF;
			SF = default(double[]);
		    var res = obj.GetCaseList(Name, ref NumberItems, ref CNameType, ref CName, ref SF);
		    return (NumberItems, CNameType, CName, SF);
		}
		public static (int NumberNames, string[] MyName) GetNameList(this cCombo obj) {
			int NumberNames;
			NumberNames = default(int);
			string[] MyName;
			MyName = default(string[]);
		    var res = obj.GetNameList(ref NumberNames, ref MyName);
		    return (NumberNames, MyName);
		}
		public static int GetTypeOAPI(this cCombo obj, string name) {
			int ComboType;
			ComboType = default(int);
		    var res = obj.GetTypeOAPI(name, ref ComboType);
		    return ComboType;
		}
		public static int GetTypeCombo(this cCombo obj, string Name) {
			int ComboType;
			ComboType = default(int);
		    var res = obj.GetTypeCombo(Name, ref ComboType);
		    return ComboType;
		}

    }
}