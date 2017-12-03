
using System;
using ETABS2016;

namespace ETABS2016
{
    public static class cDesignCompositeBeamExtension
    {
		public static string GetCode(this cDesignCompositeBeam obj) {
			string CodeName;
			CodeName = default(string);
		    var res = obj.GetCode(ref CodeName);
		    return CodeName;
		}
		public static (int NumberItems, string[] MyName) GetComboDeflection(this cDesignCompositeBeam obj) {
			int NumberItems;
			NumberItems = default(int);
			string[] MyName;
			MyName = default(string[]);
		    var res = obj.GetComboDeflection(ref NumberItems, ref MyName);
		    return (NumberItems, MyName);
		}
		public static (int NumberItems, string[] MyName) GetComboStrength(this cDesignCompositeBeam obj) {
			int NumberItems;
			NumberItems = default(int);
			string[] MyName;
			MyName = default(string[]);
		    var res = obj.GetComboStrength(ref NumberItems, ref MyName);
		    return (NumberItems, MyName);
		}
		public static string GetDesignSection(this cDesignCompositeBeam obj, string Name) {
			string PropName;
			PropName = default(string);
		    var res = obj.GetDesignSection(Name, ref PropName);
		    return PropName;
		}
		public static (int NumberItems, string[] MyName) GetGroup(this cDesignCompositeBeam obj) {
			int NumberItems;
			NumberItems = default(int);
			string[] MyName;
			MyName = default(string[]);
		    var res = obj.GetGroup(ref NumberItems, ref MyName);
		    return (NumberItems, MyName);
		}
		public static (int NumberItems, string[] DesignSect, double[] BeamFy, double[] StudDia, string[] StudLayout, bool[] BeamShored, double[] BeamCamber, string[] PassFail, double[] ReacLeft, double[] ReacRt, double[] MMaxNeg, double[] MMaxPos, double[] PCC, double[] OverallRatio, double[] StudRatio, double[] StrPMRat, double[] ConstPMRat, double[] StrShrRat, double[] ConShrRat, double[] PCDLDfRat, double[] SDLDfRat, double[] LLDfRat, double[] TotCamDfRat, double[] FreqRat, double[] MDampRat) GetSummaryResults(this cDesignCompositeBeam obj, string Name, eItemType ItemType) {
			int NumberItems;
			NumberItems = default(int);
			string[] DesignSect, StudLayout, PassFail;
			DesignSect = StudLayout = PassFail = default(string[]);
			double[] BeamFy, StudDia, BeamCamber, ReacLeft, ReacRt, MMaxNeg, MMaxPos, PCC, OverallRatio, StudRatio, StrPMRat, ConstPMRat, StrShrRat, ConShrRat, PCDLDfRat, SDLDfRat, LLDfRat, TotCamDfRat, FreqRat, MDampRat;
			BeamFy = StudDia = BeamCamber = ReacLeft = ReacRt = MMaxNeg = MMaxPos = PCC = OverallRatio = StudRatio = StrPMRat = ConstPMRat = StrShrRat = ConShrRat = PCDLDfRat = SDLDfRat = LLDfRat = TotCamDfRat = FreqRat = MDampRat = default(double[]);
			bool[] BeamShored;
			BeamShored = default(bool[]);
		    var res = obj.GetSummaryResults(Name, ref NumberItems, ref DesignSect, ref BeamFy, ref StudDia, ref StudLayout, ref BeamShored, ref BeamCamber, ref PassFail, ref ReacLeft, ref ReacRt, ref MMaxNeg, ref MMaxPos, ref PCC, ref OverallRatio, ref StudRatio, ref StrPMRat, ref ConstPMRat, ref StrShrRat, ref ConShrRat, ref PCDLDfRat, ref SDLDfRat, ref LLDfRat, ref TotCamDfRat, ref FreqRat, ref MDampRat, ItemType);
		    return (NumberItems, DesignSect, BeamFy, StudDia, StudLayout, BeamShored, BeamCamber, PassFail, ReacLeft, ReacRt, MMaxNeg, MMaxPos, PCC, OverallRatio, StudRatio, StrPMRat, ConstPMRat, StrShrRat, ConShrRat, PCDLDfRat, SDLDfRat, LLDfRat, TotCamDfRat, FreqRat, MDampRat);
		}
		public static (int NumberItems, string[] LoadCase, string[] Point, double[] Displ, bool Active) GetTargetDispl(this cDesignCompositeBeam obj) {
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
		public static (int NumberItems, string ModalCase, int[] Mode, double[] Period, bool Active) GetTargetPeriod(this cDesignCompositeBeam obj) {
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
		public static (int NumberItems, int N1, int N2, string[] MyName) VerifyPassed(this cDesignCompositeBeam obj) {
			int NumberItems, N1, N2;
			NumberItems = N1 = N2 = default(int);
			string[] MyName;
			MyName = default(string[]);
		    var res = obj.VerifyPassed(ref NumberItems, ref N1, ref N2, ref MyName);
		    return (NumberItems, N1, N2, MyName);
		}
		public static (int NumberItems, string[] MyName) VerifySections(this cDesignCompositeBeam obj) {
			int NumberItems;
			NumberItems = default(int);
			string[] MyName;
			MyName = default(string[]);
		    var res = obj.VerifySections(ref NumberItems, ref MyName);
		    return (NumberItems, MyName);
		}

    }
}