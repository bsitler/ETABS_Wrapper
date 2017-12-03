
using System;
using ETABS2016;

namespace ETABS2016
{
    public static class cTendonObjExtension
    {
		public static (int NumberNames, string[] MyName) GetNameList(this cTendonObj obj) {
			int NumberNames;
			NumberNames = default(int);
			string[] MyName;
			MyName = default(string[]);
		    var res = obj.GetNameList(ref NumberNames, ref MyName);
		    return (NumberNames, MyName);
		}
		public static bool GetSelected(this cTendonObj obj, string Name) {
			bool Selected;
			Selected = default(bool);
		    var res = obj.GetSelected(Name, ref Selected);
		    return Selected;
		}
		public static (int NumberNames, string[] MyName) GetNameListOnStory(this cTendonObj obj, string StoryName) {
			int NumberNames;
			NumberNames = default(int);
			string[] MyName;
			MyName = default(string[]);
		    var res = obj.GetNameListOnStory(StoryName, ref NumberNames, ref MyName);
		    return (NumberNames, MyName);
		}

    }
}