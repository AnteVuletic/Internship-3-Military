using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Military.Vehicles.HelperClasses
{
    public static class Probability
    {
        public static bool ThirtyPercentFailChance()
        {
            return new Random().Next(1, 100) <= 30;
        }
        public static bool FiftyPercentFailChance()
        {
            return new Random().Next(1, 100) <= 50;
        }
    }
}
