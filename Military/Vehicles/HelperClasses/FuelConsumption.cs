using System;

namespace Military.Vehicles.HelperClasses
{
    public static class FuelConsumption
    {
        public const int Tank = 30;
        public const int Amphibia = 70;
        public const int Warship = 200;

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