using System;
using ETABS2016;

namespace ETABS2016
{
    public static class cAreaObjExtension
    {
		public static (double[] X, double[] Y, double[] Z, string Name)
		    AddByCoord(this cAreaObj obj, int NumberPoints, string PropName = "Default", string UserName = "", string CSys = "Global") {
			double[] X, Y, Z;
			X = Y = Z = default(double[]);
			string Name;
			Name = default(string);
		    var res = obj.AddByCoord(NumberPoints, ref X, ref Y, ref Z, ref Name, PropName, UserName, CSys);
		    return (X, Y, Z, Name);
		}
		public static (string[] Point, string Name)
		    AddByPoint(this cAreaObj obj, int NumberPoints, string PropName = "Default", string UserName = "") {
			string[] Point;
			Point = default(string[]);
			string Name;
			Name = default(string);
		    var res = obj.AddByPoint(NumberPoints, ref Point, ref Name, PropName, UserName);
		    return (Point, Name);
		}
		public static bool
		    GetEdgeConstraint(this cAreaObj obj, string Name) {
			bool ConstraintExists;
			ConstraintExists = default(bool);
		    var res = obj.GetEdgeConstraint(Name, ref ConstraintExists);
		    return ConstraintExists;
		}
		public static (int NElm, string[] Elm)
		    GetElm(this cAreaObj obj, string Name) {
			int NElm;
			NElm = default(int);
			string[] Elm;
			Elm = default(string[]);
		    var res = obj.GetElm(Name, ref NElm, ref Elm);
		    return (NElm, Elm);
		}
		public static string
		    GetGUID(this cAreaObj obj, string Name) {
			string GUID;
			GUID = default(string);
		    var res = obj.GetGUID(Name, ref GUID);
		    return GUID;
		}
		public static (int NumberItems, string[] AreaName, string[] LoadPat, int[] MyType, double[] Value, string[] PatternName)
		    GetLoadTemperature(this cAreaObj obj, string Name, eItemType ItemType = eItemType.Objects) {
			int NumberItems;
			NumberItems = default(int);
			string[] AreaName, LoadPat, PatternName;
			AreaName = LoadPat = PatternName = default(string[]);
			int[] MyType;
			MyType = default(int[]);
			double[] Value;
			Value = default(double[]);
		    var res = obj.GetLoadTemperature(Name, ref NumberItems, ref AreaName, ref LoadPat, ref MyType, ref Value, ref PatternName, ItemType);
		    return (NumberItems, AreaName, LoadPat, MyType, Value, PatternName);
		}
		public static (int NumberItems, string[] AreaName, string[] LoadPat, string[] CSys, int[] Dir, double[] Value)
		    GetLoadUniform(this cAreaObj obj, string Name, eItemType ItemType = eItemType.Objects) {
			int NumberItems;
			NumberItems = default(int);
			string[] AreaName, LoadPat, CSys;
			AreaName = LoadPat = CSys = default(string[]);
			int[] Dir;
			Dir = default(int[]);
			double[] Value;
			Value = default(double[]);
		    var res = obj.GetLoadUniform(Name, ref NumberItems, ref AreaName, ref LoadPat, ref CSys, ref Dir, ref Value, ItemType);
		    return (NumberItems, AreaName, LoadPat, CSys, Dir, Value);
		}
		public static (int NumberItems, string[] AreaName, string[] LoadPat, string[] CSys, int[] Dir, double[] Value, int[] DistType)
		    GetLoadUniformToFrame(this cAreaObj obj, string Name, eItemType ItemType = eItemType.Objects) {
			int NumberItems;
			NumberItems = default(int);
			string[] AreaName, LoadPat, CSys;
			AreaName = LoadPat = CSys = default(string[]);
			int[] Dir, DistType;
			Dir = DistType = default(int[]);
			double[] Value;
			Value = default(double[]);
		    var res = obj.GetLoadUniformToFrame(Name, ref NumberItems, ref AreaName, ref LoadPat, ref CSys, ref Dir, ref Value, ref DistType, ItemType);
		    return (NumberItems, AreaName, LoadPat, CSys, Dir, Value, DistType);
		}
		public static (int NumberItems, string[] AreaName, string[] LoadPat, int[] MyType, double[] Cp)
		    GetLoadWindPressure(this cAreaObj obj, string Name, eItemType ItemType = eItemType.Objects) {
			int NumberItems;
			NumberItems = default(int);
			string[] AreaName, LoadPat;
			AreaName = LoadPat = default(string[]);
			int[] MyType;
			MyType = default(int[]);
			double[] Cp;
			Cp = default(double[]);
		    var res = obj.GetLoadWindPressure(Name, ref NumberItems, ref AreaName, ref LoadPat, ref MyType, ref Cp, ItemType);
		    return (NumberItems, AreaName, LoadPat, MyType, Cp);
		}
		public static (double Ang, bool Advanced)
		    GetLocalAxes(this cAreaObj obj, string Name) {
			double Ang;
			Ang = default(double);
			bool Advanced;
			Advanced = default(bool);
		    var res = obj.GetLocalAxes(Name, ref Ang, ref Advanced);
		    return (Ang, Advanced);
		}
		public static double
		    GetMass(this cAreaObj obj, string Name) {
			double MassOverL2;
			MassOverL2 = default(double);
		    var res = obj.GetMass(Name, ref MassOverL2);
		    return MassOverL2;
		}
		public static string
		    GetMaterialOverwrite(this cAreaObj obj, string Name) {
			string PropName;
			PropName = default(string);
		    var res = obj.GetMaterialOverwrite(Name, ref PropName);
		    return PropName;
		}
		public static double[]
		    GetModifiers(this cAreaObj obj, string Name) {
			double[] Value;
			Value = default(double[]);
		    var res = obj.GetModifiers(Name, ref Value);
		    return Value;
		}
		public static (int NumberNames, string[] MyName)
		    GetNameList(this cAreaObj obj) {
			int NumberNames;
			NumberNames = default(int);
			string[] MyName;
			MyName = default(string[]);
		    var res = obj.GetNameList(ref NumberNames, ref MyName);
		    return (NumberNames, MyName);
		}
		public static bool
		    GetOpening(this cAreaObj obj, string Name) {
			bool IsOpening;
			IsOpening = default(bool);
		    var res = obj.GetOpening(Name, ref IsOpening);
		    return IsOpening;
		}
		public static (int NumberPoints, string[] Point)
		    GetPoints(this cAreaObj obj, string Name) {
			int NumberPoints;
			NumberPoints = default(int);
			string[] Point;
			Point = default(string[]);
		    var res = obj.GetPoints(Name, ref NumberPoints, ref Point);
		    return (NumberPoints, Point);
		}
		public static string
		    GetProperty(this cAreaObj obj, string Name) {
			string PropName;
			PropName = default(string);
		    var res = obj.GetProperty(Name, ref PropName);
		    return PropName;
		}
		public static bool
		    GetSelected(this cAreaObj obj, string Name) {
			bool Selected;
			Selected = default(bool);
		    var res = obj.GetSelected(Name, ref Selected);
		    return Selected;
		}
		public static (int NumberEdges, bool[] Selected)
		    GetSelectedEdge(this cAreaObj obj, string Name) {
			int NumberEdges;
			NumberEdges = default(int);
			bool[] Selected;
			Selected = default(bool[]);
		    var res = obj.GetSelectedEdge(Name, ref NumberEdges, ref Selected);
		    return (NumberEdges, Selected);
		}
		public static double[]
		    GetTransformationMatrix(this cAreaObj obj, string Name, bool IsGlobal = true) {
			double[] Value;
			Value = default(double[]);
		    var res = obj.GetTransformationMatrix(Name, ref Value, IsGlobal);
		    return Value;
		}
		public static eAreaDesignOrientation
		    GetDesignOrientation(this cAreaObj obj, string Name) {
			eAreaDesignOrientation DesignOrientation;
			DesignOrientation = default(eAreaDesignOrientation);
		    var res = obj.GetDesignOrientation(Name, ref DesignOrientation);
		    return DesignOrientation;
		}
		public static (int NumberNames, string[] MyName)
		    GetNameListOnStory(this cAreaObj obj, string StoryName) {
			int NumberNames;
			NumberNames = default(int);
			string[] MyName;
			MyName = default(string[]);
		    var res = obj.GetNameListOnStory(StoryName, ref NumberNames, ref MyName);
		    return (NumberNames, MyName);
		}
		public static string
		    GetDiaphragm(this cAreaObj obj, string Name) {
			string DiaphragmName;
			DiaphragmName = default(string);
		    var res = obj.GetDiaphragm(Name, ref DiaphragmName);
		    return DiaphragmName;
		}
		public static (int NumberNames, string[] MyName, string[] MyLabel, string[] MyStory)
		    GetLabelNameList(this cAreaObj obj) {
			int NumberNames;
			NumberNames = default(int);
			string[] MyName, MyLabel, MyStory;
			MyName = MyLabel = MyStory = default(string[]);
		    var res = obj.GetLabelNameList(ref NumberNames, ref MyName, ref MyLabel, ref MyStory);
		    return (NumberNames, MyName, MyLabel, MyStory);
		}
		public static (string Label, string Story)
		    GetLabelFromName(this cAreaObj obj, string Name) {
			string Label, Story;
			Label = Story = default(string);
		    var res = obj.GetLabelFromName(Name, ref Label, ref Story);
		    return (Label, Story);
		}
		public static string
		    GetNameFromLabel(this cAreaObj obj, string Label, string Story) {
			string Name;
			Name = default(string);
		    var res = obj.GetNameFromLabel(Label, Story, ref Name);
		    return Name;
		}
		public static (int NumberRebarLayers, string[] LayerID, eWallPierRebarLayerType[] LayerType, double[] ClearCover, string[] BarSizeName, double[] BarArea, double[] BarSpacing, int[] NumberBars, bool[] Confined, double[] EndZoneLength, double[] EndZoneThickness, double[] EndZoneOffset)
		    GetRebarDataPier(this cAreaObj obj, string Name) {
			int NumberRebarLayers;
			NumberRebarLayers = default(int);
			string[] LayerID, BarSizeName;
			LayerID = BarSizeName = default(string[]);
			eWallPierRebarLayerType[] LayerType;
			LayerType = default(eWallPierRebarLayerType[]);
			double[] ClearCover, BarArea, BarSpacing, EndZoneLength, EndZoneThickness, EndZoneOffset;
			ClearCover = BarArea = BarSpacing = EndZoneLength = EndZoneThickness = EndZoneOffset = default(double[]);
			int[] NumberBars;
			NumberBars = default(int[]);
			bool[] Confined;
			Confined = default(bool[]);
		    var res = obj.GetRebarDataPier(Name, ref NumberRebarLayers, ref LayerID, ref LayerType, ref ClearCover, ref BarSizeName, ref BarArea, ref BarSpacing, ref NumberBars, ref Confined, ref EndZoneLength, ref EndZoneThickness, ref EndZoneOffset);
		    return (NumberRebarLayers, LayerID, LayerType, ClearCover, BarSizeName, BarArea, BarSpacing, NumberBars, Confined, EndZoneLength, EndZoneThickness, EndZoneOffset);
		}
		public static (int NumberRebarLayers, string[] LayerID, eWallSpandrelRebarLayerType[] LayerType, double[] ClearCover, int[] BarSizeIndex, double[] BarArea, double[] BarSpacing, int[] NumberBars, bool[] Confined)
		    GetRebarDataSpandrel(this cAreaObj obj, string Name) {
			int NumberRebarLayers;
			NumberRebarLayers = default(int);
			string[] LayerID;
			LayerID = default(string[]);
			eWallSpandrelRebarLayerType[] LayerType;
			LayerType = default(eWallSpandrelRebarLayerType[]);
			double[] ClearCover, BarArea, BarSpacing;
			ClearCover = BarArea = BarSpacing = default(double[]);
			int[] BarSizeIndex, NumberBars;
			BarSizeIndex = NumberBars = default(int[]);
			bool[] Confined;
			Confined = default(bool[]);
		    var res = obj.GetRebarDataSpandrel(Name, ref NumberRebarLayers, ref LayerID, ref LayerType, ref ClearCover, ref BarSizeIndex, ref BarArea, ref BarSpacing, ref NumberBars, ref Confined);
		    return (NumberRebarLayers, LayerID, LayerType, ClearCover, BarSizeIndex, BarArea, BarSpacing, NumberBars, Confined);
		}
		public static (int NumberNames, string[] MyName, eAreaDesignOrientation[] DesignOrientation, int NumberBoundaryPts, int[] PointDelimiter, string[] PointNames, double[] PointX, double[] PointY, double[] PointZ)
		    GetAllAreas(this cAreaObj obj) {
			int NumberNames, NumberBoundaryPts;
			NumberNames = NumberBoundaryPts = default(int);
			string[] MyName, PointNames;
			MyName = PointNames = default(string[]);
			eAreaDesignOrientation[] DesignOrientation;
			DesignOrientation = default(eAreaDesignOrientation[]);
			int[] PointDelimiter;
			PointDelimiter = default(int[]);
			double[] PointX, PointY, PointZ;
			PointX = PointY = PointZ = default(double[]);
		    var res = obj.GetAllAreas(ref NumberNames, ref MyName, ref DesignOrientation, ref NumberBoundaryPts, ref PointDelimiter, ref PointNames, ref PointX, ref PointY, ref PointZ);
		    return (NumberNames, MyName, DesignOrientation, NumberBoundaryPts, PointDelimiter, PointNames, PointX, PointY, PointZ);
		}
		public static string
		    GetPier(this cAreaObj obj, string Name) {
			string PierName;
			PierName = default(string);
		    var res = obj.GetPier(Name, ref PierName);
		    return PierName;
		}
		public static string
		    GetSpandrel(this cAreaObj obj, string Name) {
			string SpandrelName;
			SpandrelName = default(string);
		    var res = obj.GetSpandrel(Name, ref SpandrelName);
		    return SpandrelName;
		}
		public static string
		    GetSpringAssignment(this cAreaObj obj, string Name) {
			string SpringProp;
			SpringProp = default(string);
		    var res = obj.GetSpringAssignment(Name, ref SpringProp);
		    return SpringProp;
		}

    }
}