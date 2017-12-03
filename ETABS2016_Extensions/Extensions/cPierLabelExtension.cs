using System;
using ETABS2016;

namespace ETABS2016
{
    public static class cPierLabelExtension
    {
		public static (int NumberNames, string[] MyName)
		    GetNameList(this cPierLabel obj) {
			int NumberNames;
			NumberNames = default(int);
			string[] MyName;
			MyName = default(string[]);
		    var res = obj.GetNameList(ref NumberNames, ref MyName);
		    return (NumberNames, MyName);
		}
		public static (int NumberStories, string[] StoryName, double[] AxisAngle, int[] NumAreaObjs, int[] NumLineObjs, double[] WidthBot, double[] ThicknessBot, double[] WidthTop, double[] ThicknessTop, string[] MatProp, double[] CGBotX, double[] CGBotY, double[] CGBotZ, double[] CGTopX, double[] CGTopY, double[] CGTopZ)
		    GetSectionProperties(this cPierLabel obj, string Name) {
			int NumberStories;
			NumberStories = default(int);
			string[] StoryName, MatProp;
			StoryName = MatProp = default(string[]);
			double[] AxisAngle, WidthBot, ThicknessBot, WidthTop, ThicknessTop, CGBotX, CGBotY, CGBotZ, CGTopX, CGTopY, CGTopZ;
			AxisAngle = WidthBot = ThicknessBot = WidthTop = ThicknessTop = CGBotX = CGBotY = CGBotZ = CGTopX = CGTopY = CGTopZ = default(double[]);
			int[] NumAreaObjs, NumLineObjs;
			NumAreaObjs = NumLineObjs = default(int[]);
		    var res = obj.GetSectionProperties(Name, ref NumberStories, ref StoryName, ref AxisAngle, ref NumAreaObjs, ref NumLineObjs, ref WidthBot, ref ThicknessBot, ref WidthTop, ref ThicknessTop, ref MatProp, ref CGBotX, ref CGBotY, ref CGBotZ, ref CGTopX, ref CGTopY, ref CGTopZ);
		    return (NumberStories, StoryName, AxisAngle, NumAreaObjs, NumLineObjs, WidthBot, ThicknessBot, WidthTop, ThicknessTop, MatProp, CGBotX, CGBotY, CGBotZ, CGTopX, CGTopY, CGTopZ);
		}

    }
}