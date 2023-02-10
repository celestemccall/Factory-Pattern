using System;
namespace FactoryPattern
{
	public static class VehicleFactory
	{
		public static IVehicle GetVehicle(int wheelCount)
		{
			switch (wheelCount)
			{
				case 2:
					return new Mortorcycle();
				case 4:
					return new Car();
				case 3:
					return new Mortorcycle();
				default:
					return new Car();


			}
		}

    }
}

