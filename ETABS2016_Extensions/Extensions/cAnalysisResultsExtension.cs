using System;
using ETABS2016;

namespace ETABS2016
{
    public static class cAnalysisResultsExtension
    {
		public static (int NumberResults, string[] Obj, string[] Elm, string[] PointElm, string[] LoadCase, string[] StepType, double[] StepNum, double[] F11, double[] F22, double[] F12, double[] FMax, double[] FMin, double[] FAngle, double[] FVM, double[] M11, double[] M22, double[] M12, double[] MMax, double[] MMin, double[] MAngle, double[] V13, double[] V23, double[] VMax, double[] VAngle)
		    AreaForceShell(this cAnalysisResults obj, string Name, eItemTypeElm ItemTypeElm) {
			int NumberResults;
			NumberResults = default(int);
			string[] Obj, Elm, PointElm, LoadCase, StepType;
			Obj = Elm = PointElm = LoadCase = StepType = default(string[]);
			double[] StepNum, F11, F22, F12, FMax, FMin, FAngle, FVM, M11, M22, M12, MMax, MMin, MAngle, V13, V23, VMax, VAngle;
			StepNum = F11 = F22 = F12 = FMax = FMin = FAngle = FVM = M11 = M22 = M12 = MMax = MMin = MAngle = V13 = V23 = VMax = VAngle = default(double[]);
		    var res = obj.AreaForceShell(Name, ItemTypeElm, ref NumberResults, ref Obj, ref Elm, ref PointElm, ref LoadCase, ref StepType, ref StepNum, ref F11, ref F22, ref F12, ref FMax, ref FMin, ref FAngle, ref FVM, ref M11, ref M22, ref M12, ref MMax, ref MMin, ref MAngle, ref V13, ref V23, ref VMax, ref VAngle);
		    return (NumberResults, Obj, Elm, PointElm, LoadCase, StepType, StepNum, F11, F22, F12, FMax, FMin, FAngle, FVM, M11, M22, M12, MMax, MMin, MAngle, V13, V23, VMax, VAngle);
		}
		public static (int NumberResults, string[] Obj, string[] Elm, string[] PointElm, string[] LoadCase, string[] StepType, double[] StepNum, double[] F1, double[] F2, double[] F3, double[] M1, double[] M2, double[] M3)
		    AreaJointForceShell(this cAnalysisResults obj, string Name, eItemTypeElm ItemTypeElm) {
			int NumberResults;
			NumberResults = default(int);
			string[] Obj, Elm, PointElm, LoadCase, StepType;
			Obj = Elm = PointElm = LoadCase = StepType = default(string[]);
			double[] StepNum, F1, F2, F3, M1, M2, M3;
			StepNum = F1 = F2 = F3 = M1 = M2 = M3 = default(double[]);
		    var res = obj.AreaJointForceShell(Name, ItemTypeElm, ref NumberResults, ref Obj, ref Elm, ref PointElm, ref LoadCase, ref StepType, ref StepNum, ref F1, ref F2, ref F3, ref M1, ref M2, ref M3);
		    return (NumberResults, Obj, Elm, PointElm, LoadCase, StepType, StepNum, F1, F2, F3, M1, M2, M3);
		}
		public static (int NumberResults, string[] Obj, string[] Elm, string[] PointElm, string[] LoadCase, string[] StepType, double[] StepNum, double[] S11Top, double[] S22Top, double[] S12Top, double[] SMaxTop, double[] SMinTop, double[] SAngleTop, double[] SVMTop, double[] S11Bot, double[] S22Bot, double[] S12Bot, double[] SMaxBot, double[] SMinBot, double[] SAngleBot, double[] SVMBot, double[] S13Avg, double[] S23Avg, double[] SMaxAvg, double[] SAngleAvg)
		    AreaStressShell(this cAnalysisResults obj, string Name, eItemTypeElm ItemTypeElm) {
			int NumberResults;
			NumberResults = default(int);
			string[] Obj, Elm, PointElm, LoadCase, StepType;
			Obj = Elm = PointElm = LoadCase = StepType = default(string[]);
			double[] StepNum, S11Top, S22Top, S12Top, SMaxTop, SMinTop, SAngleTop, SVMTop, S11Bot, S22Bot, S12Bot, SMaxBot, SMinBot, SAngleBot, SVMBot, S13Avg, S23Avg, SMaxAvg, SAngleAvg;
			StepNum = S11Top = S22Top = S12Top = SMaxTop = SMinTop = SAngleTop = SVMTop = S11Bot = S22Bot = S12Bot = SMaxBot = SMinBot = SAngleBot = SVMBot = S13Avg = S23Avg = SMaxAvg = SAngleAvg = default(double[]);
		    var res = obj.AreaStressShell(Name, ItemTypeElm, ref NumberResults, ref Obj, ref Elm, ref PointElm, ref LoadCase, ref StepType, ref StepNum, ref S11Top, ref S22Top, ref S12Top, ref SMaxTop, ref SMinTop, ref SAngleTop, ref SVMTop, ref S11Bot, ref S22Bot, ref S12Bot, ref SMaxBot, ref SMinBot, ref SAngleBot, ref SVMBot, ref S13Avg, ref S23Avg, ref SMaxAvg, ref SAngleAvg);
		    return (NumberResults, Obj, Elm, PointElm, LoadCase, StepType, StepNum, S11Top, S22Top, S12Top, SMaxTop, SMinTop, SAngleTop, SVMTop, S11Bot, S22Bot, S12Bot, SMaxBot, SMinBot, SAngleBot, SVMBot, S13Avg, S23Avg, SMaxAvg, SAngleAvg);
		}
		public static (int NumberResults, string[] Obj, string[] Elm, string[] Layer, int[] IntPtNum, double[] IntPtLoc, string[] PointElm, string[] LoadCase, string[] StepType, double[] StepNum, double[] S11, double[] S22, double[] S12, double[] SMax, double[] SMin, double[] SAngle, double[] SVM, double[] S13Avg, double[] S23Avg, double[] SMaxAvg, double[] SAngleAvg)
		    AreaStressShellLayered(this cAnalysisResults obj, string Name, eItemTypeElm ItemTypeElm) {
			int NumberResults;
			NumberResults = default(int);
			string[] Obj, Elm, Layer, PointElm, LoadCase, StepType;
			Obj = Elm = Layer = PointElm = LoadCase = StepType = default(string[]);
			int[] IntPtNum;
			IntPtNum = default(int[]);
			double[] IntPtLoc, StepNum, S11, S22, S12, SMax, SMin, SAngle, SVM, S13Avg, S23Avg, SMaxAvg, SAngleAvg;
			IntPtLoc = StepNum = S11 = S22 = S12 = SMax = SMin = SAngle = SVM = S13Avg = S23Avg = SMaxAvg = SAngleAvg = default(double[]);
		    var res = obj.AreaStressShellLayered(Name, ItemTypeElm, ref NumberResults, ref Obj, ref Elm, ref Layer, ref IntPtNum, ref IntPtLoc, ref PointElm, ref LoadCase, ref StepType, ref StepNum, ref S11, ref S22, ref S12, ref SMax, ref SMin, ref SAngle, ref SVM, ref S13Avg, ref S23Avg, ref SMaxAvg, ref SAngleAvg);
		    return (NumberResults, Obj, Elm, Layer, IntPtNum, IntPtLoc, PointElm, LoadCase, StepType, StepNum, S11, S22, S12, SMax, SMin, SAngle, SVM, S13Avg, S23Avg, SMaxAvg, SAngleAvg);
		}
		public static (int NumberResults, string[] PointElm, double[] U1, double[] U2, double[] U3, double[] R1, double[] R2, double[] R3)
		    AssembledJointMass(this cAnalysisResults obj, string Name, eItemTypeElm ItemTypeElm) {
			int NumberResults;
			NumberResults = default(int);
			string[] PointElm;
			PointElm = default(string[]);
			double[] U1, U2, U3, R1, R2, R3;
			U1 = U2 = U3 = R1 = R2 = R3 = default(double[]);
		    var res = obj.AssembledJointMass(Name, ItemTypeElm, ref NumberResults, ref PointElm, ref U1, ref U2, ref U3, ref R1, ref R2, ref R3);
		    return (NumberResults, PointElm, U1, U2, U3, R1, R2, R3);
		}
		public static (int NumberResults, string[] LoadCase, string[] StepType, double[] StepNum, double[] FX, double[] FY, double[] FZ, double[] MX, double[] ParamMy, double[] MZ, double GX, double GY, double GZ)
		    BaseReact(this cAnalysisResults obj) {
			int NumberResults;
			NumberResults = default(int);
			string[] LoadCase, StepType;
			LoadCase = StepType = default(string[]);
			double[] StepNum, FX, FY, FZ, MX, ParamMy, MZ;
			StepNum = FX = FY = FZ = MX = ParamMy = MZ = default(double[]);
			double GX, GY, GZ;
			GX = GY = GZ = default(double);
		    var res = obj.BaseReact(ref NumberResults, ref LoadCase, ref StepType, ref StepNum, ref FX, ref FY, ref FZ, ref MX, ref ParamMy, ref MZ, ref GX, ref GY, ref GZ);
		    return (NumberResults, LoadCase, StepType, StepNum, FX, FY, FZ, MX, ParamMy, MZ, GX, GY, GZ);
		}
		public static (int NumberResults, string[] LoadCase, string[] StepType, double[] StepNum, double[] FX, double[] FY, double[] FZ, double[] MX, double[] ParamMy, double[] MZ, double GX, double GY, double GZ, double[] XCentroidForFX, double[] YCentroidForFX, double[] ZCentroidForFX, double[] XCentroidForFY, double[] YCentroidForFY, double[] ZCentroidForFY, double[] XCentroidForFZ, double[] YCentroidForFZ, double[] ZCentroidForFZ)
		    BaseReactWithCentroid(this cAnalysisResults obj) {
			int NumberResults;
			NumberResults = default(int);
			string[] LoadCase, StepType;
			LoadCase = StepType = default(string[]);
			double[] StepNum, FX, FY, FZ, MX, ParamMy, MZ, XCentroidForFX, YCentroidForFX, ZCentroidForFX, XCentroidForFY, YCentroidForFY, ZCentroidForFY, XCentroidForFZ, YCentroidForFZ, ZCentroidForFZ;
			StepNum = FX = FY = FZ = MX = ParamMy = MZ = XCentroidForFX = YCentroidForFX = ZCentroidForFX = XCentroidForFY = YCentroidForFY = ZCentroidForFY = XCentroidForFZ = YCentroidForFZ = ZCentroidForFZ = default(double[]);
			double GX, GY, GZ;
			GX = GY = GZ = default(double);
		    var res = obj.BaseReactWithCentroid(ref NumberResults, ref LoadCase, ref StepType, ref StepNum, ref FX, ref FY, ref FZ, ref MX, ref ParamMy, ref MZ, ref GX, ref GY, ref GZ, ref XCentroidForFX, ref YCentroidForFX, ref ZCentroidForFX, ref XCentroidForFY, ref YCentroidForFY, ref ZCentroidForFY, ref XCentroidForFZ, ref YCentroidForFZ, ref ZCentroidForFZ);
		    return (NumberResults, LoadCase, StepType, StepNum, FX, FY, FZ, MX, ParamMy, MZ, GX, GY, GZ, XCentroidForFX, YCentroidForFX, ZCentroidForFX, XCentroidForFY, YCentroidForFY, ZCentroidForFY, XCentroidForFZ, YCentroidForFZ, ZCentroidForFZ);
		}
		public static (int NumberResults, string[] LoadCase, string[] StepType, double[] StepNum, double[] Factor)
		    BucklingFactor(this cAnalysisResults obj) {
			int NumberResults;
			NumberResults = default(int);
			string[] LoadCase, StepType;
			LoadCase = StepType = default(string[]);
			double[] StepNum, Factor;
			StepNum = Factor = default(double[]);
		    var res = obj.BucklingFactor(ref NumberResults, ref LoadCase, ref StepType, ref StepNum, ref Factor);
		    return (NumberResults, LoadCase, StepType, StepNum, Factor);
		}
		public static (int NumberResults, string[] Obj, double[] ObjSta, string[] Elm, double[] ElmSta, string[] LoadCase, string[] StepType, double[] StepNum, double[] P, double[] V2, double[] V3, double[] T, double[] M2, double[] M3)
		    FrameForce(this cAnalysisResults obj, string Name, eItemTypeElm ItemTypeElm) {
			int NumberResults;
			NumberResults = default(int);
			string[] Obj, Elm, LoadCase, StepType;
			Obj = Elm = LoadCase = StepType = default(string[]);
			double[] ObjSta, ElmSta, StepNum, P, V2, V3, T, M2, M3;
			ObjSta = ElmSta = StepNum = P = V2 = V3 = T = M2 = M3 = default(double[]);
		    var res = obj.FrameForce(Name, ItemTypeElm, ref NumberResults, ref Obj, ref ObjSta, ref Elm, ref ElmSta, ref LoadCase, ref StepType, ref StepNum, ref P, ref V2, ref V3, ref T, ref M2, ref M3);
		    return (NumberResults, Obj, ObjSta, Elm, ElmSta, LoadCase, StepType, StepNum, P, V2, V3, T, M2, M3);
		}
		public static (int NumberResults, string[] Obj, string[] Elm, string[] PointElm, string[] LoadCase, string[] StepType, double[] StepNum, double[] F1, double[] F2, double[] F3, double[] M1, double[] M2, double[] M3)
		    FrameJointForce(this cAnalysisResults obj, string Name, eItemTypeElm ItemTypeElm) {
			int NumberResults;
			NumberResults = default(int);
			string[] Obj, Elm, PointElm, LoadCase, StepType;
			Obj = Elm = PointElm = LoadCase = StepType = default(string[]);
			double[] StepNum, F1, F2, F3, M1, M2, M3;
			StepNum = F1 = F2 = F3 = M1 = M2 = M3 = default(double[]);
		    var res = obj.FrameJointForce(Name, ItemTypeElm, ref NumberResults, ref Obj, ref Elm, ref PointElm, ref LoadCase, ref StepType, ref StepNum, ref F1, ref F2, ref F3, ref M1, ref M2, ref M3);
		    return (NumberResults, Obj, Elm, PointElm, LoadCase, StepType, StepNum, F1, F2, F3, M1, M2, M3);
		}
		public static (int NumberResults, string[] GD, string[] LoadCase, string[] StepType, double[] StepNum, string[] DType, double[] Value)
		    GeneralizedDispl(this cAnalysisResults obj, string Name) {
			int NumberResults;
			NumberResults = default(int);
			string[] GD, LoadCase, StepType, DType;
			GD = LoadCase = StepType = DType = default(string[]);
			double[] StepNum, Value;
			StepNum = Value = default(double[]);
		    var res = obj.GeneralizedDispl(Name, ref NumberResults, ref GD, ref LoadCase, ref StepType, ref StepNum, ref DType, ref Value);
		    return (NumberResults, GD, LoadCase, StepType, StepNum, DType, Value);
		}
		public static (int NumberResults, string[] Obj, string[] Elm, string[] LoadCase, string[] StepType, double[] StepNum, double[] U1, double[] U2, double[] U3, double[] R1, double[] R2, double[] R3)
		    JointAcc(this cAnalysisResults obj, string Name, eItemTypeElm ItemTypeElm) {
			int NumberResults;
			NumberResults = default(int);
			string[] Obj, Elm, LoadCase, StepType;
			Obj = Elm = LoadCase = StepType = default(string[]);
			double[] StepNum, U1, U2, U3, R1, R2, R3;
			StepNum = U1 = U2 = U3 = R1 = R2 = R3 = default(double[]);
		    var res = obj.JointAcc(Name, ItemTypeElm, ref NumberResults, ref Obj, ref Elm, ref LoadCase, ref StepType, ref StepNum, ref U1, ref U2, ref U3, ref R1, ref R2, ref R3);
		    return (NumberResults, Obj, Elm, LoadCase, StepType, StepNum, U1, U2, U3, R1, R2, R3);
		}
		public static (int NumberResults, string[] Obj, string[] Elm, string[] LoadCase, string[] StepType, double[] StepNum, double[] U1, double[] U2, double[] U3, double[] R1, double[] R2, double[] R3)
		    JointAccAbs(this cAnalysisResults obj, string Name, eItemTypeElm ItemTypeElm) {
			int NumberResults;
			NumberResults = default(int);
			string[] Obj, Elm, LoadCase, StepType;
			Obj = Elm = LoadCase = StepType = default(string[]);
			double[] StepNum, U1, U2, U3, R1, R2, R3;
			StepNum = U1 = U2 = U3 = R1 = R2 = R3 = default(double[]);
		    var res = obj.JointAccAbs(Name, ItemTypeElm, ref NumberResults, ref Obj, ref Elm, ref LoadCase, ref StepType, ref StepNum, ref U1, ref U2, ref U3, ref R1, ref R2, ref R3);
		    return (NumberResults, Obj, Elm, LoadCase, StepType, StepNum, U1, U2, U3, R1, R2, R3);
		}
		public static (int NumberResults, string[] Obj, string[] Elm, string[] LoadCase, string[] StepType, double[] StepNum, double[] U1, double[] U2, double[] U3, double[] R1, double[] R2, double[] R3)
		    JointDispl(this cAnalysisResults obj, string Name, eItemTypeElm ItemTypeElm) {
			int NumberResults;
			NumberResults = default(int);
			string[] Obj, Elm, LoadCase, StepType;
			Obj = Elm = LoadCase = StepType = default(string[]);
			double[] StepNum, U1, U2, U3, R1, R2, R3;
			StepNum = U1 = U2 = U3 = R1 = R2 = R3 = default(double[]);
		    var res = obj.JointDispl(Name, ItemTypeElm, ref NumberResults, ref Obj, ref Elm, ref LoadCase, ref StepType, ref StepNum, ref U1, ref U2, ref U3, ref R1, ref R2, ref R3);
		    return (NumberResults, Obj, Elm, LoadCase, StepType, StepNum, U1, U2, U3, R1, R2, R3);
		}
		public static (int NumberResults, string[] Obj, string[] Elm, string[] LoadCase, string[] StepType, double[] StepNum, double[] U1, double[] U2, double[] U3, double[] R1, double[] R2, double[] R3)
		    JointDisplAbs(this cAnalysisResults obj, string Name, eItemTypeElm ItemTypeElm) {
			int NumberResults;
			NumberResults = default(int);
			string[] Obj, Elm, LoadCase, StepType;
			Obj = Elm = LoadCase = StepType = default(string[]);
			double[] StepNum, U1, U2, U3, R1, R2, R3;
			StepNum = U1 = U2 = U3 = R1 = R2 = R3 = default(double[]);
		    var res = obj.JointDisplAbs(Name, ItemTypeElm, ref NumberResults, ref Obj, ref Elm, ref LoadCase, ref StepType, ref StepNum, ref U1, ref U2, ref U3, ref R1, ref R2, ref R3);
		    return (NumberResults, Obj, Elm, LoadCase, StepType, StepNum, U1, U2, U3, R1, R2, R3);
		}
		public static (int NumberResults, string[] Obj, string[] Elm, string[] LoadCase, string[] StepType, double[] StepNum, double[] F1, double[] F2, double[] F3, double[] M1, double[] M2, double[] M3)
		    JointReact(this cAnalysisResults obj, string Name, eItemTypeElm ItemTypeElm) {
			int NumberResults;
			NumberResults = default(int);
			string[] Obj, Elm, LoadCase, StepType;
			Obj = Elm = LoadCase = StepType = default(string[]);
			double[] StepNum, F1, F2, F3, M1, M2, M3;
			StepNum = F1 = F2 = F3 = M1 = M2 = M3 = default(double[]);
		    var res = obj.JointReact(Name, ItemTypeElm, ref NumberResults, ref Obj, ref Elm, ref LoadCase, ref StepType, ref StepNum, ref F1, ref F2, ref F3, ref M1, ref M2, ref M3);
		    return (NumberResults, Obj, Elm, LoadCase, StepType, StepNum, F1, F2, F3, M1, M2, M3);
		}
		public static (int NumberResults, string[] Obj, string[] Elm, string[] LoadCase, string[] StepType, double[] StepNum, double[] U1, double[] U2, double[] U3, double[] R1, double[] R2, double[] R3)
		    JointVel(this cAnalysisResults obj, string Name, eItemTypeElm ItemTypeElm) {
			int NumberResults;
			NumberResults = default(int);
			string[] Obj, Elm, LoadCase, StepType;
			Obj = Elm = LoadCase = StepType = default(string[]);
			double[] StepNum, U1, U2, U3, R1, R2, R3;
			StepNum = U1 = U2 = U3 = R1 = R2 = R3 = default(double[]);
		    var res = obj.JointVel(Name, ItemTypeElm, ref NumberResults, ref Obj, ref Elm, ref LoadCase, ref StepType, ref StepNum, ref U1, ref U2, ref U3, ref R1, ref R2, ref R3);
		    return (NumberResults, Obj, Elm, LoadCase, StepType, StepNum, U1, U2, U3, R1, R2, R3);
		}
		public static (int NumberResults, string[] Obj, string[] Elm, string[] LoadCase, string[] StepType, double[] StepNum, double[] U1, double[] U2, double[] U3, double[] R1, double[] R2, double[] R3)
		    JointVelAbs(this cAnalysisResults obj, string Name, eItemTypeElm ItemTypeElm) {
			int NumberResults;
			NumberResults = default(int);
			string[] Obj, Elm, LoadCase, StepType;
			Obj = Elm = LoadCase = StepType = default(string[]);
			double[] StepNum, U1, U2, U3, R1, R2, R3;
			StepNum = U1 = U2 = U3 = R1 = R2 = R3 = default(double[]);
		    var res = obj.JointVelAbs(Name, ItemTypeElm, ref NumberResults, ref Obj, ref Elm, ref LoadCase, ref StepType, ref StepNum, ref U1, ref U2, ref U3, ref R1, ref R2, ref R3);
		    return (NumberResults, Obj, Elm, LoadCase, StepType, StepNum, U1, U2, U3, R1, R2, R3);
		}
		public static (int NumberResults, string[] Obj, string[] Elm, string[] LoadCase, string[] StepType, double[] StepNum, double[] U1, double[] U2, double[] U3, double[] R1, double[] R2, double[] R3)
		    LinkDeformation(this cAnalysisResults obj, string Name, eItemTypeElm ItemTypeElm) {
			int NumberResults;
			NumberResults = default(int);
			string[] Obj, Elm, LoadCase, StepType;
			Obj = Elm = LoadCase = StepType = default(string[]);
			double[] StepNum, U1, U2, U3, R1, R2, R3;
			StepNum = U1 = U2 = U3 = R1 = R2 = R3 = default(double[]);
		    var res = obj.LinkDeformation(Name, ItemTypeElm, ref NumberResults, ref Obj, ref Elm, ref LoadCase, ref StepType, ref StepNum, ref U1, ref U2, ref U3, ref R1, ref R2, ref R3);
		    return (NumberResults, Obj, Elm, LoadCase, StepType, StepNum, U1, U2, U3, R1, R2, R3);
		}
		public static (int NumberResults, string[] Obj, string[] Elm, string[] PointElm, string[] LoadCase, string[] StepType, double[] StepNum, double[] P, double[] V2, double[] V3, double[] T, double[] M2, double[] M3)
		    LinkForce(this cAnalysisResults obj, string Name, eItemTypeElm ItemTypeElm) {
			int NumberResults;
			NumberResults = default(int);
			string[] Obj, Elm, PointElm, LoadCase, StepType;
			Obj = Elm = PointElm = LoadCase = StepType = default(string[]);
			double[] StepNum, P, V2, V3, T, M2, M3;
			StepNum = P = V2 = V3 = T = M2 = M3 = default(double[]);
		    var res = obj.LinkForce(Name, ItemTypeElm, ref NumberResults, ref Obj, ref Elm, ref PointElm, ref LoadCase, ref StepType, ref StepNum, ref P, ref V2, ref V3, ref T, ref M2, ref M3);
		    return (NumberResults, Obj, Elm, PointElm, LoadCase, StepType, StepNum, P, V2, V3, T, M2, M3);
		}
		public static (int NumberResults, string[] Obj, string[] Elm, string[] PointElm, string[] LoadCase, string[] StepType, double[] StepNum, double[] F1, double[] F2, double[] F3, double[] M1, double[] M2, double[] M3)
		    LinkJointForce(this cAnalysisResults obj, string Name, eItemTypeElm ItemTypeElm) {
			int NumberResults;
			NumberResults = default(int);
			string[] Obj, Elm, PointElm, LoadCase, StepType;
			Obj = Elm = PointElm = LoadCase = StepType = default(string[]);
			double[] StepNum, F1, F2, F3, M1, M2, M3;
			StepNum = F1 = F2 = F3 = M1 = M2 = M3 = default(double[]);
		    var res = obj.LinkJointForce(Name, ItemTypeElm, ref NumberResults, ref Obj, ref Elm, ref PointElm, ref LoadCase, ref StepType, ref StepNum, ref F1, ref F2, ref F3, ref M1, ref M2, ref M3);
		    return (NumberResults, Obj, Elm, PointElm, LoadCase, StepType, StepNum, F1, F2, F3, M1, M2, M3);
		}
		public static (int NumberResults, string[] LoadCase, string[] ItemType, string[] Item, double[] Stat, double[] Dyn)
		    ModalLoadParticipationRatios(this cAnalysisResults obj) {
			int NumberResults;
			NumberResults = default(int);
			string[] LoadCase, ItemType, Item;
			LoadCase = ItemType = Item = default(string[]);
			double[] Stat, Dyn;
			Stat = Dyn = default(double[]);
		    var res = obj.ModalLoadParticipationRatios(ref NumberResults, ref LoadCase, ref ItemType, ref Item, ref Stat, ref Dyn);
		    return (NumberResults, LoadCase, ItemType, Item, Stat, Dyn);
		}
		public static (int NumberResults, string[] LoadCase, string[] StepType, double[] StepNum, double[] Period, double[] UX, double[] UY, double[] UZ, double[] SumUX, double[] SumUY, double[] SumUZ, double[] RX, double[] RY, double[] RZ, double[] SumRX, double[] SumRY, double[] SumRZ)
		    ModalParticipatingMassRatios(this cAnalysisResults obj) {
			int NumberResults;
			NumberResults = default(int);
			string[] LoadCase, StepType;
			LoadCase = StepType = default(string[]);
			double[] StepNum, Period, UX, UY, UZ, SumUX, SumUY, SumUZ, RX, RY, RZ, SumRX, SumRY, SumRZ;
			StepNum = Period = UX = UY = UZ = SumUX = SumUY = SumUZ = RX = RY = RZ = SumRX = SumRY = SumRZ = default(double[]);
		    var res = obj.ModalParticipatingMassRatios(ref NumberResults, ref LoadCase, ref StepType, ref StepNum, ref Period, ref UX, ref UY, ref UZ, ref SumUX, ref SumUY, ref SumUZ, ref RX, ref RY, ref RZ, ref SumRX, ref SumRY, ref SumRZ);
		    return (NumberResults, LoadCase, StepType, StepNum, Period, UX, UY, UZ, SumUX, SumUY, SumUZ, RX, RY, RZ, SumRX, SumRY, SumRZ);
		}
		public static (int NumberResults, string[] LoadCase, string[] StepType, double[] StepNum, double[] Period, double[] UX, double[] UY, double[] UZ, double[] RX, double[] RY, double[] RZ, double[] ModalMass, double[] ModalStiff)
		    ModalParticipationFactors(this cAnalysisResults obj) {
			int NumberResults;
			NumberResults = default(int);
			string[] LoadCase, StepType;
			LoadCase = StepType = default(string[]);
			double[] StepNum, Period, UX, UY, UZ, RX, RY, RZ, ModalMass, ModalStiff;
			StepNum = Period = UX = UY = UZ = RX = RY = RZ = ModalMass = ModalStiff = default(double[]);
		    var res = obj.ModalParticipationFactors(ref NumberResults, ref LoadCase, ref StepType, ref StepNum, ref Period, ref UX, ref UY, ref UZ, ref RX, ref RY, ref RZ, ref ModalMass, ref ModalStiff);
		    return (NumberResults, LoadCase, StepType, StepNum, Period, UX, UY, UZ, RX, RY, RZ, ModalMass, ModalStiff);
		}
		public static (int NumberResults, string[] LoadCase, string[] StepType, double[] StepNum, double[] Period, double[] Frequency, double[] CircFreq, double[] EigenValue)
		    ModalPeriod(this cAnalysisResults obj) {
			int NumberResults;
			NumberResults = default(int);
			string[] LoadCase, StepType;
			LoadCase = StepType = default(string[]);
			double[] StepNum, Period, Frequency, CircFreq, EigenValue;
			StepNum = Period = Frequency = CircFreq = EigenValue = default(double[]);
		    var res = obj.ModalPeriod(ref NumberResults, ref LoadCase, ref StepType, ref StepNum, ref Period, ref Frequency, ref CircFreq, ref EigenValue);
		    return (NumberResults, LoadCase, StepType, StepNum, Period, Frequency, CircFreq, EigenValue);
		}
		public static (int NumberResults, string[] Obj, string[] Elm, string[] LoadCase, string[] StepType, double[] StepNum, double[] U1, double[] U2, double[] U3, double[] R1, double[] R2, double[] R3)
		    ModeShape(this cAnalysisResults obj, string Name, eItemTypeElm ItemTypeElm) {
			int NumberResults;
			NumberResults = default(int);
			string[] Obj, Elm, LoadCase, StepType;
			Obj = Elm = LoadCase = StepType = default(string[]);
			double[] StepNum, U1, U2, U3, R1, R2, R3;
			StepNum = U1 = U2 = U3 = R1 = R2 = R3 = default(double[]);
		    var res = obj.ModeShape(Name, ItemTypeElm, ref NumberResults, ref Obj, ref Elm, ref LoadCase, ref StepType, ref StepNum, ref U1, ref U2, ref U3, ref R1, ref R2, ref R3);
		    return (NumberResults, Obj, Elm, LoadCase, StepType, StepNum, U1, U2, U3, R1, R2, R3);
		}
		public static (int NumberResults, string[] Elm, string[] LoadCase, string[] StepType, double[] StepNum, double[] U1, double[] U2, double[] U3, double[] R1, double[] R2, double[] R3)
		    PanelZoneDeformation(this cAnalysisResults obj, string Name, eItemTypeElm ItemTypeElm) {
			int NumberResults;
			NumberResults = default(int);
			string[] Elm, LoadCase, StepType;
			Elm = LoadCase = StepType = default(string[]);
			double[] StepNum, U1, U2, U3, R1, R2, R3;
			StepNum = U1 = U2 = U3 = R1 = R2 = R3 = default(double[]);
		    var res = obj.PanelZoneDeformation(Name, ItemTypeElm, ref NumberResults, ref Elm, ref LoadCase, ref StepType, ref StepNum, ref U1, ref U2, ref U3, ref R1, ref R2, ref R3);
		    return (NumberResults, Elm, LoadCase, StepType, StepNum, U1, U2, U3, R1, R2, R3);
		}
		public static (int NumberResults, string[] Elm, string[] PointElm, string[] LoadCase, string[] StepType, double[] StepNum, double[] P, double[] V2, double[] V3, double[] T, double[] M2, double[] M3)
		    PanelZoneForce(this cAnalysisResults obj, string Name, eItemTypeElm ItemTypeElm) {
			int NumberResults;
			NumberResults = default(int);
			string[] Elm, PointElm, LoadCase, StepType;
			Elm = PointElm = LoadCase = StepType = default(string[]);
			double[] StepNum, P, V2, V3, T, M2, M3;
			StepNum = P = V2 = V3 = T = M2 = M3 = default(double[]);
		    var res = obj.PanelZoneForce(Name, ItemTypeElm, ref NumberResults, ref Elm, ref PointElm, ref LoadCase, ref StepType, ref StepNum, ref P, ref V2, ref V3, ref T, ref M2, ref M3);
		    return (NumberResults, Elm, PointElm, LoadCase, StepType, StepNum, P, V2, V3, T, M2, M3);
		}
		public static (int NumberResults, string[] SCut, string[] LoadCase, string[] StepType, double[] StepNum, double[] F1, double[] F2, double[] F3, double[] M1, double[] M2, double[] M3)
		    SectionCutAnalysis(this cAnalysisResults obj) {
			int NumberResults;
			NumberResults = default(int);
			string[] SCut, LoadCase, StepType;
			SCut = LoadCase = StepType = default(string[]);
			double[] StepNum, F1, F2, F3, M1, M2, M3;
			StepNum = F1 = F2 = F3 = M1 = M2 = M3 = default(double[]);
		    var res = obj.SectionCutAnalysis(ref NumberResults, ref SCut, ref LoadCase, ref StepType, ref StepNum, ref F1, ref F2, ref F3, ref M1, ref M2, ref M3);
		    return (NumberResults, SCut, LoadCase, StepType, StepNum, F1, F2, F3, M1, M2, M3);
		}
		public static (int NumberResults, string[] SCut, string[] LoadCase, string[] StepType, double[] StepNum, double[] P, double[] V2, double[] V3, double[] T, double[] M2, double[] M3)
		    SectionCutDesign(this cAnalysisResults obj) {
			int NumberResults;
			NumberResults = default(int);
			string[] SCut, LoadCase, StepType;
			SCut = LoadCase = StepType = default(string[]);
			double[] StepNum, P, V2, V3, T, M2, M3;
			StepNum = P = V2 = V3 = T = M2 = M3 = default(double[]);
		    var res = obj.SectionCutDesign(ref NumberResults, ref SCut, ref LoadCase, ref StepType, ref StepNum, ref P, ref V2, ref V3, ref T, ref M2, ref M3);
		    return (NumberResults, SCut, LoadCase, StepType, StepNum, P, V2, V3, T, M2, M3);
		}
		public static (int NumberResults, string[] StoryName, string[] PierName, string[] LoadCase, string[] Location, double[] P, double[] V2, double[] V3, double[] T, double[] M2, double[] M3)
		    PierForce(this cAnalysisResults obj) {
			int NumberResults;
			NumberResults = default(int);
			string[] StoryName, PierName, LoadCase, Location;
			StoryName = PierName = LoadCase = Location = default(string[]);
			double[] P, V2, V3, T, M2, M3;
			P = V2 = V3 = T = M2 = M3 = default(double[]);
		    var res = obj.PierForce(ref NumberResults, ref StoryName, ref PierName, ref LoadCase, ref Location, ref P, ref V2, ref V3, ref T, ref M2, ref M3);
		    return (NumberResults, StoryName, PierName, LoadCase, Location, P, V2, V3, T, M2, M3);
		}
		public static (int NumberResults, string[] StoryName, string[] SpandrelName, string[] LoadCase, string[] Location, double[] P, double[] V2, double[] V3, double[] T, double[] M2, double[] M3)
		    SpandrelForce(this cAnalysisResults obj) {
			int NumberResults;
			NumberResults = default(int);
			string[] StoryName, SpandrelName, LoadCase, Location;
			StoryName = SpandrelName = LoadCase = Location = default(string[]);
			double[] P, V2, V3, T, M2, M3;
			P = V2 = V3 = T = M2 = M3 = default(double[]);
		    var res = obj.SpandrelForce(ref NumberResults, ref StoryName, ref SpandrelName, ref LoadCase, ref Location, ref P, ref V2, ref V3, ref T, ref M2, ref M3);
		    return (NumberResults, StoryName, SpandrelName, LoadCase, Location, P, V2, V3, T, M2, M3);
		}
		public static (int NumberResults, string[] Story, string[] Label, string[] Name, string[] LoadCase, string[] StepType, double[] StepNum, double[] DisplacementX, double[] DisplacementY, double[] DriftX, double[] DriftY)
		    JointDrifts(this cAnalysisResults obj) {
			int NumberResults;
			NumberResults = default(int);
			string[] Story, Label, Name, LoadCase, StepType;
			Story = Label = Name = LoadCase = StepType = default(string[]);
			double[] StepNum, DisplacementX, DisplacementY, DriftX, DriftY;
			StepNum = DisplacementX = DisplacementY = DriftX = DriftY = default(double[]);
		    var res = obj.JointDrifts(ref NumberResults, ref Story, ref Label, ref Name, ref LoadCase, ref StepType, ref StepNum, ref DisplacementX, ref DisplacementY, ref DriftX, ref DriftY);
		    return (NumberResults, Story, Label, Name, LoadCase, StepType, StepNum, DisplacementX, DisplacementY, DriftX, DriftY);
		}
		public static (int NumberResults, string[] Story, string[] LoadCase, string[] StepType, double[] StepNum, string[] Direction, double[] Drift, string[] Label, double[] X, double[] Y, double[] Z)
		    StoryDrifts(this cAnalysisResults obj) {
			int NumberResults;
			NumberResults = default(int);
			string[] Story, LoadCase, StepType, Direction, Label;
			Story = LoadCase = StepType = Direction = Label = default(string[]);
			double[] StepNum, Drift, X, Y, Z;
			StepNum = Drift = X = Y = Z = default(double[]);
		    var res = obj.StoryDrifts(ref NumberResults, ref Story, ref LoadCase, ref StepType, ref StepNum, ref Direction, ref Drift, ref Label, ref X, ref Y, ref Z);
		    return (NumberResults, Story, LoadCase, StepType, StepNum, Direction, Drift, Label, X, Y, Z);
		}

    }
}