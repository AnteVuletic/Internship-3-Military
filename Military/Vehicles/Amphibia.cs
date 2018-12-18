using System.Diagnostics.Eventing.Reader;

namespace Military.Vehicles
{
    public class Amphibia : Vehicle, IDrivable,ISwimmable
    {
        public int TripDistanceTraveled { get; private set; }

        public Amphibia(int weight, double avgSpeed) : base(weight, HelperClasses.FuelConsumption.Amphibia,HelperClasses.Capacity.Amphibia, avgSpeed)
        {
        }

        public override string ToString()
        {
            return base.ToString() + $"| {FuelConsumed()} liters";
        }

        public int Move(int distance)
        {
            var realDistance = 0;
            for (var tenKmIterator = 0; tenKmIterator < (distance/10); tenKmIterator++)
            {
                if (HelperClasses.FuelConsumption.ThirtyPercentFailChance())
                    distance += 5;
                realDistance += 10;
            }
            return realDistance;
        }
        public int Swim(int distance)
        {
            var realDistance = 0.0;
            for (var tenMinuteIterator = 0; tenMinuteIterator < (distance / TenMinuteDistanceTraveled()); tenMinuteIterator++)
            {
                if (HelperClasses.FuelConsumption.FiftyPercentFailChance())
                    distance += 3;
                realDistance += TenMinuteDistanceTraveled();
            }
            return (int)realDistance;
        }

        public double FuelConsumed()
        {
            return TripDistanceTraveled * (100/HelperClasses.FuelConsumption.Amphibia);
        }
        public int GetNumberOfTrips(int numPassengers)
        {
            if (numPassengers == HelperClasses.Capacity.Amphibia)
                return 1;
            return 2 * (numPassengers / HelperClasses.Capacity.Amphibia) + 1;
        }
        private double TenMinuteDistanceTraveled()
        {
            return (AvgSpeed / 60) * 10;
        }

        public void StartNewTrip(int distanceWater,int distanceLand,int numPassengers)
        {
            TripDistanceTraveled = 0;
            for (var tripIterator = 0; tripIterator < GetNumberOfTrips(numPassengers); tripIterator++)
            {
                TripDistanceTraveled += Swim(distanceWater);
                TripDistanceTraveled += Move(distanceLand);
            }
        }

    }
}