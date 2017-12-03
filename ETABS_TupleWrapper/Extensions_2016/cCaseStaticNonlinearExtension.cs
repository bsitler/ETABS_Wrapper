
using System;
using ETABS2016;

namespace ETABS2016
{
    public static class cCaseStaticNonlinearExtension
    {
		public static int GetGeometricNonlinearity(this cCaseStaticNonlinear obj, string Name) {
			int NLGeomType;
			NLGeomType = default(int);
		    var res = obj.GetGeometricNonlinearity(Name, ref NLGeomType);
		    return NLGeomType;
		}
		public static int GetHingeUnloading(this cCaseStaticNonlinear obj, string Name) {
			int UnloadType;
			UnloadType = default(int);
		    var res = obj.GetHingeUnloading(Name, ref UnloadType);
		    return UnloadType;
		}
		public static string GetInitialCase(this cCaseStaticNonlinear obj, string Name) {
			string InitialCase;
			InitialCase = default(string);
		    var res = obj.GetInitialCase(Name, ref InitialCase);
		    return InitialCase;
		}
		public static (int LoadControl, int DispType, double Displ, int Monitor, int DOF, string PointName, string GDispl) GetLoadApplication(this cCaseStaticNonlinear obj, string Name) {
			int LoadControl, DispType, Monitor, DOF;
			LoadControl = DispType = Monitor = DOF = default(int);
			double Displ;
			Displ = default(double);
			string PointName, GDispl;
			PointName = GDispl = default(string);
		    var res = obj.GetLoadApplication(Name, ref LoadControl, ref DispType, ref Displ, ref Monitor, ref DOF, ref PointName, ref GDispl);
		    return (LoadControl, DispType, Displ, Monitor, DOF, PointName, GDispl);
		}
		public static (int NumberLoads, string[] LoadType, string[] LoadName, double[] SF) GetLoads(this cCaseStaticNonlinear obj, string Name) {
			int NumberLoads;
			NumberLoads = default(int);
			string[] LoadType, LoadName;
			LoadType = LoadName = default(string[]);
			double[] SF;
			SF = default(double[]);
		    var res = obj.GetLoads(Name, ref NumberLoads, ref LoadType, ref LoadName, ref SF);
		    return (NumberLoads, LoadType, LoadName, SF);
		}
		public static string GetModalCase(this cCaseStaticNonlinear obj, string Name) {
			string ModalCase;
			ModalCase = default(string);
		    var res = obj.GetModalCase(Name, ref ModalCase);
		    return ModalCase;
		}
		public static (bool SaveMultipleSteps, int MinSavedStates, int MaxSavedStates, bool PositiveOnly) GetResultsSaved(this cCaseStaticNonlinear obj, string Name) {
			bool SaveMultipleSteps, PositiveOnly;
			SaveMultipleSteps = PositiveOnly = default(bool);
			int MinSavedStates, MaxSavedStates;
			MinSavedStates = MaxSavedStates = default(int);
		    var res = obj.GetResultsSaved(Name, ref SaveMultipleSteps, ref MinSavedStates, ref MaxSavedStates, ref PositiveOnly);
		    return (SaveMultipleSteps, MinSavedStates, MaxSavedStates, PositiveOnly);
		}
		public static (int MaxTotalSteps, int MaxFailedSubSteps, int MaxIterCS, int MaxIterNR, double TolConvD, bool UseEventStepping, double TolEventD, int MaxLineSearchPerIter, double TolLineSearch, double LineSearchStepFact) GetSolControlParameters(this cCaseStaticNonlinear obj, string Name) {
			int MaxTotalSteps, MaxFailedSubSteps, MaxIterCS, MaxIterNR, MaxLineSearchPerIter;
			MaxTotalSteps = MaxFailedSubSteps = MaxIterCS = MaxIterNR = MaxLineSearchPerIter = default(int);
			double TolConvD, TolEventD, TolLineSearch, LineSearchStepFact;
			TolConvD = TolEventD = TolLineSearch = LineSearchStepFact = default(double);
			bool UseEventStepping;
			UseEventStepping = default(bool);
		    var res = obj.GetSolControlParameters(Name, ref MaxTotalSteps, ref MaxFailedSubSteps, ref MaxIterCS, ref MaxIterNR, ref TolConvD, ref UseEventStepping, ref TolEventD, ref MaxLineSearchPerIter, ref TolLineSearch, ref LineSearchStepFact);
		    return (MaxTotalSteps, MaxFailedSubSteps, MaxIterCS, MaxIterNR, TolConvD, UseEventStepping, TolEventD, MaxLineSearchPerIter, TolLineSearch, LineSearchStepFact);
		}
		public static (double TolConvF, int MaxIter, double AccelFact, bool NoStop) GetTargetForceParameters(this cCaseStaticNonlinear obj, string Name) {
			double TolConvF, AccelFact;
			TolConvF = AccelFact = default(double);
			int MaxIter;
			MaxIter = default(int);
			bool NoStop;
			NoStop = default(bool);
		    var res = obj.GetTargetForceParameters(Name, ref TolConvF, ref MaxIter, ref AccelFact, ref NoStop);
		    return (TolConvF, MaxIter, AccelFact, NoStop);
		}
		public static string GetMassSource(this cCaseStaticNonlinear obj, string Name) {
			string mSource;
			mSource = default(string);
		    var res = obj.GetMassSource(Name, ref mSource);
		    return mSource;
		}

    }
}