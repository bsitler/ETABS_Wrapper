
using System;
using ETABS2016;

namespace ETABS2016
{
    public static class cSelectExtension
    {
		public static (int NumberItems, int[] ObjectType, string[] ObjectName) GetSelected(this cSelect obj) {
			int NumberItems;
			NumberItems = default(int);
			int[] ObjectType;
			ObjectType = default(int[]);
			string[] ObjectName;
			ObjectName = default(string[]);
		    var res = obj.GetSelected(ref NumberItems, ref ObjectType, ref ObjectName);
		    return (NumberItems, ObjectType, ObjectName);
		}

    }
}