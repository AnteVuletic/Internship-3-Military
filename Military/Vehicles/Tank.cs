namespace Military.Vehicles
{
    public sealed class Tank : Vehicle,IDrivable
    {
        public double TripDistanceTraveled { get; set; }
        public Tank(int weight,double avgSpeed) : base(weight,HelperClasses.FuelConsumption.Tank,HelperClasses.Capacity.Tank,avgSpeed)
        {

        }
        public override string ToString()
        {
            return "Tank: " + base.ToString() + $"| {FuelConsumed()} L";
        }

        public void Move(int distance)
        {
            for (var tenKmIterator = 0; tenKmIterator < (distance / 10); tenKmIterator++)
            {
                if (HelperClasses.Probability.ThirtyPercentFailChance())
                    distance += 5;
                TripDistanceTraveled += 10;
            }

            TripDistanceTraveled += distance % 10;
        }
        public override int FuelConsumed()
        {
            return (int)(TripDistanceTraveled * (HelperClasses.FuelConsumption.Tank / 100.00));
        }
        public override void StartNewTrip(int numPassengers, Distance distance)
        {
            TripDistanceTraveled = 0;
            for (var tripIterator = 0; tripIterator < GetNumberOfTrips(numPassengers); tripIterator++)
                Move(distance.DistanceTotal);
        }
    }
}
