
using System;
using ETABS2016;

namespace ETABS2016
{
    public static class cCaseModalHistoryLinearExtension
    {
		public static (int NumberLoads, string[] LoadType, string[] LoadName, string[] Func, double[] SF, double[] Tf, double[] At, string[] CSys, double[] Ang) GetLoads(this cCaseModalHistoryLinear obj, string Name) {
			int NumberLoads;
			NumberLoads = default(int);
			string[] LoadType, LoadName, Func, CSys;
			LoadType = LoadName = Func = CSys = default(string[]);
			double[] SF, Tf, At, Ang;
			SF = Tf = At = Ang = default(double[]);
		    var res = obj.GetLoads(Name, ref NumberLoads, ref LoadType, ref LoadName, ref Func, ref SF, ref Tf, ref At, ref CSys, ref Ang);
		    return (NumberLoads, LoadType, LoadName, Func, SF, Tf, At, CSys, Ang);
		}

    }
}