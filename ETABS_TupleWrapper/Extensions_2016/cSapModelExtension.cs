
using System;
using ETABS2016;

namespace ETABS2016
{
    public static class cSapModelExtension
    {
		public static double GetMergeTol(this cSapModel obj) {
			double MergeTol;
			MergeTol = default(double);
		    var res = obj.GetMergeTol(ref MergeTol);
		    return MergeTol;
		}
		public static (int NumberItems, string[] Item, string[] Data) GetProjectInfo(this cSapModel obj) {
			int NumberItems;
			NumberItems = default(int);
			string[] Item, Data;
			Item = Data = default(string[]);
		    var res = obj.GetProjectInfo(ref NumberItems, ref Item, ref Data);
		    return (NumberItems, Item, Data);
		}
		public static (string Version, double MyVersionNumber) GetVersion(this cSapModel obj) {
			string Version;
			Version = default(string);
			double MyVersionNumber;
			MyVersionNumber = default(double);
		    var res = obj.GetVersion(ref Version, ref MyVersionNumber);
		    return (Version, MyVersionNumber);
		}
		public static (eForce forceUnits, eLength lengthUnits, eTemperature temperatureUnits) GetDatabaseUnits_2(this cSapModel obj) {
			eForce forceUnits;
			forceUnits = default(eForce);
			eLength lengthUnits;
			lengthUnits = default(eLength);
			eTemperature temperatureUnits;
			temperatureUnits = default(eTemperature);
		    var res = obj.GetDatabaseUnits_2(ref forceUnits, ref lengthUnits, ref temperatureUnits);
		    return (forceUnits, lengthUnits, temperatureUnits);
		}
		public static (eForce forceUnits, eLength lengthUnits, eTemperature temperatureUnits) GetPresentUnits_2(this cSapModel obj) {
			eForce forceUnits;
			forceUnits = default(eForce);
			eLength lengthUnits;
			lengthUnits = default(eLength);
			eTemperature temperatureUnits;
			temperatureUnits = default(eTemperature);
		    var res = obj.GetPresentUnits_2(ref forceUnits, ref lengthUnits, ref temperatureUnits);
		    return (forceUnits, lengthUnits, temperatureUnits);
		}
		public static bool TreeIsUpdateSuspended(this cSapModel obj) {
			bool IsSuspended;
			IsSuspended = default(bool);
		    var res = obj.TreeIsUpdateSuspended(ref IsSuspended);
		    return IsSuspended;
		}

    }
}