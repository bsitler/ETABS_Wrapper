using System;
using ETABS2016;

namespace ETABS2016
{
    public static class cFunctionExtension
    {
		public static (int NumberNames, string[] MyName)
		    GetNameList(this cFunction obj, int FuncType = 0) {
			int NumberNames;
			NumberNames = default(int);
			string[] MyName;
			MyName = default(string[]);
		    var res = obj.GetNameList(ref NumberNames, ref MyName, FuncType);
		    return (NumberNames, MyName);
		}
		public static (int FuncType, int AddType)
		    GetTypeOAPI(this cFunction obj, string Name) {
			int FuncType, AddType;
			FuncType = AddType = default(int);
		    var res = obj.GetTypeOAPI(Name, ref FuncType, ref AddType);
		    return (FuncType, AddType);
		}
		public static (int NumberItems, double[] MyTime, double[] Value)
		    GetValues(this cFunction obj, string Name) {
			int NumberItems;
			NumberItems = default(int);
			double[] MyTime, Value;
			MyTime = Value = default(double[]);
		    var res = obj.GetValues(Name, ref NumberItems, ref MyTime, ref Value);
		    return (NumberItems, MyTime, Value);
		}

    }
}