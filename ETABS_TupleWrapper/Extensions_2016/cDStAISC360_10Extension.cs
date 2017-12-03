
using System;
using ETABS2016;

namespace ETABS2016
{
    public static class cDStAISC360_10Extension
    {
		public static (double Value, bool ProgDet) GetOverwrite(this cDStAISC360_10 obj, string Name, int Item) {
			double Value;
			Value = default(double);
			bool ProgDet;
			ProgDet = default(bool);
		    var res = obj.GetOverwrite(Name, Item, ref Value, ref ProgDet);
		    return (Value, ProgDet);
		}
		public static double GetPreference(this cDStAISC360_10 obj, int Item) {
			double Value;
			Value = default(double);
		    var res = obj.GetPreference(Item, ref Value);
		    return Value;
		}

    }
}