using System;
using System.Collections.Generic;

namespace UnitTestLibrary
{
	public class TestFirstFastCar : ITestFirstFastCar
	{
		public Dictionary<double, string> mustangSpeedDictionary{ get; set; }
		public Dictionary<string, string> mustangSpeedHPDictionary{ get; set; }

		public TestFirstFastCar()
		{
		}

		public string KindOfCarBasedOnSpeed(Double speed)
		{
			mustangSpeedDictionary = UnitTestLibrary.MustangDictionary.BuildMustandSpeedDictionary();

			var carName = "";

			if (mustangSpeedDictionary.ContainsKey (speed))
				carName = mustangSpeedDictionary[speed];

			return carName;
		}

		public string KindOfCarBasedOnHorsePower(String horsePower)
		{
			mustangSpeedHPDictionary = UnitTestLibrary.MustangDictionary.BuildMustangHPDictionary ();

			var carNameByHP = "";

			if (mustangSpeedHPDictionary.ContainsKey (horsePower))
				carNameByHP = mustangSpeedHPDictionary [horsePower];

			return carNameByHP;
		}

		public string KindOfCarBasedOnSpeedAndHorsePower(Double speed, String horsePower)
		{
			return "";
		}
	}
}

