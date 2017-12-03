
using System;
using ETABS2016;

namespace ETABS2016
{
    public static class cAnalyzeExtension
    {
		public static bool[] GetActiveDOF(this cAnalyze obj) {
			bool[] DOF;
			DOF = default(bool[]);
		    var res = obj.GetActiveDOF(ref DOF);
		    return DOF;
		}
		public static (int NumberItems, string[] CaseName, int[] Status) GetCaseStatus(this cAnalyze obj) {
			int NumberItems;
			NumberItems = default(int);
			string[] CaseName;
			CaseName = default(string[]);
			int[] Status;
			Status = default(int[]);
		    var res = obj.GetCaseStatus(ref NumberItems, ref CaseName, ref Status);
		    return (NumberItems, CaseName, Status);
		}
		public static (int NumberItems, string[] CaseName, bool[] Run) GetRunCaseFlag(this cAnalyze obj) {
			int NumberItems;
			NumberItems = default(int);
			string[] CaseName;
			CaseName = default(string[]);
			bool[] Run;
			Run = default(bool[]);
		    var res = obj.GetRunCaseFlag(ref NumberItems, ref CaseName, ref Run);
		    return (NumberItems, CaseName, Run);
		}
		public static (int SolverType, bool Force32BitSolver, string StiffCase) GetSolverOption(this cAnalyze obj) {
			int SolverType;
			SolverType = default(int);
			bool Force32BitSolver;
			Force32BitSolver = default(bool);
			string StiffCase;
			StiffCase = default(string);
		    var res = obj.GetSolverOption(ref SolverType, ref Force32BitSolver, ref StiffCase);
		    return (SolverType, Force32BitSolver, StiffCase);
		}
		public static (int SolverType, int SolverProcessType, bool Force32BitSolver, string StiffCase) GetSolverOption_1(this cAnalyze obj) {
			int SolverType, SolverProcessType;
			SolverType = SolverProcessType = default(int);
			bool Force32BitSolver;
			Force32BitSolver = default(bool);
			string StiffCase;
			StiffCase = default(string);
		    var res = obj.GetSolverOption_1(ref SolverType, ref SolverProcessType, ref Force32BitSolver, ref StiffCase);
		    return (SolverType, SolverProcessType, Force32BitSolver, StiffCase);
		}

    }
}