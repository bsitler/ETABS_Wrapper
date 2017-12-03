using System;
using ETABS2016;

namespace ETABS2016
{
    public static class cDesignConcreteExtension
    {
		public static string
		    GetCode(this cDesignConcrete obj) {
			string CodeName;
			CodeName = default(string);
		    var res = obj.GetCode(ref CodeName);
		    return CodeName;
		}
		public static string
		    GetDesignSection(this cDesignConcrete obj, string Name) {
			string PropName;
			PropName = default(string);
		    var res = obj.GetDesignSection(Name, ref PropName);
		    return PropName;
		}
		public static (int NumberItems, string[] FrameName, double[] Location, string[] TopCombo, double[] TopArea, string[] BotCombo, double[] BotArea, string[] VMajorCombo, double[] VMajorArea, string[] TLCombo, double[] TLArea, string[] TTCombo, double[] TTArea, string[] ErrorSummary, string[] WarningSummary)
		    GetSummaryResultsBeam(this cDesignConcrete obj, string Name, eItemType ItemType = eItemType.Objects) {
			int NumberItems;
			NumberItems = default(int);
			string[] FrameName, TopCombo, BotCombo, VMajorCombo, TLCombo, TTCombo, ErrorSummary, WarningSummary;
			FrameName = TopCombo = BotCombo = VMajorCombo = TLCombo = TTCombo = ErrorSummary = WarningSummary = default(string[]);
			double[] Location, TopArea, BotArea, VMajorArea, TLArea, TTArea;
			Location = TopArea = BotArea = VMajorArea = TLArea = TTArea = default(double[]);
		    var res = obj.GetSummaryResultsBeam(Name, ref NumberItems, ref FrameName, ref Location, ref TopCombo, ref TopArea, ref BotCombo, ref BotArea, ref VMajorCombo, ref VMajorArea, ref TLCombo, ref TLArea, ref TTCombo, ref TTArea, ref ErrorSummary, ref WarningSummary, ItemType);
		    return (NumberItems, FrameName, Location, TopCombo, TopArea, BotCombo, BotArea, VMajorCombo, VMajorArea, TLCombo, TLArea, TTCombo, TTArea, ErrorSummary, WarningSummary);
		}
		public static (int NumberItems, string[] FrameName, int[] MyOption, double[] Location, string[] PMMCombo, double[] PMMArea, double[] PMMRatio, string[] VMajorCombo, double[] AVMajor, string[] VMinorCombo, double[] AVMinor, string[] ErrorSummary, string[] WarningSummary)
		    GetSummaryResultsColumn(this cDesignConcrete obj, string Name, eItemType ItemType = eItemType.Objects) {
			int NumberItems;
			NumberItems = default(int);
			string[] FrameName, PMMCombo, VMajorCombo, VMinorCombo, ErrorSummary, WarningSummary;
			FrameName = PMMCombo = VMajorCombo = VMinorCombo = ErrorSummary = WarningSummary = default(string[]);
			int[] MyOption;
			MyOption = default(int[]);
			double[] Location, PMMArea, PMMRatio, AVMajor, AVMinor;
			Location = PMMArea = PMMRatio = AVMajor = AVMinor = default(double[]);
		    var res = obj.GetSummaryResultsColumn(Name, ref NumberItems, ref FrameName, ref MyOption, ref Location, ref PMMCombo, ref PMMArea, ref PMMRatio, ref VMajorCombo, ref AVMajor, ref VMinorCombo, ref AVMinor, ref ErrorSummary, ref WarningSummary, ItemType);
		    return (NumberItems, FrameName, MyOption, Location, PMMCombo, PMMArea, PMMRatio, VMajorCombo, AVMajor, VMinorCombo, AVMinor, ErrorSummary, WarningSummary);
		}
		public static (int NumberItems, string[] FrameName, string[] LCJSRatioMajor, double[] JSRatioMajor, string[] LCJSRatioMinor, double[] JSRatioMinor, string[] LCBCCRatioMajor, double[] BCCRatioMajor, string[] LCBCCRatioMinor, double[] BCCRatioMinor, string[] ErrorSummary, string[] WarningSummary)
		    GetSummaryResultsJoint(this cDesignConcrete obj, string Name, eItemType ItemType = eItemType.Objects) {
			int NumberItems;
			NumberItems = default(int);
			string[] FrameName, LCJSRatioMajor, LCJSRatioMinor, LCBCCRatioMajor, LCBCCRatioMinor, ErrorSummary, WarningSummary;
			FrameName = LCJSRatioMajor = LCJSRatioMinor = LCBCCRatioMajor = LCBCCRatioMinor = ErrorSummary = WarningSummary = default(string[]);
			double[] JSRatioMajor, JSRatioMinor, BCCRatioMajor, BCCRatioMinor;
			JSRatioMajor = JSRatioMinor = BCCRatioMajor = BCCRatioMinor = default(double[]);
		    var res = obj.GetSummaryResultsJoint(Name, ref NumberItems, ref FrameName, ref LCJSRatioMajor, ref JSRatioMajor, ref LCJSRatioMinor, ref JSRatioMinor, ref LCBCCRatioMajor, ref BCCRatioMajor, ref LCBCCRatioMinor, ref BCCRatioMinor, ref ErrorSummary, ref WarningSummary, ItemType);
		    return (NumberItems, FrameName, LCJSRatioMajor, JSRatioMajor, LCJSRatioMinor, JSRatioMinor, LCBCCRatioMajor, BCCRatioMajor, LCBCCRatioMinor, BCCRatioMinor, ErrorSummary, WarningSummary);
		}

    }
}