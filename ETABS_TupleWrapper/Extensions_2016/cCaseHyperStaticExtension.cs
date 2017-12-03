
using System;
using ETABS2016;

namespace ETABS2016
{
    public static class cCaseHyperStaticExtension
    {
		public static string GetBaseCase(this cCaseHyperStatic obj, string Name) {
			string HyperStaticCase;
			HyperStaticCase = default(string);
		    var res = obj.GetBaseCase(Name, ref HyperStaticCase);
		    return HyperStaticCase;
		}

    }
}