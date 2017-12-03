
using System;
using ETABS2016;

namespace ETABS2016
{
    public static class cCaseStaticNonlinearStagedExtension
    {
		public static int GetGeometricNonlinearity(this cCaseStaticNonlinearStaged obj, string Name) {
			int NLGeomType;
			NLGeomType = default(int);
		    var res = obj.GetGeometricNonlinearity(Name, ref NLGeomType);
		    return NLGeomType;
		}
		public static int GetHingeUnloading(this cCaseStaticNonlinearStaged obj, string Name) {
			int UnloadType;
			UnloadType = default(int);
		    var res = obj.GetHingeUnloading(Name, ref UnloadType);
		    return UnloadType;
		}
		public static string GetInitialCase(this cCaseStaticNonlinearStaged obj, string Name) {
			string InitialCase;
			InitialCase = default(string);
		    var res = obj.GetInitialCase(Name, ref InitialCase);
		    return InitialCase;
		}
		public static bool GetMaterialNonlinearity(this cCaseStaticNonlinearStaged obj, string Name) {
			bool TimeDepMatProp;
			TimeDepMatProp = default(bool);
		    var res = obj.GetMaterialNonlinearity(Name, ref TimeDepMatProp);
		    return TimeDepMatProp;
		}
		public static (int StagedSaveOption, int StagedMinSteps, int StagedMinStepsTD) GetResultsSaved(this cCaseStaticNonlinearStaged obj, string Name) {
			int StagedSaveOption, StagedMinSteps, StagedMinStepsTD;
			StagedSaveOption = StagedMinSteps = StagedMinStepsTD = default(int);
		    var res = obj.GetResultsSaved(Name, ref StagedSaveOption, ref StagedMinSteps, ref StagedMinStepsTD);
		    return (StagedSaveOption, StagedMinSteps, StagedMinStepsTD);
		}
		public static (int MaxTotalSteps, int MaxFailedSubSteps, int MaxIterCS, int MaxIterNR, double TolConvD, bool UseEventStepping, double TolEventD, int MaxLineSearchPerIter, double TolLineSearch, double LineSearchStepFact) GetSolControlParameters(this cCaseStaticNonlinearStaged obj, string Name) {
			int MaxTotalSteps, MaxFailedSubSteps, MaxIterCS, MaxIterNR, MaxLineSearchPerIter;
			MaxTotalSteps = MaxFailedSubSteps = MaxIterCS = MaxIterNR = MaxLineSearchPerIter = default(int);
			double TolConvD, TolEventD, TolLineSearch, LineSearchStepFact;
			TolConvD = TolEventD = TolLineSearch = LineSearchStepFact = default(double);
			bool UseEventStepping;
			UseEventStepping = default(bool);
		    var res = obj.GetSolControlParameters(Name, ref MaxTotalSteps, ref MaxFailedSubSteps, ref MaxIterCS, ref MaxIterNR, ref TolConvD, ref UseEventStepping, ref TolEventD, ref MaxLineSearchPerIter, ref TolLineSearch, ref LineSearchStepFact);
		    return (MaxTotalSteps, MaxFailedSubSteps, MaxIterCS, MaxIterNR, TolConvD, UseEventStepping, TolEventD, MaxLineSearchPerIter, TolLineSearch, LineSearchStepFact);
		}
		public static (int Stage, int NumberOperations, int[] Operation, string[] GroupName, int[] Age, string[] LoadType, string[] LoadName, double[] SF) GetStageData(this cCaseStaticNonlinearStaged obj, string Name) {
			int Stage, NumberOperations;
			Stage = NumberOperations = default(int);
			int[] Operation, Age;
			Operation = Age = default(int[]);
			string[] GroupName, LoadType, LoadName;
			GroupName = LoadType = LoadName = default(string[]);
			double[] SF;
			SF = default(double[]);
		    var res = obj.GetStageData(Name, ref Stage, ref NumberOperations, ref Operation, ref GroupName, ref Age, ref LoadType, ref LoadName, ref SF);
		    return (Stage, NumberOperations, Operation, GroupName, Age, LoadType, LoadName, SF);
		}
		public static (int Stage, int NumberOperations, int[] Operation, string[] ObjectType, string[] ObjectName, int[] Age, string[] MyType, string[] MyName, double[] SF) GetStageData_1(this cCaseStaticNonlinearStaged obj, string Name) {
			int Stage, NumberOperations;
			Stage = NumberOperations = default(int);
			int[] Operation, Age;
			Operation = Age = default(int[]);
			string[] ObjectType, ObjectName, MyType, MyName;
			ObjectType = ObjectName = MyType = MyName = default(string[]);
			double[] SF;
			SF = default(double[]);
		    var res = obj.GetStageData_1(Name, ref Stage, ref NumberOperations, ref Operation, ref ObjectType, ref ObjectName, ref Age, ref MyType, ref MyName, ref SF);
		    return (Stage, NumberOperations, Operation, ObjectType, ObjectName, Age, MyType, MyName, SF);
		}
		public static (int NumberStages, int[] Duration, string[] Comment) GetStageDefinitions(this cCaseStaticNonlinearStaged obj, string Name) {
			int NumberStages;
			NumberStages = default(int);
			int[] Duration;
			Duration = default(int[]);
			string[] Comment;
			Comment = default(string[]);
		    var res = obj.GetStageDefinitions(Name, ref NumberStages, ref Duration, ref Comment);
		    return (NumberStages, Duration, Comment);
		}
		public static (int NumberStages, int[] Duration, bool[] Output, string[] OutputName, string[] Comment) GetStageDefinitions_1(this cCaseStaticNonlinearStaged obj, string Name) {
			int NumberStages;
			NumberStages = default(int);
			int[] Duration;
			Duration = default(int[]);
			bool[] Output;
			Output = default(bool[]);
			string[] OutputName, Comment;
			OutputName = Comment = default(string[]);
		    var res = obj.GetStageDefinitions_1(Name, ref NumberStages, ref Duration, ref Output, ref OutputName, ref Comment);
		    return (NumberStages, Duration, Output, OutputName, Comment);
		}
		public static (double TolConvF, int MaxIter, double AccelFact, bool NoStop) GetTargetForceParameters(this cCaseStaticNonlinearStaged obj, string Name) {
			double TolConvF, AccelFact;
			TolConvF = AccelFact = default(double);
			int MaxIter;
			MaxIter = default(int);
			bool NoStop;
			NoStop = default(bool);
		    var res = obj.GetTargetForceParameters(Name, ref TolConvF, ref MaxIter, ref AccelFact, ref NoStop);
		    return (TolConvF, MaxIter, AccelFact, NoStop);
		}
		public static string GetMassSource(this cCaseStaticNonlinearStaged obj, string Name) {
			string mSource;
			mSource = default(string);
		    var res = obj.GetMassSource(Name, ref mSource);
		    return mSource;
		}
		public static (int Stage, int NumberOperations, int[] Operation, string[] ObjectType, string[] ObjectName, double[] Age, string[] MyType, string[] MyName, double[] SF) GetStageData_2(this cCaseStaticNonlinearStaged obj, string Name) {
			int Stage, NumberOperations;
			Stage = NumberOperations = default(int);
			int[] Operation;
			Operation = default(int[]);
			string[] ObjectType, ObjectName, MyType, MyName;
			ObjectType = ObjectName = MyType = MyName = default(string[]);
			double[] Age, SF;
			Age = SF = default(double[]);
		    var res = obj.GetStageData_2(Name, ref Stage, ref NumberOperations, ref Operation, ref ObjectType, ref ObjectName, ref Age, ref MyType, ref MyName, ref SF);
		    return (Stage, NumberOperations, Operation, ObjectType, ObjectName, Age, MyType, MyName, SF);
		}
		public static (int NumberStages, double[] Duration, bool[] Output, string[] OutputName, string[] Comment) GetStageDefinitions_2(this cCaseStaticNonlinearStaged obj, string Name) {
			int NumberStages;
			NumberStages = default(int);
			double[] Duration;
			Duration = default(double[]);
			bool[] Output;
			Output = default(bool[]);
			string[] OutputName, Comment;
			OutputName = Comment = default(string[]);
		    var res = obj.GetStageDefinitions_2(Name, ref NumberStages, ref Duration, ref Output, ref OutputName, ref Comment);
		    return (NumberStages, Duration, Output, OutputName, Comment);
		}

    }
}