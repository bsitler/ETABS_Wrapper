using System;
using ETABS2016;

namespace ETABS2016
{
    public static class cDesignSteelExtension
    {
		public static string
		    GetCode(this cDesignSteel obj) {
			string CodeName;
			CodeName = default(string);
		    var res = obj.GetCode(ref CodeName);
		    return CodeName;
		}
		public static (int NumberItems, string[] MyName)
		    GetComboDeflection(this cDesignSteel obj) {
			int NumberItems;
			NumberItems = default(int);
			string[] MyName;
			MyName = default(string[]);
		    var res = obj.GetComboDeflection(ref NumberItems, ref MyName);
		    return (NumberItems, MyName);
		}
		public static (int NumberItems, string[] MyName)
		    GetComboStrength(this cDesignSteel obj) {
			int NumberItems;
			NumberItems = default(int);
			string[] MyName;
			MyName = default(string[]);
		    var res = obj.GetComboStrength(ref NumberItems, ref MyName);
		    return (NumberItems, MyName);
		}
		public static string
		    GetDesignSection(this cDesignSteel obj, string Name) {
			string PropName;
			PropName = default(string);
		    var res = obj.GetDesignSection(Name, ref PropName);
		    return PropName;
		}
		public static (int NumberItems, string[] MyName)
		    GetGroup(this cDesignSteel obj) {
			int NumberItems;
			NumberItems = default(int);
			string[] MyName;
			MyName = default(string[]);
		    var res = obj.GetGroup(ref NumberItems, ref MyName);
		    return (NumberItems, MyName);
		}
		public static (int NumberItems, string[] FrameName, double[] Ratio, int[] RatioType, double[] Location, string[] ComboName, string[] ErrorSummary, string[] WarningSummary)
		    GetSummaryResults(this cDesignSteel obj, string Name, eItemType ItemType = eItemType.Objects) {
			int NumberItems;
			NumberItems = default(int);
			string[] FrameName, ComboName, ErrorSummary, WarningSummary;
			FrameName = ComboName = ErrorSummary = WarningSummary = default(string[]);
			double[] Ratio, Location;
			Ratio = Location = default(double[]);
			int[] RatioType;
			RatioType = default(int[]);
		    var res = obj.GetSummaryResults(Name, ref NumberItems, ref FrameName, ref Ratio, ref RatioType, ref Location, ref ComboName, ref ErrorSummary, ref WarningSummary, ItemType);
		    return (NumberItems, FrameName, Ratio, RatioType, Location, ComboName, ErrorSummary, WarningSummary);
		}
		public static (int NumberItems, string[] LoadCase, string[] Point, double[] Displ, bool Active)
		    GetTargetDispl(this cDesignSteel obj) {
			int NumberItems;
			NumberItems = default(int);
			string[] LoadCase, Point;
			LoadCase = Point = default(string[]);
			double[] Displ;
			Displ = default(double[]);
			bool Active;
			Active = default(bool);
		    var res = obj.GetTargetDispl(ref NumberItems, ref LoadCase, ref Point, ref Displ, ref Active);
		    return (NumberItems, LoadCase, Point, Displ, Active);
		}
		public static (int NumberItems, string ModalCase, int[] Mode, double[] Period, bool Active)
		    GetTargetPeriod(this cDesignSteel obj) {
			int NumberItems;
			NumberItems = default(int);
			string ModalCase;
			ModalCase = default(string);
			int[] Mode;
			Mode = default(int[]);
			double[] Period;
			Period = default(double[]);
			bool Active;
			Active = default(bool);
		    var res = obj.GetTargetPeriod(ref NumberItems, ref ModalCase, ref Mode, ref Period, ref Active);
		    return (NumberItems, ModalCase, Mode, Period, Active);
		}
		public static (int NumberItems, int N1, int N2, string[] MyName)
		    VerifyPassed(this cDesignSteel obj) {
			int NumberItems, N1, N2;
			NumberItems = N1 = N2 = default(int);
			string[] MyName;
			MyName = default(string[]);
		    var res = obj.VerifyPassed(ref NumberItems, ref N1, ref N2, ref MyName);
		    return (NumberItems, N1, N2, MyName);
		}
		public static (int NumberItems, string[] MyName)
		    VerifySections(this cDesignSteel obj) {
			int NumberItems;
			NumberItems = default(int);
			string[] MyName;
			MyName = default(string[]);
		    var res = obj.VerifySections(ref NumberItems, ref MyName);
		    return (NumberItems, MyName);
		}
		public static (int NumberItems, string[] FrameType, string[] DesignSect, string[] Status, string[] PMMCombo, double[] PMMRatio, double[] PRatio, double[] MMajRatio, double[] MMinRatio, string[] VMajCombo, double[] VMajRatio, string[] VMinCombo, double[] VMinRatio)
		    GetSummaryResults_2(this cDesignSteel obj, string Name, eItemType ItemType = eItemType.Objects) {
			int NumberItems;
			NumberItems = default(int);
			string[] FrameType, DesignSect, Status, PMMCombo, VMajCombo, VMinCombo;
			FrameType = DesignSect = Status = PMMCombo = VMajCombo = VMinCombo = default(string[]);
			double[] PMMRatio, PRatio, MMajRatio, MMinRatio, VMajRatio, VMinRatio;
			PMMRatio = PRatio = MMajRatio = MMinRatio = VMajRatio = VMinRatio = default(double[]);
		    var res = obj.GetSummaryResults_2(Name, ref NumberItems, ref FrameType, ref DesignSect, ref Status, ref PMMCombo, ref PMMRatio, ref PRatio, ref MMajRatio, ref MMinRatio, ref VMajCombo, ref VMajRatio, ref VMinCombo, ref VMinRatio, ItemType);
		    return (NumberItems, FrameType, DesignSect, Status, PMMCombo, PMMRatio, PRatio, MMajRatio, MMinRatio, VMajCombo, VMajRatio, VMinCombo, VMinRatio);
		}

    }
}