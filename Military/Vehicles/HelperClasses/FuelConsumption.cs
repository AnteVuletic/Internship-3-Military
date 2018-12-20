using System;

namespace Military.Vehicles.HelperClasses
{
    public static class FuelConsumption
    {
        public const int Tank = 30;
        public const int Amphibia = 70;
        public const int Warship = 200;

        public static double TenMinuteDistanceTraveled(double avgSpeed)
        {
            return ((avgSpeed / 60) * 10);
        }
    }
}