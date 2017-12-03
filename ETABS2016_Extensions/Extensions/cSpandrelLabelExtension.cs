using System;
using ETABS2016;

namespace ETABS2016
{
    public static class cSpandrelLabelExtension
    {
		public static bool
		    GetSpandrel(this cSpandrelLabel obj, string Name) {
			bool IsMultiStory;
			IsMultiStory = default(bool);
		    var res = obj.GetSpandrel(Name, ref IsMultiStory);
		    return IsMultiStory;
		}
		public static (int NumberNames, string[] MyName, bool[] IsMultiStory)
		    GetNameList(this cSpandrelLabel obj) {
			int NumberNames;
			NumberNames = default(int);
			string[] MyName;
			MyName = default(string[]);
			bool[] IsMultiStory;
			IsMultiStory = default(bool[]);
		    var res = obj.GetNameList(ref NumberNames, ref MyName, ref IsMultiStory);
		    return (NumberNames, MyName, IsMultiStory);
		}

    }
}