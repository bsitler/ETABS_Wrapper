using System;
using ETABS2016;

namespace ETABS2016
{
    public static class cAnalysisResultsSetupExtension
    {
		public static bool
		    GetCaseSelectedForOutput(this cAnalysisResultsSetup obj, string Name) {
			bool Selected;
			Selected = default(bool);
		    var res = obj.GetCaseSelectedForOutput(Name, ref Selected);
		    return Selected;
		}
		public static bool
		    GetComboSelectedForOutput(this cAnalysisResultsSetup obj, string Name) {
			bool Selected;
			Selected = default(bool);
		    var res = obj.GetComboSelectedForOutput(Name, ref Selected);
		    return Selected;
		}
		public static (double GX, double GY, double GZ)
		    GetOptionBaseReactLoc(this cAnalysisResultsSetup obj) {
			double GX, GY, GZ;
			GX = GY = GZ = default(double);
		    var res = obj.GetOptionBaseReactLoc(ref GX, ref GY, ref GZ);
		    return (GX, GY, GZ);
		}
		public static (int BuckModeStart, int BuckModeEnd, bool BuckModeAll)
		    GetOptionBucklingMode(this cAnalysisResultsSetup obj) {
			int BuckModeStart, BuckModeEnd;
			BuckModeStart = BuckModeEnd = default(int);
			bool BuckModeAll;
			BuckModeAll = default(bool);
		    var res = obj.GetOptionBucklingMode(ref BuckModeStart, ref BuckModeEnd, ref BuckModeAll);
		    return (BuckModeStart, BuckModeEnd, BuckModeAll);
		}
		public static int
		    GetOptionDirectHist(this cAnalysisResultsSetup obj) {
			int Value;
			Value = default(int);
		    var res = obj.GetOptionDirectHist(ref Value);
		    return Value;
		}
		public static int
		    GetOptionModalHist(this cAnalysisResultsSetup obj) {
			int Value;
			Value = default(int);
		    var res = obj.GetOptionModalHist(ref Value);
		    return Value;
		}
		public static (int ModeShapeStart, int ModeShapeEnd, bool ModeShapesAll)
		    GetOptionModeShape(this cAnalysisResultsSetup obj) {
			int ModeShapeStart, ModeShapeEnd;
			ModeShapeStart = ModeShapeEnd = default(int);
			bool ModeShapesAll;
			ModeShapesAll = default(bool);
		    var res = obj.GetOptionModeShape(ref ModeShapeStart, ref ModeShapeEnd, ref ModeShapesAll);
		    return (ModeShapeStart, ModeShapeEnd, ModeShapesAll);
		}
		public static int
		    GetOptionMultiStepStatic(this cAnalysisResultsSetup obj) {
			int Value;
			Value = default(int);
		    var res = obj.GetOptionMultiStepStatic(ref Value);
		    return Value;
		}
		public static int
		    GetOptionMultiValuedCombo(this cAnalysisResultsSetup obj) {
			int Value;
			Value = default(int);
		    var res = obj.GetOptionMultiValuedCombo(ref Value);
		    return Value;
		}
		public static int
		    GetOptionNLStatic(this cAnalysisResultsSetup obj) {
			int Value;
			Value = default(int);
		    var res = obj.GetOptionNLStatic(ref Value);
		    return Value;
		}

    }
}