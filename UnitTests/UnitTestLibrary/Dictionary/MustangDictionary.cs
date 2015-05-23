using System;
using System.Collections.Generic;

namespace UnitTestLibrary
{
	public class MustangDictionary
	{
		public static Dictionary<double, string> BuildMustandSpeedDictionary()
		{
			Dictionary<double, string> myDictionary = new Dictionary<double, string>();
			myDictionary.Add (100.00, "MustangGT");
			myDictionary.Add (140.00, "MustangEcoBoost");
			myDictionary.Add (150.00, "MustangV6");
			return myDictionary;
		}

		public static Dictionary<string, string> BuildMustangHPDictionary()
		{
			Dictionary<string, string> myDictionary = new Dictionary<string, string>();
			myDictionary.Add ("300 hp @ 6500", "MustangV6");
			myDictionary.Add ("310 @ 5500 (93-octane fuel)", "MustangEcoBoost");
			myDictionary.Add ("435 @ 6500 (93-octane fuel)", "MustangGT");
			return myDictionary;
		}
	}
}

