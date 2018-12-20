using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Military.Vehicles;
using Military.Vehicles.HelperClasses;

namespace Military
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var vehicleOptions = new List<Vehicle>()
            {
                new Amphibia(3000, 30),
                new Amphibia(3000, 20),
                new Tank(4000, 50),
                new Tank(4000, 40),
                new Warship(50000, 45),
                new Warship(55000, 55)
            };
            do
            {
                Console.Clear();
                Console.WriteLine("Mr.General please enter the air distance between A and B:");
                int.TryParse(Console.ReadLine(), out var airDistance);
                Console.WriteLine("Mr.General please enter the number of passengers you'd like to transfer:");
                int.TryParse(Console.ReadLine(), out var numberOfPassengers);
                Console.WriteLine("Distance between A and B by ground only:");
                int.TryParse(Console.ReadLine(), out var onlyGroundDistance);
                Console.WriteLine("Distance between A and B by water only");
                int.TryParse(Console.ReadLine(), out var onlyWaterDistance);
                Console.WriteLine("Distance by water if using amphibia(must be smaller then airDistance):");
                int.TryParse(Console.ReadLine(), out var waterDistance);
                if (waterDistance > airDistance)
                    waterDistance = airDistance;
                foreach (var vehicle in vehicleOptions)
                {
                    switch (vehicle)
                    {
                        case Amphibia amphibia:
                            amphibia.StartNewTrip(numberOfPassengers, new Distance(waterDistance,airDistance-waterDistance));
                            break;
                        case Tank tank:
                            tank.StartNewTrip(numberOfPassengers, new Distance(onlyGroundDistance));
                            break;
                        case Warship warship:
                            warship.StartNewTrip(numberOfPassengers, new Distance(onlyWaterDistance));
                            break;
                    }
                }

                var currentVehicle = 0;
                for (var currentIndexIterator = 0; currentIndexIterator < vehicleOptions.Count; currentIndexIterator++)
                {
                    if (vehicleOptions[currentVehicle].FuelConsumed() >
                        vehicleOptions[currentIndexIterator].FuelConsumed())
                        currentVehicle = currentIndexIterator;
                }
                Console.WriteLine("Dear commander be eco friendly and use this vehicle :");
                Console.WriteLine(vehicleOptions[currentVehicle].ToString());
                Console.WriteLine("Stop execution: y[es]/n[o]");
            } while (Console.ReadKey().Key != ConsoleKey.Y);


        }
    }
}
