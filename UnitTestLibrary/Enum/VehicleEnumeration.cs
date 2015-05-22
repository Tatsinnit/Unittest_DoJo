using System;
using System.ComponentModel;

namespace UnitTestLibrary
{
	public enum VehicleSpeedEnumeration
	{
	    NormalSpeed = 100,
	    RegularSpeed = 110,
	    CriticalSpeed = 120
	}

	public enum FordModel
	{
		MustangV6,
		MustangEcoBoost,
		MustangGT
	}

	public enum VehicleHorsePower
	{
		[Description("300 hp @ 6500")]
		MustangV6 = 1,
		[Description("310 @ 5500 (93-octane fuel)")]
		MustangEcoBoost = 2,
		[Description("435 @ 6500 (93-octane fuel)")]
		MustangGT = 3
	}

	public enum EngineType
	{
		[Description("3.7L Ti-VCT V-6 Engine")]
		Engine1 = 1,
		[Description("2.3L GTDI I-4 Engine")]
		Engine2 = 2,
		[Description("5.0L Ti-VCT V-8 Engine")]
		Engine3 = 3
	}
}