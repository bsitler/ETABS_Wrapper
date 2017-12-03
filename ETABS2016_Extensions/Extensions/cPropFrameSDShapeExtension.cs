using System;
using ETABS2016;

namespace ETABS2016
{
    public static class cPropFrameSDShapeExtension
    {
		public static (string MatProp, string PropName, int Color, double XCenter, double YCenter, double H, double Bf, double Tf, double Tw, double Rotation)
		    GetAngle(this cPropFrameSDShape obj, string Name, string ShapeName) {
			string MatProp, PropName;
			MatProp = PropName = default(string);
			int Color;
			Color = default(int);
			double XCenter, YCenter, H, Bf, Tf, Tw, Rotation;
			XCenter = YCenter = H = Bf = Tf = Tw = Rotation = default(double);
		    var res = obj.GetAngle(Name, ShapeName, ref MatProp, ref PropName, ref Color, ref XCenter, ref YCenter, ref H, ref Bf, ref Tf, ref Tw, ref Rotation);
		    return (MatProp, PropName, Color, XCenter, YCenter, H, Bf, Tf, Tw, Rotation);
		}
		public static (string MatProp, string PropName, int Color, double XCenter, double YCenter, double H, double Bf, double Tf, double Tw, double Bfb, double Tfb, double Rotation)
		    GetISection(this cPropFrameSDShape obj, string Name, string ShapeName) {
			string MatProp, PropName;
			MatProp = PropName = default(string);
			int Color;
			Color = default(int);
			double XCenter, YCenter, H, Bf, Tf, Tw, Bfb, Tfb, Rotation;
			XCenter = YCenter = H = Bf = Tf = Tw = Bfb = Tfb = Rotation = default(double);
		    var res = obj.GetISection(Name, ShapeName, ref MatProp, ref PropName, ref Color, ref XCenter, ref YCenter, ref H, ref Bf, ref Tf, ref Tw, ref Bfb, ref Tfb, ref Rotation);
		    return (MatProp, PropName, Color, XCenter, YCenter, H, Bf, Tf, Tw, Bfb, Tfb, Rotation);
		}
		public static (double XCenter, double YCenter, double Diameter, int NumBars, double Rotation, string RebarSize, string MatRebar)
		    GetReinfCircle(this cPropFrameSDShape obj, string Name, string ShapeName) {
			double XCenter, YCenter, Diameter, Rotation;
			XCenter = YCenter = Diameter = Rotation = default(double);
			int NumBars;
			NumBars = default(int);
			string RebarSize, MatRebar;
			RebarSize = MatRebar = default(string);
		    var res = obj.GetReinfCircle(Name, ShapeName, ref XCenter, ref YCenter, ref Diameter, ref NumBars, ref Rotation, ref RebarSize, ref MatRebar);
		    return (XCenter, YCenter, Diameter, NumBars, Rotation, RebarSize, MatRebar);
		}
		public static (int NumberItems, int[] PointNum, string[] RebarSize)
		    GetReinfCorner(this cPropFrameSDShape obj, string Name, string ShapeName) {
			int NumberItems;
			NumberItems = default(int);
			int[] PointNum;
			PointNum = default(int[]);
			string[] RebarSize;
			RebarSize = default(string[]);
		    var res = obj.GetReinfCorner(Name, ShapeName, ref NumberItems, ref PointNum, ref RebarSize);
		    return (NumberItems, PointNum, RebarSize);
		}
		public static (int NumberItems, int[] EdgeNum, string[] RebarSize, double[] Spacing, double[] Cover)
		    GetReinfEdge(this cPropFrameSDShape obj, string Name, string ShapeName) {
			int NumberItems;
			NumberItems = default(int);
			int[] EdgeNum;
			EdgeNum = default(int[]);
			string[] RebarSize;
			RebarSize = default(string[]);
			double[] Spacing, Cover;
			Spacing = Cover = default(double[]);
		    var res = obj.GetReinfEdge(Name, ShapeName, ref NumberItems, ref EdgeNum, ref RebarSize, ref Spacing, ref Cover);
		    return (NumberItems, EdgeNum, RebarSize, Spacing, Cover);
		}
		public static (double X1, double Y1, double X2, double Y2, double Spacing, string RebarSize, bool EndBars, string MatRebar)
		    GetReinfLine(this cPropFrameSDShape obj, string Name, string ShapeName) {
			double X1, Y1, X2, Y2, Spacing;
			X1 = Y1 = X2 = Y2 = Spacing = default(double);
			string RebarSize, MatRebar;
			RebarSize = MatRebar = default(string);
			bool EndBars;
			EndBars = default(bool);
		    var res = obj.GetReinfLine(Name, ShapeName, ref X1, ref Y1, ref X2, ref Y2, ref Spacing, ref RebarSize, ref EndBars, ref MatRebar);
		    return (X1, Y1, X2, Y2, Spacing, RebarSize, EndBars, MatRebar);
		}
		public static (double XCenter, double YCenter, double H, double W, double Rotation, string MatRebar)
		    GetReinfRectangular(this cPropFrameSDShape obj, string Name, string ShapeName) {
			double XCenter, YCenter, H, W, Rotation;
			XCenter = YCenter = H = W = Rotation = default(double);
			string MatRebar;
			MatRebar = default(string);
		    var res = obj.GetReinfRectangular(Name, ShapeName, ref XCenter, ref YCenter, ref H, ref W, ref Rotation, ref MatRebar);
		    return (XCenter, YCenter, H, W, Rotation, MatRebar);
		}
		public static (double XCenter, double YCenter, string RebarSize, string MatRebar)
		    GetReinfSingle(this cPropFrameSDShape obj, string Name, string ShapeName) {
			double XCenter, YCenter;
			XCenter = YCenter = default(double);
			string RebarSize, MatRebar;
			RebarSize = MatRebar = default(string);
		    var res = obj.GetReinfSingle(Name, ShapeName, ref XCenter, ref YCenter, ref RebarSize, ref MatRebar);
		    return (XCenter, YCenter, RebarSize, MatRebar);
		}
		public static (string MatProp, string SSOverwrite, int Color, double XCenter, double YCenter, double Diameter, bool Reinf, int NumberBars, double Rotation, double Cover, string RebarSize, string MatRebar)
		    GetSolidCircle(this cPropFrameSDShape obj, string Name, string ShapeName) {
			string MatProp, SSOverwrite, RebarSize, MatRebar;
			MatProp = SSOverwrite = RebarSize = MatRebar = default(string);
			int Color, NumberBars;
			Color = NumberBars = default(int);
			double XCenter, YCenter, Diameter, Rotation, Cover;
			XCenter = YCenter = Diameter = Rotation = Cover = default(double);
			bool Reinf;
			Reinf = default(bool);
		    var res = obj.GetSolidCircle(Name, ShapeName, ref MatProp, ref SSOverwrite, ref Color, ref XCenter, ref YCenter, ref Diameter, ref Reinf, ref NumberBars, ref Rotation, ref Cover, ref RebarSize, ref MatRebar);
		    return (MatProp, SSOverwrite, Color, XCenter, YCenter, Diameter, Reinf, NumberBars, Rotation, Cover, RebarSize, MatRebar);
		}
		public static (string MatProp, string SSOverwrite, int Color, double XCenter, double YCenter, double H, double W, double Rotation, bool Reinf, string MatRebar)
		    GetSolidRect(this cPropFrameSDShape obj, string Name, string ShapeName) {
			string MatProp, SSOverwrite, MatRebar;
			MatProp = SSOverwrite = MatRebar = default(string);
			int Color;
			Color = default(int);
			double XCenter, YCenter, H, W, Rotation;
			XCenter = YCenter = H = W = Rotation = default(double);
			bool Reinf;
			Reinf = default(bool);
		    var res = obj.GetSolidRect(Name, ShapeName, ref MatProp, ref SSOverwrite, ref Color, ref XCenter, ref YCenter, ref H, ref W, ref Rotation, ref Reinf, ref MatRebar);
		    return (MatProp, SSOverwrite, Color, XCenter, YCenter, H, W, Rotation, Reinf, MatRebar);
		}
		public static (string MatProp, string PropName, int Color, double XCenter, double YCenter, double H, double Bf, double Tf, double Tw, double Rotation)
		    GetTee(this cPropFrameSDShape obj, string Name, string ShapeName) {
			string MatProp, PropName;
			MatProp = PropName = default(string);
			int Color;
			Color = default(int);
			double XCenter, YCenter, H, Bf, Tf, Tw, Rotation;
			XCenter = YCenter = H = Bf = Tf = Tw = Rotation = default(double);
		    var res = obj.GetTee(Name, ShapeName, ref MatProp, ref PropName, ref Color, ref XCenter, ref YCenter, ref H, ref Bf, ref Tf, ref Tw, ref Rotation);
		    return (MatProp, PropName, Color, XCenter, YCenter, H, Bf, Tf, Tw, Rotation);
		}
		public static (string MatProp, string PropName, int Color, double XCenter, double YCenter, double H, double Bf, double Tf, double Tw, double Rotation, bool MirrorAbout2, bool MirrorAbout3)
		    GetConcreteL(this cPropFrameSDShape obj, string Name, string ShapeName) {
			string MatProp, PropName;
			MatProp = PropName = default(string);
			int Color;
			Color = default(int);
			double XCenter, YCenter, H, Bf, Tf, Tw, Rotation;
			XCenter = YCenter = H = Bf = Tf = Tw = Rotation = default(double);
			bool MirrorAbout2, MirrorAbout3;
			MirrorAbout2 = MirrorAbout3 = default(bool);
		    var res = obj.GetConcreteL(Name, ShapeName, ref MatProp, ref PropName, ref Color, ref XCenter, ref YCenter, ref H, ref Bf, ref Tf, ref Tw, ref Rotation, ref MirrorAbout2, ref MirrorAbout3);
		    return (MatProp, PropName, Color, XCenter, YCenter, H, Bf, Tf, Tw, Rotation, MirrorAbout2, MirrorAbout3);
		}
		public static (string MatProp, string PropName, int Color, double XCenter, double YCenter, double H, double Bf, double Tf, double Tw, double Rotation, bool MirrorAbout3)
		    GetConcreteTee(this cPropFrameSDShape obj, string Name, string ShapeName) {
			string MatProp, PropName;
			MatProp = PropName = default(string);
			int Color;
			Color = default(int);
			double XCenter, YCenter, H, Bf, Tf, Tw, Rotation;
			XCenter = YCenter = H = Bf = Tf = Tw = Rotation = default(double);
			bool MirrorAbout3;
			MirrorAbout3 = default(bool);
		    var res = obj.GetConcreteTee(Name, ShapeName, ref MatProp, ref PropName, ref Color, ref XCenter, ref YCenter, ref H, ref Bf, ref Tf, ref Tw, ref Rotation, ref MirrorAbout3);
		    return (MatProp, PropName, Color, XCenter, YCenter, H, Bf, Tf, Tw, Rotation, MirrorAbout3);
		}

    }
}