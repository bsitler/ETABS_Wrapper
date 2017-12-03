using System;
using ETABS2016;

namespace ETABS2016
{
    public static class cDetailingExtension
    {
		public static (int NumberItems, string[] BeamLineIDs)
		    GetDetailedBeamLines(this cDetailing obj) {
			int NumberItems;
			NumberItems = default(int);
			string[] BeamLineIDs;
			BeamLineIDs = default(string[]);
		    var res = obj.GetDetailedBeamLines(ref NumberItems, ref BeamLineIDs);
		    return (NumberItems, BeamLineIDs);
		}
		public static (string[] ObjectUniqueNames, int NumberSpans, double[] SpanLength, int[] NumLongBars, double[] LongBarDiameter, string[] LongBarNotation, double[] LongBarStartDist, int[] LongBarStartBend, int[] LongBarEndBend, double[] LongBarLength, int[] LongBarNumLayers, int[] NumTieBars, int[] NumTieVertLegs, double[] TieBarDiameter, string[] TieBarNotation, double[] TieBarStartDist, double[] TieBarSpacing, int[] TieBarType)
		    GetDetailedBeamLineData(this cDetailing obj, string BeamLineID) {
			string[] ObjectUniqueNames, LongBarNotation, TieBarNotation;
			ObjectUniqueNames = LongBarNotation = TieBarNotation = default(string[]);
			int NumberSpans;
			NumberSpans = default(int);
			double[] SpanLength, LongBarDiameter, LongBarStartDist, LongBarLength, TieBarDiameter, TieBarStartDist, TieBarSpacing;
			SpanLength = LongBarDiameter = LongBarStartDist = LongBarLength = TieBarDiameter = TieBarStartDist = TieBarSpacing = default(double[]);
			int[] NumLongBars, LongBarStartBend, LongBarEndBend, LongBarNumLayers, NumTieBars, NumTieVertLegs, TieBarType;
			NumLongBars = LongBarStartBend = LongBarEndBend = LongBarNumLayers = NumTieBars = NumTieVertLegs = TieBarType = default(int[]);
		    var res = obj.GetDetailedBeamLineData(BeamLineID, ref ObjectUniqueNames, ref NumberSpans, ref SpanLength, ref NumLongBars, ref LongBarDiameter, ref LongBarNotation, ref LongBarStartDist, ref LongBarStartBend, ref LongBarEndBend, ref LongBarLength, ref LongBarNumLayers, ref NumTieBars, ref NumTieVertLegs, ref TieBarDiameter, ref TieBarNotation, ref TieBarStartDist, ref TieBarSpacing, ref TieBarType);
		    return (ObjectUniqueNames, NumberSpans, SpanLength, NumLongBars, LongBarDiameter, LongBarNotation, LongBarStartDist, LongBarStartBend, LongBarEndBend, LongBarLength, LongBarNumLayers, NumTieBars, NumTieVertLegs, TieBarDiameter, TieBarNotation, TieBarStartDist, TieBarSpacing, TieBarType);
		}
		public static (int NumberItems, string[] ColumnStackIDs)
		    GetDetailedColumnStacks(this cDetailing obj) {
			int NumberItems;
			NumberItems = default(int);
			string[] ColumnStackIDs;
			ColumnStackIDs = default(string[]);
		    var res = obj.GetDetailedColumnStacks(ref NumberItems, ref ColumnStackIDs);
		    return (NumberItems, ColumnStackIDs);
		}
		public static (string[] ObjectUniqueNames, int NumLongBarSets, int[] NumLongBars, double[] LongBarDiameter, string[] LongBarNotation, double[] LongBarStartDist, int[] LongBarStartBend, int[] LongBarEndBend, double[] LongBarLength, int[] LongBarNumLayers, int NumTieZones, string[] TieBarZones, int[] NumTieBars, int[] NumTieVertLegs, double[] TieBarDiameter, string[] TieBarNotation, double[] TieBarStartDist, double[] TieBarSpacing, int[] TieBarType)
		    GetDetailedColumnStackData(this cDetailing obj, string ColumnStackID) {
			string[] ObjectUniqueNames, LongBarNotation, TieBarZones, TieBarNotation;
			ObjectUniqueNames = LongBarNotation = TieBarZones = TieBarNotation = default(string[]);
			int NumLongBarSets, NumTieZones;
			NumLongBarSets = NumTieZones = default(int);
			int[] NumLongBars, LongBarStartBend, LongBarEndBend, LongBarNumLayers, NumTieBars, NumTieVertLegs, TieBarType;
			NumLongBars = LongBarStartBend = LongBarEndBend = LongBarNumLayers = NumTieBars = NumTieVertLegs = TieBarType = default(int[]);
			double[] LongBarDiameter, LongBarStartDist, LongBarLength, TieBarDiameter, TieBarStartDist, TieBarSpacing;
			LongBarDiameter = LongBarStartDist = LongBarLength = TieBarDiameter = TieBarStartDist = TieBarSpacing = default(double[]);
		    var res = obj.GetDetailedColumnStackData(ColumnStackID, ref ObjectUniqueNames, ref NumLongBarSets, ref NumLongBars, ref LongBarDiameter, ref LongBarNotation, ref LongBarStartDist, ref LongBarStartBend, ref LongBarEndBend, ref LongBarLength, ref LongBarNumLayers, ref NumTieZones, ref TieBarZones, ref NumTieBars, ref NumTieVertLegs, ref TieBarDiameter, ref TieBarNotation, ref TieBarStartDist, ref TieBarSpacing, ref TieBarType);
		    return (ObjectUniqueNames, NumLongBarSets, NumLongBars, LongBarDiameter, LongBarNotation, LongBarStartDist, LongBarStartBend, LongBarEndBend, LongBarLength, LongBarNumLayers, NumTieZones, TieBarZones, NumTieBars, NumTieVertLegs, TieBarDiameter, TieBarNotation, TieBarStartDist, TieBarSpacing, TieBarType);
		}
		public static (int NumberItems, string[] Names, double[] SlabElevations, string[] GUIDs)
		    GetDetailedSlabs(this cDetailing obj) {
			int NumberItems;
			NumberItems = default(int);
			string[] Names, GUIDs;
			Names = GUIDs = default(string[]);
			double[] SlabElevations;
			SlabElevations = default(double[]);
		    var res = obj.GetDetailedSlabs(ref NumberItems, ref Names, ref SlabElevations, ref GUIDs);
		    return (NumberItems, Names, SlabElevations, GUIDs);
		}
		public static (int NumData, string[] Names, int[] NumBars, double[] BarDiameter, string[] BarNotation, string[] BarMaterial, double[] StartX, double[] StartY, double[] StartZ, double[] EndX, double[] EndY, double[] EndZ, double[] WidthLeft, double[] WidthRight, double[] OffsetFromTop, double[] OffsetFromBot, int[] StartBarBend, int[] EndBarBend, string[] GUIDs)
		    GetDetailedSlabBotBarData(this cDetailing obj, string SlabName) {
			int NumData;
			NumData = default(int);
			string[] Names, BarNotation, BarMaterial, GUIDs;
			Names = BarNotation = BarMaterial = GUIDs = default(string[]);
			int[] NumBars, StartBarBend, EndBarBend;
			NumBars = StartBarBend = EndBarBend = default(int[]);
			double[] BarDiameter, StartX, StartY, StartZ, EndX, EndY, EndZ, WidthLeft, WidthRight, OffsetFromTop, OffsetFromBot;
			BarDiameter = StartX = StartY = StartZ = EndX = EndY = EndZ = WidthLeft = WidthRight = OffsetFromTop = OffsetFromBot = default(double[]);
		    var res = obj.GetDetailedSlabBotBarData(SlabName, ref NumData, ref Names, ref NumBars, ref BarDiameter, ref BarNotation, ref BarMaterial, ref StartX, ref StartY, ref StartZ, ref EndX, ref EndY, ref EndZ, ref WidthLeft, ref WidthRight, ref OffsetFromTop, ref OffsetFromBot, ref StartBarBend, ref EndBarBend, ref GUIDs);
		    return (NumData, Names, NumBars, BarDiameter, BarNotation, BarMaterial, StartX, StartY, StartZ, EndX, EndY, EndZ, WidthLeft, WidthRight, OffsetFromTop, OffsetFromBot, StartBarBend, EndBarBend, GUIDs);
		}
		public static (int NumData, string[] Names, int[] NumBars, double[] BarDiameter, string[] BarNotation, string[] BarMaterial, double[] StartX, double[] StartY, double[] StartZ, double[] EndX, double[] EndY, double[] EndZ, double[] WidthLeft, double[] WidthRight, double[] OffsetFromTop, double[] OffsetFromBot, int[] StartBarBend, int[] EndBarBend, string[] GUIDs, string[] StripNames, int[] SpanNos)
		    GetDetailedSlabBotBarData_1(this cDetailing obj, string SlabName) {
			int NumData;
			NumData = default(int);
			string[] Names, BarNotation, BarMaterial, GUIDs, StripNames;
			Names = BarNotation = BarMaterial = GUIDs = StripNames = default(string[]);
			int[] NumBars, StartBarBend, EndBarBend, SpanNos;
			NumBars = StartBarBend = EndBarBend = SpanNos = default(int[]);
			double[] BarDiameter, StartX, StartY, StartZ, EndX, EndY, EndZ, WidthLeft, WidthRight, OffsetFromTop, OffsetFromBot;
			BarDiameter = StartX = StartY = StartZ = EndX = EndY = EndZ = WidthLeft = WidthRight = OffsetFromTop = OffsetFromBot = default(double[]);
		    var res = obj.GetDetailedSlabBotBarData_1(SlabName, ref NumData, ref Names, ref NumBars, ref BarDiameter, ref BarNotation, ref BarMaterial, ref StartX, ref StartY, ref StartZ, ref EndX, ref EndY, ref EndZ, ref WidthLeft, ref WidthRight, ref OffsetFromTop, ref OffsetFromBot, ref StartBarBend, ref EndBarBend, ref GUIDs, ref StripNames, ref SpanNos);
		    return (NumData, Names, NumBars, BarDiameter, BarNotation, BarMaterial, StartX, StartY, StartZ, EndX, EndY, EndZ, WidthLeft, WidthRight, OffsetFromTop, OffsetFromBot, StartBarBend, EndBarBend, GUIDs, StripNames, SpanNos);
		}
		public static (int NumData, string[] Names, int[] NumBars, double[] BarDiameter, string[] BarNotation, string[] BarMaterial, double[] StartX, double[] StartY, double[] StartZ, double[] EndX, double[] EndY, double[] EndZ, double[] WidthLeft, double[] WidthRight, double[] OffsetFromTop, double[] OffsetFromBot, int[] StartBarBend, int[] EndBarBend, string[] GUIDs)
		    GetDetailedSlabTopBarData(this cDetailing obj, string SlabName) {
			int NumData;
			NumData = default(int);
			string[] Names, BarNotation, BarMaterial, GUIDs;
			Names = BarNotation = BarMaterial = GUIDs = default(string[]);
			int[] NumBars, StartBarBend, EndBarBend;
			NumBars = StartBarBend = EndBarBend = default(int[]);
			double[] BarDiameter, StartX, StartY, StartZ, EndX, EndY, EndZ, WidthLeft, WidthRight, OffsetFromTop, OffsetFromBot;
			BarDiameter = StartX = StartY = StartZ = EndX = EndY = EndZ = WidthLeft = WidthRight = OffsetFromTop = OffsetFromBot = default(double[]);
		    var res = obj.GetDetailedSlabTopBarData(SlabName, ref NumData, ref Names, ref NumBars, ref BarDiameter, ref BarNotation, ref BarMaterial, ref StartX, ref StartY, ref StartZ, ref EndX, ref EndY, ref EndZ, ref WidthLeft, ref WidthRight, ref OffsetFromTop, ref OffsetFromBot, ref StartBarBend, ref EndBarBend, ref GUIDs);
		    return (NumData, Names, NumBars, BarDiameter, BarNotation, BarMaterial, StartX, StartY, StartZ, EndX, EndY, EndZ, WidthLeft, WidthRight, OffsetFromTop, OffsetFromBot, StartBarBend, EndBarBend, GUIDs);
		}
		public static (int NumData, string[] Names, int[] NumBars, double[] BarDiameter, string[] BarNotation, string[] BarMaterial, double[] StartX, double[] StartY, double[] StartZ, double[] EndX, double[] EndY, double[] EndZ, double[] WidthLeft, double[] WidthRight, double[] OffsetFromTop, double[] OffsetFromBot, int[] StartBarBend, int[] EndBarBend, string[] GUIDs, string[] StripNames, int[] SpanNos)
		    GetDetailedSlabTopBarData_1(this cDetailing obj, string SlabName) {
			int NumData;
			NumData = default(int);
			string[] Names, BarNotation, BarMaterial, GUIDs, StripNames;
			Names = BarNotation = BarMaterial = GUIDs = StripNames = default(string[]);
			int[] NumBars, StartBarBend, EndBarBend, SpanNos;
			NumBars = StartBarBend = EndBarBend = SpanNos = default(int[]);
			double[] BarDiameter, StartX, StartY, StartZ, EndX, EndY, EndZ, WidthLeft, WidthRight, OffsetFromTop, OffsetFromBot;
			BarDiameter = StartX = StartY = StartZ = EndX = EndY = EndZ = WidthLeft = WidthRight = OffsetFromTop = OffsetFromBot = default(double[]);
		    var res = obj.GetDetailedSlabTopBarData_1(SlabName, ref NumData, ref Names, ref NumBars, ref BarDiameter, ref BarNotation, ref BarMaterial, ref StartX, ref StartY, ref StartZ, ref EndX, ref EndY, ref EndZ, ref WidthLeft, ref WidthRight, ref OffsetFromTop, ref OffsetFromBot, ref StartBarBend, ref EndBarBend, ref GUIDs, ref StripNames, ref SpanNos);
		    return (NumData, Names, NumBars, BarDiameter, BarNotation, BarMaterial, StartX, StartY, StartZ, EndX, EndY, EndZ, WidthLeft, WidthRight, OffsetFromTop, OffsetFromBot, StartBarBend, EndBarBend, GUIDs, StripNames, SpanNos);
		}
		public static (int NumberSimilarBeams, int[] NumberUniqueObjects, string[] ObjectUniqueNames)
		    GetSimilarBeamLines(this cDetailing obj, string BeamLineID) {
			int NumberSimilarBeams;
			NumberSimilarBeams = default(int);
			int[] NumberUniqueObjects;
			NumberUniqueObjects = default(int[]);
			string[] ObjectUniqueNames;
			ObjectUniqueNames = default(string[]);
		    var res = obj.GetSimilarBeamLines(BeamLineID, ref NumberSimilarBeams, ref NumberUniqueObjects, ref ObjectUniqueNames);
		    return (NumberSimilarBeams, NumberUniqueObjects, ObjectUniqueNames);
		}
		public static (int NumberSimilarColumns, int[] NumberUniqueObjects, string[] ObjectUniqueNames)
		    GetSimilarColumnStacks(this cDetailing obj, string ColumnStackID) {
			int NumberSimilarColumns;
			NumberSimilarColumns = default(int);
			int[] NumberUniqueObjects;
			NumberUniqueObjects = default(int[]);
			string[] ObjectUniqueNames;
			ObjectUniqueNames = default(string[]);
		    var res = obj.GetSimilarColumnStacks(ColumnStackID, ref NumberSimilarColumns, ref NumberUniqueObjects, ref ObjectUniqueNames);
		    return (NumberSimilarColumns, NumberUniqueObjects, ObjectUniqueNames);
		}
		public static (int NumberSimilarSlabs, string[] Names)
		    GetSimilarSlabs(this cDetailing obj, string SlabName) {
			int NumberSimilarSlabs;
			NumberSimilarSlabs = default(int);
			string[] Names;
			Names = default(string[]);
		    var res = obj.GetSimilarSlabs(SlabName, ref NumberSimilarSlabs, ref Names);
		    return (NumberSimilarSlabs, Names);
		}
		public static (int NumberRebarSets, string[] BarSizeName, double[] BarArea, int[] NumberBars, string[] Location, double[] ClearCover, double[] StartCoord1, double[] BarLength, double[] BendingAngleStart, double[] BendingAngleEnd, string[] RebarSetGUID)
		    GetBeamLongRebarData(this cDetailing obj, string Name) {
			int NumberRebarSets;
			NumberRebarSets = default(int);
			string[] BarSizeName, Location, RebarSetGUID;
			BarSizeName = Location = RebarSetGUID = default(string[]);
			double[] BarArea, ClearCover, StartCoord1, BarLength, BendingAngleStart, BendingAngleEnd;
			BarArea = ClearCover = StartCoord1 = BarLength = BendingAngleStart = BendingAngleEnd = default(double[]);
			int[] NumberBars;
			NumberBars = default(int[]);
		    var res = obj.GetBeamLongRebarData(Name, ref NumberRebarSets, ref BarSizeName, ref BarArea, ref NumberBars, ref Location, ref ClearCover, ref StartCoord1, ref BarLength, ref BendingAngleStart, ref BendingAngleEnd, ref RebarSetGUID);
		    return (NumberRebarSets, BarSizeName, BarArea, NumberBars, Location, ClearCover, StartCoord1, BarLength, BendingAngleStart, BendingAngleEnd, RebarSetGUID);
		}
		public static (int NumberRebarSets, string[] BarSizeName, double[] BarArea, double[] NumberLegs, string[] Location, double[] ClearCover, double[] StartCoord1, double[] Spacing, double[] Lengths, string[] RebarSetGUID)
		    GetBeamTieRebarData(this cDetailing obj, string Name) {
			int NumberRebarSets;
			NumberRebarSets = default(int);
			string[] BarSizeName, Location, RebarSetGUID;
			BarSizeName = Location = RebarSetGUID = default(string[]);
			double[] BarArea, NumberLegs, ClearCover, StartCoord1, Spacing, Lengths;
			BarArea = NumberLegs = ClearCover = StartCoord1 = Spacing = Lengths = default(double[]);
		    var res = obj.GetBeamTieRebarData(Name, ref NumberRebarSets, ref BarSizeName, ref BarArea, ref NumberLegs, ref Location, ref ClearCover, ref StartCoord1, ref Spacing, ref Lengths, ref RebarSetGUID);
		    return (NumberRebarSets, BarSizeName, BarArea, NumberLegs, Location, ClearCover, StartCoord1, Spacing, Lengths, RebarSetGUID);
		}
		public static (int NumberRebarSets, string[] BarSizeName, double[] BarArea, int[] NumberCBars, int[] NumberR3Bars, int[] NumberR2Bars, string[] Location, double[] ClearCover, string[] RebarSetGUID)
		    GetColumnLongRebarData(this cDetailing obj, string Name) {
			int NumberRebarSets;
			NumberRebarSets = default(int);
			string[] BarSizeName, Location, RebarSetGUID;
			BarSizeName = Location = RebarSetGUID = default(string[]);
			double[] BarArea, ClearCover;
			BarArea = ClearCover = default(double[]);
			int[] NumberCBars, NumberR3Bars, NumberR2Bars;
			NumberCBars = NumberR3Bars = NumberR2Bars = default(int[]);
		    var res = obj.GetColumnLongRebarData(Name, ref NumberRebarSets, ref BarSizeName, ref BarArea, ref NumberCBars, ref NumberR3Bars, ref NumberR2Bars, ref Location, ref ClearCover, ref RebarSetGUID);
		    return (NumberRebarSets, BarSizeName, BarArea, NumberCBars, NumberR3Bars, NumberR2Bars, Location, ClearCover, RebarSetGUID);
		}
		public static (int NumberRebarSets, string[] BarSizeName, double[] BarArea, int[] Pattern, int[] ConfineType, int[] NumberLegs2Dir, int[] NumberLegs3Dir, string[] Location, double[] ClearCover, double[] StartCoord1, double[] Spacing, double[] Heights, string[] RebarSetGUID)
		    GetColumnTieRebarData(this cDetailing obj, string Name) {
			int NumberRebarSets;
			NumberRebarSets = default(int);
			string[] BarSizeName, Location, RebarSetGUID;
			BarSizeName = Location = RebarSetGUID = default(string[]);
			double[] BarArea, ClearCover, StartCoord1, Spacing, Heights;
			BarArea = ClearCover = StartCoord1 = Spacing = Heights = default(double[]);
			int[] Pattern, ConfineType, NumberLegs2Dir, NumberLegs3Dir;
			Pattern = ConfineType = NumberLegs2Dir = NumberLegs3Dir = default(int[]);
		    var res = obj.GetColumnTieRebarData(Name, ref NumberRebarSets, ref BarSizeName, ref BarArea, ref Pattern, ref ConfineType, ref NumberLegs2Dir, ref NumberLegs3Dir, ref Location, ref ClearCover, ref StartCoord1, ref Spacing, ref Heights, ref RebarSetGUID);
		    return (NumberRebarSets, BarSizeName, BarArea, Pattern, ConfineType, NumberLegs2Dir, NumberLegs3Dir, Location, ClearCover, StartCoord1, Spacing, Heights, RebarSetGUID);
		}

    }
}