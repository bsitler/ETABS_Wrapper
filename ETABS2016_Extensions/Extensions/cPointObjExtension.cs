using System;
using ETABS2016;

namespace ETABS2016
{
    public static class cPointObjExtension
    {
		public static string
		    AddCartesian(this cPointObj obj, double X, double Y, double Z, string UserName = "", string CSys = "Global", bool MergeOff = false, int MergeNumber = 0) {
			string Name;
			Name = default(string);
		    var res = obj.AddCartesian(X, Y, Z, ref Name, UserName, CSys, MergeOff, MergeNumber);
		    return Name;
		}
		public static int
		    CountLoadDispl(this cPointObj obj, string Name = "", string LoadPat = "") {
			int Count;
			Count = default(int);
		    var res = obj.CountLoadDispl(ref Count, Name, LoadPat);
		    return Count;
		}
		public static int
		    CountLoadForce(this cPointObj obj, string Name = "", string LoadPat = "") {
			int Count;
			Count = default(int);
		    var res = obj.CountLoadForce(ref Count, Name, LoadPat);
		    return Count;
		}
		public static int
		    GetCommonTo(this cPointObj obj, string Name) {
			int CommonTo;
			CommonTo = default(int);
		    var res = obj.GetCommonTo(Name, ref CommonTo);
		    return CommonTo;
		}
		public static (int NumberItems, int[] ObjectType, string[] ObjectName, int[] PointNumber)
		    GetConnectivity(this cPointObj obj, string Name) {
			int NumberItems;
			NumberItems = default(int);
			int[] ObjectType, PointNumber;
			ObjectType = PointNumber = default(int[]);
			string[] ObjectName;
			ObjectName = default(string[]);
		    var res = obj.GetConnectivity(Name, ref NumberItems, ref ObjectType, ref ObjectName, ref PointNumber);
		    return (NumberItems, ObjectType, ObjectName, PointNumber);
		}
		public static (double X, double Y, double Z)
		    GetCoordCartesian(this cPointObj obj, string Name, string CSys = "Global") {
			double X, Y, Z;
			X = Y = Z = default(double);
		    var res = obj.GetCoordCartesian(Name, ref X, ref Y, ref Z, CSys);
		    return (X, Y, Z);
		}
		public static (double R, double Theta, double Z)
		    GetCoordCylindrical(this cPointObj obj, string Name, string CSys = "Global") {
			double R, Theta, Z;
			R = Theta = Z = default(double);
		    var res = obj.GetCoordCylindrical(Name, ref R, ref Theta, ref Z, CSys);
		    return (R, Theta, Z);
		}
		public static (double R, double A, double B)
		    GetCoordSpherical(this cPointObj obj, string Name, string CSys = "Global") {
			double R, A, B;
			R = A = B = default(double);
		    var res = obj.GetCoordSpherical(Name, ref R, ref A, ref B, CSys);
		    return (R, A, B);
		}
		public static string
		    GetElm(this cPointObj obj, string Name) {
			string Elm;
			Elm = default(string);
		    var res = obj.GetElm(Name, ref Elm);
		    return Elm;
		}
		public static string
		    GetGUID(this cPointObj obj, string Name) {
			string GUID;
			GUID = default(string);
		    var res = obj.GetGUID(Name, ref GUID);
		    return GUID;
		}
		public static (int NumberItems, string[] PointName, string[] LoadPat, int[] LcStep, string[] CSys, double[] U1, double[] U2, double[] U3, double[] R1, double[] R2, double[] R3)
		    GetLoadDispl(this cPointObj obj, string Name, eItemType ItemType = eItemType.Objects) {
			int NumberItems;
			NumberItems = default(int);
			string[] PointName, LoadPat, CSys;
			PointName = LoadPat = CSys = default(string[]);
			int[] LcStep;
			LcStep = default(int[]);
			double[] U1, U2, U3, R1, R2, R3;
			U1 = U2 = U3 = R1 = R2 = R3 = default(double[]);
		    var res = obj.GetLoadDispl(Name, ref NumberItems, ref PointName, ref LoadPat, ref LcStep, ref CSys, ref U1, ref U2, ref U3, ref R1, ref R2, ref R3, ItemType);
		    return (NumberItems, PointName, LoadPat, LcStep, CSys, U1, U2, U3, R1, R2, R3);
		}
		public static (int NumberItems, string[] PointName, string[] LoadPat, int[] LcStep, string[] CSys, double[] F1, double[] F2, double[] F3, double[] M1, double[] M2, double[] M3)
		    GetLoadForce(this cPointObj obj, string Name, eItemType ItemType = eItemType.Objects) {
			int NumberItems;
			NumberItems = default(int);
			string[] PointName, LoadPat, CSys;
			PointName = LoadPat = CSys = default(string[]);
			int[] LcStep;
			LcStep = default(int[]);
			double[] F1, F2, F3, M1, M2, M3;
			F1 = F2 = F3 = M1 = M2 = M3 = default(double[]);
		    var res = obj.GetLoadForce(Name, ref NumberItems, ref PointName, ref LoadPat, ref LcStep, ref CSys, ref F1, ref F2, ref F3, ref M1, ref M2, ref M3, ItemType);
		    return (NumberItems, PointName, LoadPat, LcStep, CSys, F1, F2, F3, M1, M2, M3);
		}
		public static (double A, double B, double C, bool Advanced)
		    GetLocalAxes(this cPointObj obj, string Name) {
			double A, B, C;
			A = B = C = default(double);
			bool Advanced;
			Advanced = default(bool);
		    var res = obj.GetLocalAxes(Name, ref A, ref B, ref C, ref Advanced);
		    return (A, B, C, Advanced);
		}
		public static double[]
		    GetMass(this cPointObj obj, string Name) {
			double[] M;
			M = default(double[]);
		    var res = obj.GetMass(Name, ref M);
		    return M;
		}
		public static (int NumberNames, string[] MyName)
		    GetNameList(this cPointObj obj) {
			int NumberNames;
			NumberNames = default(int);
			string[] MyName;
			MyName = default(string[]);
		    var res = obj.GetNameList(ref NumberNames, ref MyName);
		    return (NumberNames, MyName);
		}
		public static (int PropType, double Thickness, double K1, double K2, string LinkProp, int Connectivity, int LocalAxisFrom, double LocalAxisAngle)
		    GetPanelZone(this cPointObj obj, string Name) {
			int PropType, Connectivity, LocalAxisFrom;
			PropType = Connectivity = LocalAxisFrom = default(int);
			double Thickness, K1, K2, LocalAxisAngle;
			Thickness = K1 = K2 = LocalAxisAngle = default(double);
			string LinkProp;
			LinkProp = default(string);
		    var res = obj.GetPanelZone(Name, ref PropType, ref Thickness, ref K1, ref K2, ref LinkProp, ref Connectivity, ref LocalAxisFrom, ref LocalAxisAngle);
		    return (PropType, Thickness, K1, K2, LinkProp, Connectivity, LocalAxisFrom, LocalAxisAngle);
		}
		public static bool[]
		    GetRestraint(this cPointObj obj, string Name) {
			bool[] Value;
			Value = default(bool[]);
		    var res = obj.GetRestraint(Name, ref Value);
		    return Value;
		}
		public static bool
		    GetSelected(this cPointObj obj, string Name) {
			bool Selected;
			Selected = default(bool);
		    var res = obj.GetSelected(Name, ref Selected);
		    return Selected;
		}
		public static bool
		    GetSpecialPoint(this cPointObj obj, string Name) {
			bool SpecialPoint;
			SpecialPoint = default(bool);
		    var res = obj.GetSpecialPoint(Name, ref SpecialPoint);
		    return SpecialPoint;
		}
		public static double[]
		    GetSpring(this cPointObj obj, string Name) {
			double[] K;
			K = default(double[]);
		    var res = obj.GetSpring(Name, ref K);
		    return K;
		}
		public static double[]
		    GetSpringCoupled(this cPointObj obj, string Name) {
			double[] K;
			K = default(double[]);
		    var res = obj.GetSpringCoupled(Name, ref K);
		    return K;
		}
		public static double[]
		    GetTransformationMatrix(this cPointObj obj, string Name, bool IsGlobal = true) {
			double[] Value;
			Value = default(double[]);
		    var res = obj.GetTransformationMatrix(Name, ref Value, IsGlobal);
		    return Value;
		}
		public static bool
		    IsSpringCoupled(this cPointObj obj, string Name) {
			bool IsCoupled;
			IsCoupled = default(bool);
		    var res = obj.IsSpringCoupled(Name, ref IsCoupled);
		    return IsCoupled;
		}
		public static (int NumberNames, string[] MyName)
		    GetNameListOnStory(this cPointObj obj, string StoryName) {
			int NumberNames;
			NumberNames = default(int);
			string[] MyName;
			MyName = default(string[]);
		    var res = obj.GetNameListOnStory(StoryName, ref NumberNames, ref MyName);
		    return (NumberNames, MyName);
		}
		public static (eDiaphragmOption DiaphragmOption, string DiaphragmName)
		    GetDiaphragm(this cPointObj obj, string Name) {
			eDiaphragmOption DiaphragmOption;
			DiaphragmOption = default(eDiaphragmOption);
			string DiaphragmName;
			DiaphragmName = default(string);
		    var res = obj.GetDiaphragm(Name, ref DiaphragmOption, ref DiaphragmName);
		    return (DiaphragmOption, DiaphragmName);
		}
		public static (int NumberNames, string[] MyName, string[] MyLabel, string[] MyStory)
		    GetLabelNameList(this cPointObj obj) {
			int NumberNames;
			NumberNames = default(int);
			string[] MyName, MyLabel, MyStory;
			MyName = MyLabel = MyStory = default(string[]);
		    var res = obj.GetLabelNameList(ref NumberNames, ref MyName, ref MyLabel, ref MyStory);
		    return (NumberNames, MyName, MyLabel, MyStory);
		}
		public static (string Label, string Story)
		    GetLabelFromName(this cPointObj obj, string Name) {
			string Label, Story;
			Label = Story = default(string);
		    var res = obj.GetLabelFromName(Name, ref Label, ref Story);
		    return (Label, Story);
		}
		public static string
		    GetNameFromLabel(this cPointObj obj, string Label, string Story) {
			string Name;
			Name = default(string);
		    var res = obj.GetNameFromLabel(Label, Story, ref Name);
		    return Name;
		}
		public static (int NumberNames, string[] MyName, double[] X, double[] Y, double[] Z)
		    GetAllPoints(this cPointObj obj, string csys = "Global") {
			int NumberNames;
			NumberNames = default(int);
			string[] MyName;
			MyName = default(string[]);
			double[] X, Y, Z;
			X = Y = Z = default(double[]);
		    var res = obj.GetAllPoints(ref NumberNames, ref MyName, ref X, ref Y, ref Z, csys);
		    return (NumberNames, MyName, X, Y, Z);
		}
		public static string
		    GetSpringAssignment(this cPointObj obj, string Name) {
			string SpringProp;
			SpringProp = default(string);
		    var res = obj.GetSpringAssignment(Name, ref SpringProp);
		    return SpringProp;
		}

    }
}