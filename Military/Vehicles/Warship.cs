namespace Military.Vehicles
{
    public sealed class Warship : Vehicle,ISwimmable
    {
        public double TripDistanceTraveled { get; set; }
        public Warship(int weight, double avgSpeed) : base(weight,HelperClasses.FuelConsumption.Warship, HelperClasses.Capacity.Warship, avgSpeed)
        {

        }
        public override string ToString()
        {
            return "Warship: " + base.ToString() + $"| {FuelConsumed()} L";
        }

        public void Swim(int distance)
        {
            for (var tenMinuteIterator = 0; tenMinuteIterator < (distance / HelperClasses.FuelConsumption.TenMinuteDistanceTraveled(AvgSpeed)); tenMinuteIterator++)
            {
                if (HelperClasses.Probability.FiftyPercentFailChance())
                    distance += 3;
                TripDistanceTraveled += HelperClasses.FuelConsumption.TenMinuteDistanceTraveled(AvgSpeed);
            }
            TripDistanceTraveled += distance % HelperClasses.FuelConsumption.TenMinuteDistanceTraveled(AvgSpeed);
        }
        public override int FuelConsumed()
        {
            return (int)(TripDistanceTraveled * (HelperClasses.FuelConsumption.Warship / 100.00));
        }
        public override void StartNewTrip(int numPassengers, Distance distanceWater)
        {
            TripDistanceTraveled = 0;
            for (var tripIterator = 0; tripIterator < GetNumberOfTrips(numPassengers); tripIterator++)
                Swim(distanceWater.DistanceTotal);
        }
    }
}