using System;
using ETABS2016;

namespace ETABS2016
{
    public static class cLoadCasesExtension
    {
		public static (int NumberNames, string[] MyName)
		    GetNameList(this cLoadCases obj, eLoadCaseType CaseType = (eLoadCaseType)0) {
			int NumberNames;
			NumberNames = default(int);
			string[] MyName;
			MyName = default(string[]);
		    var res = obj.GetNameList(ref NumberNames, ref MyName, CaseType);
		    return (NumberNames, MyName);
		}
		public static (eLoadCaseType CaseType, int SubType, eLoadPatternType DesignType, int DesignTypeOption, int Auto)
		    GetTypeOAPI_1(this cLoadCases obj, string Name) {
			eLoadCaseType CaseType;
			CaseType = default(eLoadCaseType);
			int SubType, DesignTypeOption, Auto;
			SubType = DesignTypeOption = Auto = default(int);
			eLoadPatternType DesignType;
			DesignType = default(eLoadPatternType);
		    var res = obj.GetTypeOAPI_1(Name, ref CaseType, ref SubType, ref DesignType, ref DesignTypeOption, ref Auto);
		    return (CaseType, SubType, DesignType, DesignTypeOption, Auto);
		}
		public static (eLoadCaseType CaseType, int SubType)
		    GetTypeOAPI(this cLoadCases obj, string Name) {
			eLoadCaseType CaseType;
			CaseType = default(eLoadCaseType);
			int SubType;
			SubType = default(int);
		    var res = obj.GetTypeOAPI(Name, ref CaseType, ref SubType);
		    return (CaseType, SubType);
		}

    }
}