using System;
using ETABS2016;

namespace ETABS2016
{
    public static class cFrameObjExtension
    {
		public static string
		    AddByCoord(this cFrameObj obj, double XI, double YI, double ZI, double XJ, double YJ, double ZJ, string PropName = "Default", string UserName = "", string CSys = "Global") {
			string Name;
			Name = default(string);
		    var res = obj.AddByCoord(XI, YI, ZI, XJ, YJ, ZJ, ref Name, PropName, UserName, CSys);
		    return Name;
		}
		public static string
		    AddByPoint(this cFrameObj obj, string Point1, string Point2, string PropName = "Default", string UserName = "") {
			string Name;
			Name = default(string);
		    var res = obj.AddByPoint(Point1, Point2, ref Name, PropName, UserName);
		    return Name;
		}
		public static int
		    GetDesignProcedure(this cFrameObj obj, string Name) {
			int MyType;
			MyType = default(int);
		    var res = obj.GetDesignProcedure(Name, ref MyType);
		    return MyType;
		}
		public static (int NElm, string[] Elm, double[] RDI, double[] RDJ)
		    GetElm(this cFrameObj obj, string Name) {
			int NElm;
			NElm = default(int);
			string[] Elm;
			Elm = default(string[]);
			double[] RDI, RDJ;
			RDI = RDJ = default(double[]);
		    var res = obj.GetElm(Name, ref NElm, ref Elm, ref RDI, ref RDJ);
		    return (NElm, Elm, RDI, RDJ);
		}
		public static (bool AutoOffset, double Length1, double Length2, double RZ)
		    GetEndLengthOffset(this cFrameObj obj, string Name) {
			bool AutoOffset;
			AutoOffset = default(bool);
			double Length1, Length2, RZ;
			Length1 = Length2 = RZ = default(double);
		    var res = obj.GetEndLengthOffset(Name, ref AutoOffset, ref Length1, ref Length2, ref RZ);
		    return (AutoOffset, Length1, Length2, RZ);
		}
		public static string
		    GetGUID(this cFrameObj obj, string Name) {
			string GUID;
			GUID = default(string);
		    var res = obj.GetGUID(Name, ref GUID);
		    return GUID;
		}
		public static (int NumberHinges, int[] HingeNum, string[] Prop, int[] MyType, int[] Behavior, string[] Source, double[] RD)
		    GetHingeAssigns(this cFrameObj obj, string Name) {
			int NumberHinges;
			NumberHinges = default(int);
			int[] HingeNum, MyType, Behavior;
			HingeNum = MyType = Behavior = default(int[]);
			string[] Prop, Source;
			Prop = Source = default(string[]);
			double[] RD;
			RD = default(double[]);
		    var res = obj.GetHingeAssigns(Name, ref NumberHinges, ref HingeNum, ref Prop, ref MyType, ref Behavior, ref Source, ref RD);
		    return (NumberHinges, HingeNum, Prop, MyType, Behavior, Source, RD);
		}
		public static (int CardinalPoint, bool Mirror2, bool StiffTransform, double[] Offset1, double[] Offset2, string CSys)
		    GetInsertionPoint(this cFrameObj obj, string Name) {
			int CardinalPoint;
			CardinalPoint = default(int);
			bool Mirror2, StiffTransform;
			Mirror2 = StiffTransform = default(bool);
			double[] Offset1, Offset2;
			Offset1 = Offset2 = default(double[]);
			string CSys;
			CSys = default(string);
		    var res = obj.GetInsertionPoint(Name, ref CardinalPoint, ref Mirror2, ref StiffTransform, ref Offset1, ref Offset2, ref CSys);
		    return (CardinalPoint, Mirror2, StiffTransform, Offset1, Offset2, CSys);
		}
		public static (int NumberItems, string[] FrameName, int[] MyType, int[] Loc, double[] RD1, double[] RD2, double[] Dist1, double[] Dist2)
		    GetLateralBracing(this cFrameObj obj, string Name) {
			int NumberItems;
			NumberItems = default(int);
			string[] FrameName;
			FrameName = default(string[]);
			int[] MyType, Loc;
			MyType = Loc = default(int[]);
			double[] RD1, RD2, Dist1, Dist2;
			RD1 = RD2 = Dist1 = Dist2 = default(double[]);
		    var res = obj.GetLateralBracing(Name, ref NumberItems, ref FrameName, ref MyType, ref Loc, ref RD1, ref RD2, ref Dist1, ref Dist2);
		    return (NumberItems, FrameName, MyType, Loc, RD1, RD2, Dist1, Dist2);
		}
		public static (int NumberItems, string[] FrameName, string[] LoadPat, int[] MyType, string[] CSys, int[] Dir, double[] RD1, double[] RD2, double[] Dist1, double[] Dist2, double[] Val1, double[] Val2)
		    GetLoadDistributed(this cFrameObj obj, string Name, eItemType ItemType = eItemType.Objects) {
			int NumberItems;
			NumberItems = default(int);
			string[] FrameName, LoadPat, CSys;
			FrameName = LoadPat = CSys = default(string[]);
			int[] MyType, Dir;
			MyType = Dir = default(int[]);
			double[] RD1, RD2, Dist1, Dist2, Val1, Val2;
			RD1 = RD2 = Dist1 = Dist2 = Val1 = Val2 = default(double[]);
		    var res = obj.GetLoadDistributed(Name, ref NumberItems, ref FrameName, ref LoadPat, ref MyType, ref CSys, ref Dir, ref RD1, ref RD2, ref Dist1, ref Dist2, ref Val1, ref Val2, ItemType);
		    return (NumberItems, FrameName, LoadPat, MyType, CSys, Dir, RD1, RD2, Dist1, Dist2, Val1, Val2);
		}
		public static (int NumberItems, string[] FrameName, string[] LoadPat, int[] MyType, string[] CSys, int[] Dir, double[] RelDist, double[] Dist, double[] Val)
		    GetLoadPoint(this cFrameObj obj, string Name, eItemType ItemType = eItemType.Objects) {
			int NumberItems;
			NumberItems = default(int);
			string[] FrameName, LoadPat, CSys;
			FrameName = LoadPat = CSys = default(string[]);
			int[] MyType, Dir;
			MyType = Dir = default(int[]);
			double[] RelDist, Dist, Val;
			RelDist = Dist = Val = default(double[]);
		    var res = obj.GetLoadPoint(Name, ref NumberItems, ref FrameName, ref LoadPat, ref MyType, ref CSys, ref Dir, ref RelDist, ref Dist, ref Val, ItemType);
		    return (NumberItems, FrameName, LoadPat, MyType, CSys, Dir, RelDist, Dist, Val);
		}
		public static (int NumberItems, string[] FrameName, string[] LoadPat, int[] MyType, double[] Val, string[] PatternName)
		    GetLoadTemperature(this cFrameObj obj, string Name, eItemType ItemType = eItemType.Objects) {
			int NumberItems;
			NumberItems = default(int);
			string[] FrameName, LoadPat, PatternName;
			FrameName = LoadPat = PatternName = default(string[]);
			int[] MyType;
			MyType = default(int[]);
			double[] Val;
			Val = default(double[]);
		    var res = obj.GetLoadTemperature(Name, ref NumberItems, ref FrameName, ref LoadPat, ref MyType, ref Val, ref PatternName, ItemType);
		    return (NumberItems, FrameName, LoadPat, MyType, Val, PatternName);
		}
		public static (double Ang, bool Advanced)
		    GetLocalAxes(this cFrameObj obj, string Name) {
			double Ang;
			Ang = default(double);
			bool Advanced;
			Advanced = default(bool);
		    var res = obj.GetLocalAxes(Name, ref Ang, ref Advanced);
		    return (Ang, Advanced);
		}
		public static double
		    GetMass(this cFrameObj obj, string Name) {
			double MassOverL;
			MassOverL = default(double);
		    var res = obj.GetMass(Name, ref MassOverL);
		    return MassOverL;
		}
		public static string
		    GetMaterialOverwrite(this cFrameObj obj, string Name) {
			string PropName;
			PropName = default(string);
		    var res = obj.GetMaterialOverwrite(Name, ref PropName);
		    return PropName;
		}
		public static double[]
		    GetModifiers(this cFrameObj obj, string Name) {
			double[] Value;
			Value = default(double[]);
		    var res = obj.GetModifiers(Name, ref Value);
		    return Value;
		}
		public static (int NumberNames, string[] MyName)
		    GetNameList(this cFrameObj obj) {
			int NumberNames;
			NumberNames = default(int);
			string[] MyName;
			MyName = default(string[]);
		    var res = obj.GetNameList(ref NumberNames, ref MyName);
		    return (NumberNames, MyName);
		}
		public static (int MyType, double MaxSegSize, int MinSections, bool NoOutPutAndDesignAtElementEnds, bool NoOutPutAndDesignAtPointLoads)
		    GetOutputStations(this cFrameObj obj, string Name) {
			int MyType, MinSections;
			MyType = MinSections = default(int);
			double MaxSegSize;
			MaxSegSize = default(double);
			bool NoOutPutAndDesignAtElementEnds, NoOutPutAndDesignAtPointLoads;
			NoOutPutAndDesignAtElementEnds = NoOutPutAndDesignAtPointLoads = default(bool);
		    var res = obj.GetOutputStations(Name, ref MyType, ref MaxSegSize, ref MinSections, ref NoOutPutAndDesignAtElementEnds, ref NoOutPutAndDesignAtPointLoads);
		    return (MyType, MaxSegSize, MinSections, NoOutPutAndDesignAtElementEnds, NoOutPutAndDesignAtPointLoads);
		}
		public static (string Point1, string Point2)
		    GetPoints(this cFrameObj obj, string Name) {
			string Point1, Point2;
			Point1 = Point2 = default(string);
		    var res = obj.GetPoints(Name, ref Point1, ref Point2);
		    return (Point1, Point2);
		}
		public static (bool[] II, bool[] JJ, double[] StartValue, double[] EndValue)
		    GetReleases(this cFrameObj obj, string Name) {
			bool[] II, JJ;
			II = JJ = default(bool[]);
			double[] StartValue, EndValue;
			StartValue = EndValue = default(double[]);
		    var res = obj.GetReleases(Name, ref II, ref JJ, ref StartValue, ref EndValue);
		    return (II, JJ, StartValue, EndValue);
		}
		public static (string PropName, string SAuto)
		    GetSection(this cFrameObj obj, string Name) {
			string PropName, SAuto;
			PropName = SAuto = default(string);
		    var res = obj.GetSection(Name, ref PropName, ref SAuto);
		    return (PropName, SAuto);
		}
		public static (string PropName, double SVarTotalLength, double SVarRelStartLoc)
		    GetSectionNonPrismatic(this cFrameObj obj, string Name) {
			string PropName;
			PropName = default(string);
			double SVarTotalLength, SVarRelStartLoc;
			SVarTotalLength = SVarRelStartLoc = default(double);
		    var res = obj.GetSectionNonPrismatic(Name, ref PropName, ref SVarTotalLength, ref SVarRelStartLoc);
		    return (PropName, SVarTotalLength, SVarRelStartLoc);
		}
		public static bool
		    GetSelected(this cFrameObj obj, string Name) {
			bool Selected;
			Selected = default(bool);
		    var res = obj.GetSelected(Name, ref Selected);
		    return Selected;
		}
		public static (bool LimitCompressionExists, double LimitCompression, bool LimitTensionExists, double LimitTension)
		    GetTCLimits(this cFrameObj obj, string Name) {
			bool LimitCompressionExists, LimitTensionExists;
			LimitCompressionExists = LimitTensionExists = default(bool);
			double LimitCompression, LimitTension;
			LimitCompression = LimitTension = default(double);
		    var res = obj.GetTCLimits(Name, ref LimitCompressionExists, ref LimitCompression, ref LimitTensionExists, ref LimitTension);
		    return (LimitCompressionExists, LimitCompression, LimitTensionExists, LimitTension);
		}
		public static double[]
		    GetTransformationMatrix(this cFrameObj obj, string Name, bool IsGlobal = true) {
			double[] Value;
			Value = default(double[]);
		    var res = obj.GetTransformationMatrix(Name, ref Value, IsGlobal);
		    return Value;
		}
		public static (int SpliceOption, double Height)
		    GetColumnSpliceOverwrite(this cFrameObj obj, string Name) {
			int SpliceOption;
			SpliceOption = default(int);
			double Height;
			Height = default(double);
		    var res = obj.GetColumnSpliceOverwrite(Name, ref SpliceOption, ref Height);
		    return (SpliceOption, Height);
		}
		public static (int NumberNames, string[] MyName)
		    GetNameListOnStory(this cFrameObj obj, string StoryName) {
			int NumberNames;
			NumberNames = default(int);
			string[] MyName;
			MyName = default(string[]);
		    var res = obj.GetNameListOnStory(StoryName, ref NumberNames, ref MyName);
		    return (NumberNames, MyName);
		}
		public static (int NumberNames, string[] MyName, string[] MyLabel, string[] MyStory)
		    GetLabelNameList(this cFrameObj obj) {
			int NumberNames;
			NumberNames = default(int);
			string[] MyName, MyLabel, MyStory;
			MyName = MyLabel = MyStory = default(string[]);
		    var res = obj.GetLabelNameList(ref NumberNames, ref MyName, ref MyLabel, ref MyStory);
		    return (NumberNames, MyName, MyLabel, MyStory);
		}
		public static (string Label, string Story)
		    GetLabelFromName(this cFrameObj obj, string Name) {
			string Label, Story;
			Label = Story = default(string);
		    var res = obj.GetLabelFromName(Name, ref Label, ref Story);
		    return (Label, Story);
		}
		public static string
		    GetNameFromLabel(this cFrameObj obj, string Label, string Story) {
			string Name;
			Name = default(string);
		    var res = obj.GetNameFromLabel(Label, Story, ref Name);
		    return Name;
		}
		public static (string SupportName1, eObjType SupportType1, string SupportName2, eObjType SupportType2)
		    GetSupports(this cFrameObj obj, string Name) {
			string SupportName1, SupportName2;
			SupportName1 = SupportName2 = default(string);
			eObjType SupportType1, SupportType2;
			SupportType1 = SupportType2 = default(eObjType);
		    var res = obj.GetSupports(Name, ref SupportName1, ref SupportType1, ref SupportName2, ref SupportType2);
		    return (SupportName1, SupportType1, SupportName2, SupportType2);
		}
		public static (int NumberNames, string[] MyName, string[] PropName, string[] StoryName, string[] PointName1, string[] PointName2, double[] Point1X, double[] Point1Y, double[] Point1Z, double[] Point2X, double[] Point2Y, double[] Point2Z, double[] Angle, double[] Offset1X, double[] Offset2X, double[] Offset1Y, double[] Offset2Y, double[] Offset1Z, double[] Offset2Z, int[] CardinalPoint)
		    GetAllFrames(this cFrameObj obj, string csys = "Global") {
			int NumberNames;
			NumberNames = default(int);
			string[] MyName, PropName, StoryName, PointName1, PointName2;
			MyName = PropName = StoryName = PointName1 = PointName2 = default(string[]);
			double[] Point1X, Point1Y, Point1Z, Point2X, Point2Y, Point2Z, Angle, Offset1X, Offset2X, Offset1Y, Offset2Y, Offset1Z, Offset2Z;
			Point1X = Point1Y = Point1Z = Point2X = Point2Y = Point2Z = Angle = Offset1X = Offset2X = Offset1Y = Offset2Y = Offset1Z = Offset2Z = default(double[]);
			int[] CardinalPoint;
			CardinalPoint = default(int[]);
		    var res = obj.GetAllFrames(ref NumberNames, ref MyName, ref PropName, ref StoryName, ref PointName1, ref PointName2, ref Point1X, ref Point1Y, ref Point1Z, ref Point2X, ref Point2Y, ref Point2Z, ref Angle, ref Offset1X, ref Offset2X, ref Offset1Y, ref Offset2Y, ref Offset1Z, ref Offset2Z, ref CardinalPoint, csys);
		    return (NumberNames, MyName, PropName, StoryName, PointName1, PointName2, Point1X, Point1Y, Point1Z, Point2X, Point2Y, Point2Z, Angle, Offset1X, Offset2X, Offset1Y, Offset2Y, Offset1Z, Offset2Z, CardinalPoint);
		}
		public static eFrameDesignOrientation
		    GetDesignOrientation(this cFrameObj obj, string Name) {
			eFrameDesignOrientation DesignOrientation;
			DesignOrientation = default(eFrameDesignOrientation);
		    var res = obj.GetDesignOrientation(Name, ref DesignOrientation);
		    return DesignOrientation;
		}
		public static string
		    GetPier(this cFrameObj obj, string Name) {
			string PierName;
			PierName = default(string);
		    var res = obj.GetPier(Name, ref PierName);
		    return PierName;
		}
		public static string
		    GetSpandrel(this cFrameObj obj, string Name) {
			string SpandrelName;
			SpandrelName = default(string);
		    var res = obj.GetSpandrel(Name, ref SpandrelName);
		    return SpandrelName;
		}
		public static string
		    GetSpringAssignment(this cFrameObj obj, string Name) {
			string SpringProp;
			SpringProp = default(string);
		    var res = obj.GetSpringAssignment(Name, ref SpringProp);
		    return SpringProp;
		}

    }
}