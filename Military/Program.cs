using System;
using System.Collections.Generic;
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
            var someAmphibia = new Amphibia(5000,20);
            someAmphibia.StartNewTrip(60,50,60);
            Console.WriteLine(someAmphibia.ToString());
            var someTank = new Tank(4000,50);
            someTank.StartNewTrip(190,60);
            Console.WriteLine(someTank.ToString());
            var someWarship = new Warship(19000,30);
            someWarship.StartNewTrip(500,60);
            Console.WriteLine(someWarship.ToString());
        }
    }
}
