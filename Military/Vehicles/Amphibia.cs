using System.Diagnostics.Eventing.Reader;

namespace Military.Vehicles
{
    public sealed class Amphibia : Vehicle, IDrivable,ISwimmable
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
            for (var tenMinuteIterator = 0; tenMinuteIterator < (distance / HelperClasses.FuelConsumption.TenMinuteDistanceTraveled(AvgSpeed)); tenMinuteIterator++)
            {
                if (HelperClasses.FuelConsumption.FiftyPercentFailChance())
                    distance += 3;
                TripDistanceTraveled += HelperClasses.FuelConsumption.TenMinuteDistanceTraveled(AvgSpeed);
            }
            TripDistanceTraveled += distance % HelperClasses.FuelConsumption.TenMinuteDistanceTraveled(AvgSpeed);
        }
        public override double FuelConsumed()
        {
            return (int)(TripDistanceTraveled * ((double)100 / HelperClasses.FuelConsumption.Amphibia));
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