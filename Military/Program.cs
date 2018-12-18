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
            var someAmphibia = new Amphibia(5000,30);
            someAmphibia.StartNewTrip(60,50,20);
            Console.WriteLine(someAmphibia.ToString());
        }
    }
}
