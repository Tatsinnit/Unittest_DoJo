using System;

namespace UnitTestLibrary
{
	public interface ITestFirstFastCar
	{
		string KindOfCarBasedOnSpeed(Double speed);
		string KindOfCarBasedOnHorsePower(Double speed, String horsePower);
		string KindOfCarBasedOnSpeedAndHorsePower(Double speed, String horsePower);
	}

}

