using System;
using ETABS2016;

namespace ETABS2016
{
    public static class cGridSysExtension
    {
		public static (double x, double y, double RZ)
		    GetGridSys(this cGridSys obj, string Name) {
			double x, y, RZ;
			x = y = RZ = default(double);
		    var res = obj.GetGridSys(Name, ref x, ref y, ref RZ);
		    return (x, y, RZ);
		}
		public static (int NumberNames, string[] MyName)
		    GetNameList(this cGridSys obj) {
			int NumberNames;
			NumberNames = default(int);
			string[] MyName;
			MyName = default(string[]);
		    var res = obj.GetNameList(ref NumberNames, ref MyName);
		    return (NumberNames, MyName);
		}
		public static double[]
		    GetTransformationMatrix(this cGridSys obj, string Name) {
			double[] Value;
			Value = default(double[]);
		    var res = obj.GetTransformationMatrix(Name, ref Value);
		    return Value;
		}
		public static (double Xo, double Yo, double RZ, string GridSysType, int NumXLines, int NumYLines, string[] GridLineIDX, string[] GridLineIDY, double[] OrdinateX, double[] OrdinateY, bool[] VisibleX, bool[] VisibleY, string[] BubbleLocX, string[] BubbleLocY)
		    GetGridSys_2(this cGridSys obj, string Name) {
			double Xo, Yo, RZ;
			Xo = Yo = RZ = default(double);
			string GridSysType;
			GridSysType = default(string);
			int NumXLines, NumYLines;
			NumXLines = NumYLines = default(int);
			string[] GridLineIDX, GridLineIDY, BubbleLocX, BubbleLocY;
			GridLineIDX = GridLineIDY = BubbleLocX = BubbleLocY = default(string[]);
			double[] OrdinateX, OrdinateY;
			OrdinateX = OrdinateY = default(double[]);
			bool[] VisibleX, VisibleY;
			VisibleX = VisibleY = default(bool[]);
		    var res = obj.GetGridSys_2(Name, ref Xo, ref Yo, ref RZ, ref GridSysType, ref NumXLines, ref NumYLines, ref GridLineIDX, ref GridLineIDY, ref OrdinateX, ref OrdinateY, ref VisibleX, ref VisibleY, ref BubbleLocX, ref BubbleLocY);
		    return (Xo, Yo, RZ, GridSysType, NumXLines, NumYLines, GridLineIDX, GridLineIDY, OrdinateX, OrdinateY, VisibleX, VisibleY, BubbleLocX, BubbleLocY);
		}
		public static string
		    GetGridSysType(this cGridSys obj, string Name) {
			string GridSysType;
			GridSysType = default(string);
		    var res = obj.GetGridSysType(Name, ref GridSysType);
		    return GridSysType;
		}
		public static (int NumberNames, string[] GridSysName, string[] GridSysType)
		    GetNameTypeList(this cGridSys obj) {
			int NumberNames;
			NumberNames = default(int);
			string[] GridSysName, GridSysType;
			GridSysName = GridSysType = default(string[]);
		    var res = obj.GetNameTypeList(ref NumberNames, ref GridSysName, ref GridSysType);
		    return (NumberNames, GridSysName, GridSysType);
		}
		public static (double Xo, double Yo, double RZ, bool StoryRangeIsDefault, string TopStory, string BottomStory, double BubbleSize, int GridColor, int NumXLines, string[] GridLineIDX, double[] OrdinateX, bool[] VisibleX, string[] BubbleLocX, int NumYLines, string[] GridLineIDY, double[] OrdinateY, bool[] VisibleY, string[] BubbleLocY, int NumGenLines, string[] GridLineIDGen, double[] GenOrdX1, double[] GenOrdY1, double[] GenOrdX2, double[] GenOrdY2, bool[] VisibleGen, string[] BubbleLocGen)
		    GetGridSysCartesian(this cGridSys obj, string Name) {
			double Xo, Yo, RZ, BubbleSize;
			Xo = Yo = RZ = BubbleSize = default(double);
			bool StoryRangeIsDefault;
			StoryRangeIsDefault = default(bool);
			string TopStory, BottomStory;
			TopStory = BottomStory = default(string);
			int GridColor, NumXLines, NumYLines, NumGenLines;
			GridColor = NumXLines = NumYLines = NumGenLines = default(int);
			string[] GridLineIDX, BubbleLocX, GridLineIDY, BubbleLocY, GridLineIDGen, BubbleLocGen;
			GridLineIDX = BubbleLocX = GridLineIDY = BubbleLocY = GridLineIDGen = BubbleLocGen = default(string[]);
			double[] OrdinateX, OrdinateY, GenOrdX1, GenOrdY1, GenOrdX2, GenOrdY2;
			OrdinateX = OrdinateY = GenOrdX1 = GenOrdY1 = GenOrdX2 = GenOrdY2 = default(double[]);
			bool[] VisibleX, VisibleY, VisibleGen;
			VisibleX = VisibleY = VisibleGen = default(bool[]);
		    var res = obj.GetGridSysCartesian(Name, ref Xo, ref Yo, ref RZ, ref StoryRangeIsDefault, ref TopStory, ref BottomStory, ref BubbleSize, ref GridColor, ref NumXLines, ref GridLineIDX, ref OrdinateX, ref VisibleX, ref BubbleLocX, ref NumYLines, ref GridLineIDY, ref OrdinateY, ref VisibleY, ref BubbleLocY, ref NumGenLines, ref GridLineIDGen, ref GenOrdX1, ref GenOrdY1, ref GenOrdX2, ref GenOrdY2, ref VisibleGen, ref BubbleLocGen);
		    return (Xo, Yo, RZ, StoryRangeIsDefault, TopStory, BottomStory, BubbleSize, GridColor, NumXLines, GridLineIDX, OrdinateX, VisibleX, BubbleLocX, NumYLines, GridLineIDY, OrdinateY, VisibleY, BubbleLocY, NumGenLines, GridLineIDGen, GenOrdX1, GenOrdY1, GenOrdX2, GenOrdY2, VisibleGen, BubbleLocGen);
		}
		public static (double Xo, double Yo, double RZ, bool StoryRangeIsDefault, string TopStory, string BottomStory, double BubbleSize, int GridColor, int NumRLines, string[] GridLineIDR, double[] OrdinateR, bool[] VisibleR, string[] BubbleLocR, int NumTLines, string[] GridLineIDT, double[] OrdinateT, bool[] VisibleT, string[] BubbleLocT)
		    GetGridSysCylindrical(this cGridSys obj, string Name) {
			double Xo, Yo, RZ, BubbleSize;
			Xo = Yo = RZ = BubbleSize = default(double);
			bool StoryRangeIsDefault;
			StoryRangeIsDefault = default(bool);
			string TopStory, BottomStory;
			TopStory = BottomStory = default(string);
			int GridColor, NumRLines, NumTLines;
			GridColor = NumRLines = NumTLines = default(int);
			string[] GridLineIDR, BubbleLocR, GridLineIDT, BubbleLocT;
			GridLineIDR = BubbleLocR = GridLineIDT = BubbleLocT = default(string[]);
			double[] OrdinateR, OrdinateT;
			OrdinateR = OrdinateT = default(double[]);
			bool[] VisibleR, VisibleT;
			VisibleR = VisibleT = default(bool[]);
		    var res = obj.GetGridSysCylindrical(Name, ref Xo, ref Yo, ref RZ, ref StoryRangeIsDefault, ref TopStory, ref BottomStory, ref BubbleSize, ref GridColor, ref NumRLines, ref GridLineIDR, ref OrdinateR, ref VisibleR, ref BubbleLocR, ref NumTLines, ref GridLineIDT, ref OrdinateT, ref VisibleT, ref BubbleLocT);
		    return (Xo, Yo, RZ, StoryRangeIsDefault, TopStory, BottomStory, BubbleSize, GridColor, NumRLines, GridLineIDR, OrdinateR, VisibleR, BubbleLocR, NumTLines, GridLineIDT, OrdinateT, VisibleT, BubbleLocT);
		}

    }
}