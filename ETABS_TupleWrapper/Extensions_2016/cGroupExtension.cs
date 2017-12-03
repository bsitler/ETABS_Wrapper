
using System;
using ETABS2016;

namespace ETABS2016
{
    public static class cGroupExtension
    {
		public static (int NumberItems, int[] ObjectType, string[] ObjectName) GetAssignments(this cGroup obj, string Name) {
			int NumberItems;
			NumberItems = default(int);
			int[] ObjectType;
			ObjectType = default(int[]);
			string[] ObjectName;
			ObjectName = default(string[]);
		    var res = obj.GetAssignments(Name, ref NumberItems, ref ObjectType, ref ObjectName);
		    return (NumberItems, ObjectType, ObjectName);
		}
		public static (int NumberNames, string[] MyName) GetNameList(this cGroup obj) {
			int NumberNames;
			NumberNames = default(int);
			string[] MyName;
			MyName = default(string[]);
		    var res = obj.GetNameList(ref NumberNames, ref MyName);
		    return (NumberNames, MyName);
		}
		public static (int Color, bool SpecifiedForSelection, bool SpecifiedForSectionCutDefinition, bool SpecifiedForSteelDesign, bool SpecifiedForConcreteDesign, bool SpecifiedForAluminumDesign, bool SpecifiedForColdFormedDesign, bool SpecifiedForStaticNLActiveStage, bool SpecifiedForBridgeResponseOutput, bool SpecifiedForAutoSeismicOutput, bool SpecifiedForAutoWindOutput, bool SpecifiedForMassAndWeight) GetGroup(this cGroup obj, string Name) {
			int Color;
			Color = default(int);
			bool SpecifiedForSelection, SpecifiedForSectionCutDefinition, SpecifiedForSteelDesign, SpecifiedForConcreteDesign, SpecifiedForAluminumDesign, SpecifiedForColdFormedDesign, SpecifiedForStaticNLActiveStage, SpecifiedForBridgeResponseOutput, SpecifiedForAutoSeismicOutput, SpecifiedForAutoWindOutput, SpecifiedForMassAndWeight;
			SpecifiedForSelection = SpecifiedForSectionCutDefinition = SpecifiedForSteelDesign = SpecifiedForConcreteDesign = SpecifiedForAluminumDesign = SpecifiedForColdFormedDesign = SpecifiedForStaticNLActiveStage = SpecifiedForBridgeResponseOutput = SpecifiedForAutoSeismicOutput = SpecifiedForAutoWindOutput = SpecifiedForMassAndWeight = default(bool);
		    var res = obj.GetGroup(Name, ref Color, ref SpecifiedForSelection, ref SpecifiedForSectionCutDefinition, ref SpecifiedForSteelDesign, ref SpecifiedForConcreteDesign, ref SpecifiedForAluminumDesign, ref SpecifiedForColdFormedDesign, ref SpecifiedForStaticNLActiveStage, ref SpecifiedForBridgeResponseOutput, ref SpecifiedForAutoSeismicOutput, ref SpecifiedForAutoWindOutput, ref SpecifiedForMassAndWeight);
		    return (Color, SpecifiedForSelection, SpecifiedForSectionCutDefinition, SpecifiedForSteelDesign, SpecifiedForConcreteDesign, SpecifiedForAluminumDesign, SpecifiedForColdFormedDesign, SpecifiedForStaticNLActiveStage, SpecifiedForBridgeResponseOutput, SpecifiedForAutoSeismicOutput, SpecifiedForAutoWindOutput, SpecifiedForMassAndWeight);
		}
		public static (int color, bool SpecifiedForSelection, bool SpecifiedForSectionCutDefinition, bool SpecifiedForSteelDesign, bool SpecifiedForConcreteDesign, bool SpecifiedForAluminumDesign, bool SpecifiedForStaticNLActiveStage, bool SpecifiedForAutoSeismicOutput, bool SpecifiedForAutoWindOutput, bool SpecifiedForMassAndWeight, bool SpecifiedForSteelJoistDesign, bool SpecifiedForWallDesign, bool SpecifiedForBasePlateDesign, bool SpecifiedForConnectionDesign) GetGroup_1(this cGroup obj, string Name) {
			int color;
			color = default(int);
			bool SpecifiedForSelection, SpecifiedForSectionCutDefinition, SpecifiedForSteelDesign, SpecifiedForConcreteDesign, SpecifiedForAluminumDesign, SpecifiedForStaticNLActiveStage, SpecifiedForAutoSeismicOutput, SpecifiedForAutoWindOutput, SpecifiedForMassAndWeight, SpecifiedForSteelJoistDesign, SpecifiedForWallDesign, SpecifiedForBasePlateDesign, SpecifiedForConnectionDesign;
			SpecifiedForSelection = SpecifiedForSectionCutDefinition = SpecifiedForSteelDesign = SpecifiedForConcreteDesign = SpecifiedForAluminumDesign = SpecifiedForStaticNLActiveStage = SpecifiedForAutoSeismicOutput = SpecifiedForAutoWindOutput = SpecifiedForMassAndWeight = SpecifiedForSteelJoistDesign = SpecifiedForWallDesign = SpecifiedForBasePlateDesign = SpecifiedForConnectionDesign = default(bool);
		    var res = obj.GetGroup_1(Name, ref color, ref SpecifiedForSelection, ref SpecifiedForSectionCutDefinition, ref SpecifiedForSteelDesign, ref SpecifiedForConcreteDesign, ref SpecifiedForAluminumDesign, ref SpecifiedForStaticNLActiveStage, ref SpecifiedForAutoSeismicOutput, ref SpecifiedForAutoWindOutput, ref SpecifiedForMassAndWeight, ref SpecifiedForSteelJoistDesign, ref SpecifiedForWallDesign, ref SpecifiedForBasePlateDesign, ref SpecifiedForConnectionDesign);
		    return (color, SpecifiedForSelection, SpecifiedForSectionCutDefinition, SpecifiedForSteelDesign, SpecifiedForConcreteDesign, SpecifiedForAluminumDesign, SpecifiedForStaticNLActiveStage, SpecifiedForAutoSeismicOutput, SpecifiedForAutoWindOutput, SpecifiedForMassAndWeight, SpecifiedForSteelJoistDesign, SpecifiedForWallDesign, SpecifiedForBasePlateDesign, SpecifiedForConnectionDesign);
		}

    }
}