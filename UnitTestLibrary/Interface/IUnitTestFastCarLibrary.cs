using System;

namespace UnitTestLibrary
{
	public interface IUnitTestFastCarLibrary
	{
        string GetKindOfCar(int engineType, int vehicleHorsePower);
		double GetSpeedOfCar(VehicleHorsePower vehicleHorsePower, FordModel model);

		// GetCarIdentification
		// SpeedLimitOfCar
	}

}

