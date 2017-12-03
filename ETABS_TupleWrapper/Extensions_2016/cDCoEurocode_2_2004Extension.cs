
using System;
using ETABS2016;

namespace ETABS2016
{
    public static class cDCoEurocode_2_2004Extension
    {
		public static (double Value, bool ProgDet) GetOverwrite(this cDCoEurocode_2_2004 obj, string Name, int Item) {
			double Value;
			Value = default(double);
			bool ProgDet;
			ProgDet = default(bool);
		    var res = obj.GetOverwrite(Name, Item, ref Value, ref ProgDet);
		    return (Value, ProgDet);
		}
		public static double GetPreference(this cDCoEurocode_2_2004 obj, int Item) {
			double Value;
			Value = default(double);
		    var res = obj.GetPreference(Item, ref Value);
		    return Value;
		}

    }
}