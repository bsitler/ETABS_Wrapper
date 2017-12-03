
using System;
using ETABS2016;

namespace ETABS2016
{
    public static class cCaseStaticLinearExtension
    {
		public static string GetInitialCase(this cCaseStaticLinear obj, string Name) {
			string InitialCase;
			InitialCase = default(string);
		    var res = obj.GetInitialCase(Name, ref InitialCase);
		    return InitialCase;
		}
		public static (int NumberLoads, string[] LoadType, string[] LoadName, double[] SF) GetLoads(this cCaseStaticLinear obj, string Name) {
			int NumberLoads;
			NumberLoads = default(int);
			string[] LoadType, LoadName;
			LoadType = LoadName = default(string[]);
			double[] SF;
			SF = default(double[]);
		    var res = obj.GetLoads(Name, ref NumberLoads, ref LoadType, ref LoadName, ref SF);
		    return (NumberLoads, LoadType, LoadName, SF);
		}

    }
}