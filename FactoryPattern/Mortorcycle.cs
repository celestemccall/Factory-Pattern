using System;
namespace FactoryPattern
{
	public class Mortorcycle : IVehicle
	{
		public Mortorcycle()
		{
		}

        public void Drive()
        {
            Console.WriteLine("This motorycle is able to drive on and off the road!");
        }
    }
}

