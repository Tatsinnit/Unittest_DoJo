using System;

namespace UnitTestLibrary
{
	public interface ITestFirstFastCar
	{
		string KindOfCarBasedOnSpeed(Double speed);
		string KindOfCarBasedOnHorsePower(String horsePower);
		string KindOfCarBasedOnSpeedAndHorsePower(Double speed, String horsePower);
	}

}

