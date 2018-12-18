using System.Diagnostics.Eventing.Reader;

namespace Military.Vehicles
{
    public class Amphibia : Vehicle, IDrivable,ISwimmable
    {
        public double TripDistanceTraveled { get; set; }

        public Amphibia(int weight, double avgSpeed) : base(weight, HelperClasses.FuelConsumption.Amphibia,HelperClasses.Capacity.Amphibia, avgSpeed)
        {
        }

        public override string ToString()
        {
            return base.ToString() + $"| {FuelConsumed()} L";
        }

        public void Move(int distance)
        {
            for (var tenKmIterator = 0; tenKmIterator < (distance/10); tenKmIterator++)
            {
                if (HelperClasses.FuelConsumption.ThirtyPercentFailChance())
                    distance += 5;
                TripDistanceTraveled += 10;
            }

            TripDistanceTraveled += distance % 10;
        }
        public void Swim(int distance)
        {
            for (var tenMinuteIterator = 0; tenMinuteIterator < (distance / TenMinuteDistanceTraveled()); tenMinuteIterator++)
            {
                if (HelperClasses.FuelConsumption.FiftyPercentFailChance())
                    distance += 3;
                TripDistanceTraveled += TenMinuteDistanceTraveled();
            }
            TripDistanceTraveled += distance % TenMinuteDistanceTraveled();
        }

        public double FuelConsumed()
        {
            return (int)(TripDistanceTraveled * ((double)100/HelperClasses.FuelConsumption.Amphibia));
        }
        public int GetNumberOfTrips(int numPassengers)
        {
            if (numPassengers <= HelperClasses.Capacity.Amphibia)
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
                Swim(distanceWater);
                Move(distanceLand);
            }
        }

    }
}