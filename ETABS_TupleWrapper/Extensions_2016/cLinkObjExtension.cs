
using System;
using ETABS2016;

namespace ETABS2016
{
    public static class cLinkObjExtension
    {
		public static string AddByCoord(this cLinkObj obj, double XI, double YI, double ZI, double XJ, double YJ, double ZJ, bool IsSingleJoint, string PropName, string UserName, string CSys) {
			string Name;
			Name = default(string);
		    var res = obj.AddByCoord(XI, YI, ZI, XJ, YJ, ZJ, ref Name, IsSingleJoint, PropName, UserName, CSys);
		    return Name;
		}
		public static string AddByPoint(this cLinkObj obj, string Point1, string Point2, bool IsSingleJoint, string PropName, string UserName) {
			string Name;
			Name = default(string);
		    var res = obj.AddByPoint(Point1, Point2, ref Name, IsSingleJoint, PropName, UserName);
		    return Name;
		}
		public static string GetElm(this cLinkObj obj, string Name) {
			string Elm;
			Elm = default(string);
		    var res = obj.GetElm(Name, ref Elm);
		    return Elm;
		}
		public static string GetGUID(this cLinkObj obj, string Name) {
			string GUID;
			GUID = default(string);
		    var res = obj.GetGUID(Name, ref GUID);
		    return GUID;
		}
		public static (double Ang, bool Advanced) GetLocalAxes(this cLinkObj obj, string Name) {
			double Ang;
			Ang = default(double);
			bool Advanced;
			Advanced = default(bool);
		    var res = obj.GetLocalAxes(Name, ref Ang, ref Advanced);
		    return (Ang, Advanced);
		}
		public static (bool Active, int AxVectOpt, string AxCSys, int[] AxDir, string[] AxPt, double[] AxVect, int Plane2, int PlVectOpt, string PlCSys, int[] PlDir, string[] PlPt, double[] PlVect) GetLocalAxesAdvanced(this cLinkObj obj, string Name) {
			bool Active;
			Active = default(bool);
			int AxVectOpt, Plane2, PlVectOpt;
			AxVectOpt = Plane2 = PlVectOpt = default(int);
			string AxCSys, PlCSys;
			AxCSys = PlCSys = default(string);
			int[] AxDir, PlDir;
			AxDir = PlDir = default(int[]);
			string[] AxPt, PlPt;
			AxPt = PlPt = default(string[]);
			double[] AxVect, PlVect;
			AxVect = PlVect = default(double[]);
		    var res = obj.GetLocalAxesAdvanced(Name, ref Active, ref AxVectOpt, ref AxCSys, ref AxDir, ref AxPt, ref AxVect, ref Plane2, ref PlVectOpt, ref PlCSys, ref PlDir, ref PlPt, ref PlVect);
		    return (Active, AxVectOpt, AxCSys, AxDir, AxPt, AxVect, Plane2, PlVectOpt, PlCSys, PlDir, PlPt, PlVect);
		}
		public static (int NumberNames, string[] MyName) GetNameList(this cLinkObj obj) {
			int NumberNames;
			NumberNames = default(int);
			string[] MyName;
			MyName = default(string[]);
		    var res = obj.GetNameList(ref NumberNames, ref MyName);
		    return (NumberNames, MyName);
		}
		public static (string Point1, string Point2) GetPoints(this cLinkObj obj, string Name) {
			string Point1, Point2;
			Point1 = Point2 = default(string);
		    var res = obj.GetPoints(Name, ref Point1, ref Point2);
		    return (Point1, Point2);
		}
		public static string GetProperty(this cLinkObj obj, string Name) {
			string PropName;
			PropName = default(string);
		    var res = obj.GetProperty(Name, ref PropName);
		    return PropName;
		}
		public static bool GetSelected(this cLinkObj obj, string Name) {
			bool Selected;
			Selected = default(bool);
		    var res = obj.GetSelected(Name, ref Selected);
		    return Selected;
		}
		public static double[] GetTransformationMatrix(this cLinkObj obj, string Name, bool IsGlobal) {
			double[] Value;
			Value = default(double[]);
		    var res = obj.GetTransformationMatrix(Name, ref Value, IsGlobal);
		    return Value;
		}
		public static (int NumberNames, string[] MyName) GetNameListOnStory(this cLinkObj obj, string StoryName) {
			int NumberNames;
			NumberNames = default(int);
			string[] MyName;
			MyName = default(string[]);
		    var res = obj.GetNameListOnStory(StoryName, ref NumberNames, ref MyName);
		    return (NumberNames, MyName);
		}

    }
}