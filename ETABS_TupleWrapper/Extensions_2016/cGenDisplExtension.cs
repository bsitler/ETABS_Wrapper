
using System;
using ETABS2016;

namespace ETABS2016
{
    public static class cGenDisplExtension
    {
		public static int CountPoint(this cGenDispl obj, string Name) {
			int Count;
			Count = default(int);
		    var res = obj.CountPoint(Name, ref Count);
		    return Count;
		}
		public static (int NumberNames, string[] MyName) GetNameList(this cGenDispl obj) {
			int NumberNames;
			NumberNames = default(int);
			string[] MyName;
			MyName = default(string[]);
		    var res = obj.GetNameList(ref NumberNames, ref MyName);
		    return (NumberNames, MyName);
		}
		public static (int NumberItems, string[] PointName, double[] U1, double[] U2, double[] U3, double[] R1, double[] R2, double[] R3) GetPoint(this cGenDispl obj, string Name) {
			int NumberItems;
			NumberItems = default(int);
			string[] PointName;
			PointName = default(string[]);
			double[] U1, U2, U3, R1, R2, R3;
			U1 = U2 = U3 = R1 = R2 = R3 = default(double[]);
		    var res = obj.GetPoint(Name, ref NumberItems, ref PointName, ref U1, ref U2, ref U3, ref R1, ref R2, ref R3);
		    return (NumberItems, PointName, U1, U2, U3, R1, R2, R3);
		}
		public static int GetTypeOAPI(this cGenDispl obj, string name) {
			int MyType;
			MyType = default(int);
		    var res = obj.GetTypeOAPI(name, ref MyType);
		    return MyType;
		}
		public static int GetTypeGenDispl(this cGenDispl obj, string Name) {
			int MyType;
			MyType = default(int);
		    var res = obj.GetTypeGenDispl(Name, ref MyType);
		    return MyType;
		}

    }
}