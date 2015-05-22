using System;
using System.ComponentModel;
using System.Reflection;

namespace UnitTestLibrary
{
	public class UnitTestFastCarLibrary : IUnitTestFastCarLibrary
	{
		public UnitTestFastCarLibrary ()
		{
		}

	    public string GetKindOfCar(int engineType, int vehicleHorsePower)
	    {
            var vehicleHP = GetEnumDescription<VehicleHorsePower>(vehicleHorsePower);
            var vehicleET = GetEnumDescription<EngineType>(engineType);

	        if (vehicleHorsePower == engineType)
	        {
	            var returnMsg = "So you got => " + Enum.Parse(typeof (FordModel), engineType.ToString())
	                            + " of horse power " + vehicleHP 
                                + " with engineType " + vehicleET;

                Console.WriteLine(returnMsg);

                return returnMsg;
	        }
	        return "Say Wat?";
	    }

        public VehicleSpeedEnumeration GetSpeedOfCar(int speedOfCar)
        {
            var speed = (VehicleSpeedEnumeration) Enum.Parse(typeof(VehicleSpeedEnumeration), speedOfCar.ToString());

            return speed;
        }

        private static string GetEnumDescription<TEnum>(int value)
        {
            return GetEnumDescription((Enum)(object)((TEnum)(object)value));  // ugly, but works
        }

        private static string GetEnumDescription(Enum value)
        {
            FieldInfo fi = value.GetType().GetField(value.ToString());

            DescriptionAttribute[] attributes =
                (DescriptionAttribute[])fi.GetCustomAttributes(
                typeof(DescriptionAttribute),
                false);

            if (attributes != null &&
                attributes.Length > 0)
                return attributes[0].Description;
            else
                return value.ToString();
        }

	}
}

