using System;
using ETABS2016;

namespace ETABS2016
{
    public static class cPropAreaExtension
    {
		public static double[]
		    GetModifiers(this cPropArea obj, string Name) {
			double[] Value;
			Value = default(double[]);
		    var res = obj.GetModifiers(Name, ref Value);
		    return Value;
		}
		public static (int NumberNames, string[] MyName)
		    GetNameList(this cPropArea obj, int PropType = 0) {
			int NumberNames;
			NumberNames = default(int);
			string[] MyName;
			MyName = default(string[]);
		    var res = obj.GetNameList(ref NumberNames, ref MyName, PropType);
		    return (NumberNames, MyName);
		}
		public static (string MatProp, int SteelLayoutOption, double DesignCoverTopDir1, double DesignCoverTopDir2, double DesignCoverBotDir1, double DesignCoverBotDir2)
		    GetShellDesign(this cPropArea obj, string Name) {
			string MatProp;
			MatProp = default(string);
			int SteelLayoutOption;
			SteelLayoutOption = default(int);
			double DesignCoverTopDir1, DesignCoverTopDir2, DesignCoverBotDir1, DesignCoverBotDir2;
			DesignCoverTopDir1 = DesignCoverTopDir2 = DesignCoverBotDir1 = DesignCoverBotDir2 = default(double);
		    var res = obj.GetShellDesign(Name, ref MatProp, ref SteelLayoutOption, ref DesignCoverTopDir1, ref DesignCoverTopDir2, ref DesignCoverBotDir1, ref DesignCoverBotDir2);
		    return (MatProp, SteelLayoutOption, DesignCoverTopDir1, DesignCoverTopDir2, DesignCoverBotDir1, DesignCoverBotDir2);
		}
		public static (int NumberLayers, string[] LayerName, double[] Dist, double[] Thickness, string[] MatProp, bool[] Nonlinear, double[] MatAng, int[] NumIntegrationPts)
		    GetShellLayer(this cPropArea obj, string Name) {
			int NumberLayers;
			NumberLayers = default(int);
			string[] LayerName, MatProp;
			LayerName = MatProp = default(string[]);
			double[] Dist, Thickness, MatAng;
			Dist = Thickness = MatAng = default(double[]);
			bool[] Nonlinear;
			Nonlinear = default(bool[]);
			int[] NumIntegrationPts;
			NumIntegrationPts = default(int[]);
		    var res = obj.GetShellLayer(Name, ref NumberLayers, ref LayerName, ref Dist, ref Thickness, ref MatProp, ref Nonlinear, ref MatAng, ref NumIntegrationPts);
		    return (NumberLayers, LayerName, Dist, Thickness, MatProp, Nonlinear, MatAng, NumIntegrationPts);
		}
		public static (int NumberLayers, string[] LayerName, double[] Dist, double[] Thickness, int[] MyType, int[] NumIntegrationPts, string[] MatProp, double[] MatAng, int[] S11Type, int[] S22Type, int[] S12Type)
		    GetShellLayer_1(this cPropArea obj, string Name) {
			int NumberLayers;
			NumberLayers = default(int);
			string[] LayerName, MatProp;
			LayerName = MatProp = default(string[]);
			double[] Dist, Thickness, MatAng;
			Dist = Thickness = MatAng = default(double[]);
			int[] MyType, NumIntegrationPts, S11Type, S22Type, S12Type;
			MyType = NumIntegrationPts = S11Type = S22Type = S12Type = default(int[]);
		    var res = obj.GetShellLayer_1(Name, ref NumberLayers, ref LayerName, ref Dist, ref Thickness, ref MyType, ref NumIntegrationPts, ref MatProp, ref MatAng, ref S11Type, ref S22Type, ref S12Type);
		    return (NumberLayers, LayerName, Dist, Thickness, MyType, NumIntegrationPts, MatProp, MatAng, S11Type, S22Type, S12Type);
		}
		public static int
		    GetTypeOAPI(this cPropArea obj, string Name) {
			int PropType;
			PropType = default(int);
		    var res = obj.GetTypeOAPI(Name, ref PropType);
		    return PropType;
		}
		public static (eDeckType DeckType, eShellType ShellType, string MatProp, double Thickness, int color, string notes, string GUID)
		    GetDeck(this cPropArea obj, string Name) {
			eDeckType DeckType;
			DeckType = default(eDeckType);
			eShellType ShellType;
			ShellType = default(eShellType);
			string MatProp, notes, GUID;
			MatProp = notes = GUID = default(string);
			double Thickness;
			Thickness = default(double);
			int color;
			color = default(int);
		    var res = obj.GetDeck(Name, ref DeckType, ref ShellType, ref MatProp, ref Thickness, ref color, ref notes, ref GUID);
		    return (DeckType, ShellType, MatProp, Thickness, color, notes, GUID);
		}
		public static (double SlabDepth, double RibDepth, double RibWidthTop, double RibWidthBot, double RibSpacing, double ShearThickness, double UnitWeight, double ShearStudDia, double ShearStudHt, double ShearStudFu)
		    GetDeckFilled(this cPropArea obj, string Name) {
			double SlabDepth, RibDepth, RibWidthTop, RibWidthBot, RibSpacing, ShearThickness, UnitWeight, ShearStudDia, ShearStudHt, ShearStudFu;
			SlabDepth = RibDepth = RibWidthTop = RibWidthBot = RibSpacing = ShearThickness = UnitWeight = ShearStudDia = ShearStudHt = ShearStudFu = default(double);
		    var res = obj.GetDeckFilled(Name, ref SlabDepth, ref RibDepth, ref RibWidthTop, ref RibWidthBot, ref RibSpacing, ref ShearThickness, ref UnitWeight, ref ShearStudDia, ref ShearStudHt, ref ShearStudFu);
		    return (SlabDepth, RibDepth, RibWidthTop, RibWidthBot, RibSpacing, ShearThickness, UnitWeight, ShearStudDia, ShearStudHt, ShearStudFu);
		}
		public static (double SlabDepth, double ShearStudDia, double ShearStudHt, double ShearStudFu)
		    GetDeckSolidSlab(this cPropArea obj, string Name) {
			double SlabDepth, ShearStudDia, ShearStudHt, ShearStudFu;
			SlabDepth = ShearStudDia = ShearStudHt = ShearStudFu = default(double);
		    var res = obj.GetDeckSolidSlab(Name, ref SlabDepth, ref ShearStudDia, ref ShearStudHt, ref ShearStudFu);
		    return (SlabDepth, ShearStudDia, ShearStudHt, ShearStudFu);
		}
		public static (double RibDepth, double RibWidthTop, double RibWidthBot, double RibSpacing, double ShearThickness, double UnitWeight)
		    GetDeckUnfilled(this cPropArea obj, string Name) {
			double RibDepth, RibWidthTop, RibWidthBot, RibSpacing, ShearThickness, UnitWeight;
			RibDepth = RibWidthTop = RibWidthBot = RibSpacing = ShearThickness = UnitWeight = default(double);
		    var res = obj.GetDeckUnfilled(Name, ref RibDepth, ref RibWidthTop, ref RibWidthBot, ref RibSpacing, ref ShearThickness, ref UnitWeight);
		    return (RibDepth, RibWidthTop, RibWidthBot, RibSpacing, ShearThickness, UnitWeight);
		}
		public static (eSlabType SlabType, eShellType ShellType, string MatProp, double Thickness, int color, string notes, string GUID)
		    GetSlab(this cPropArea obj, string Name) {
			eSlabType SlabType;
			SlabType = default(eSlabType);
			eShellType ShellType;
			ShellType = default(eShellType);
			string MatProp, notes, GUID;
			MatProp = notes = GUID = default(string);
			double Thickness;
			Thickness = default(double);
			int color;
			color = default(int);
		    var res = obj.GetSlab(Name, ref SlabType, ref ShellType, ref MatProp, ref Thickness, ref color, ref notes, ref GUID);
		    return (SlabType, ShellType, MatProp, Thickness, color, notes, GUID);
		}
		public static (double OverallDepth, double SlabThickness, double StemWidthTop, double StemWidthBot, double RibSpacing, int RibsParallelTo)
		    GetSlabRibbed(this cPropArea obj, string Name) {
			double OverallDepth, SlabThickness, StemWidthTop, StemWidthBot, RibSpacing;
			OverallDepth = SlabThickness = StemWidthTop = StemWidthBot = RibSpacing = default(double);
			int RibsParallelTo;
			RibsParallelTo = default(int);
		    var res = obj.GetSlabRibbed(Name, ref OverallDepth, ref SlabThickness, ref StemWidthTop, ref StemWidthBot, ref RibSpacing, ref RibsParallelTo);
		    return (OverallDepth, SlabThickness, StemWidthTop, StemWidthBot, RibSpacing, RibsParallelTo);
		}
		public static (double OverallDepth, double SlabThickness, double StemWidthTop, double StemWidthBot, double RibSpacingDir1, double RibSpacingDir2)
		    GetSlabWaffle(this cPropArea obj, string Name) {
			double OverallDepth, SlabThickness, StemWidthTop, StemWidthBot, RibSpacingDir1, RibSpacingDir2;
			OverallDepth = SlabThickness = StemWidthTop = StemWidthBot = RibSpacingDir1 = RibSpacingDir2 = default(double);
		    var res = obj.GetSlabWaffle(Name, ref OverallDepth, ref SlabThickness, ref StemWidthTop, ref StemWidthBot, ref RibSpacingDir1, ref RibSpacingDir2);
		    return (OverallDepth, SlabThickness, StemWidthTop, StemWidthBot, RibSpacingDir1, RibSpacingDir2);
		}
		public static (eWallPropType WallPropType, eShellType ShellType, string MatProp, double Thickness, int color, string notes, string GUID)
		    GetWall(this cPropArea obj, string Name) {
			eWallPropType WallPropType;
			WallPropType = default(eWallPropType);
			eShellType ShellType;
			ShellType = default(eShellType);
			string MatProp, notes, GUID;
			MatProp = notes = GUID = default(string);
			double Thickness;
			Thickness = default(double);
			int color;
			color = default(int);
		    var res = obj.GetWall(Name, ref WallPropType, ref ShellType, ref MatProp, ref Thickness, ref color, ref notes, ref GUID);
		    return (WallPropType, ShellType, MatProp, Thickness, color, notes, GUID);
		}
		public static (string[] AutoSelectList, string StartingProperty)
		    GetWallAutoSelectList(this cPropArea obj, string Name) {
			string[] AutoSelectList;
			AutoSelectList = default(string[]);
			string StartingProperty;
			StartingProperty = default(string);
		    var res = obj.GetWallAutoSelectList(Name, ref AutoSelectList, ref StartingProperty);
		    return (AutoSelectList, StartingProperty);
		}

    }
}