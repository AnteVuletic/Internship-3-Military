namespace Military.Vehicles
{
    public class Tank : Vehicle,IDrivable
    {
        public double TripDistanceTraveled { get; set; }
        public Tank(int weight,double avgSpeed) : base(weight,HelperClasses.FuelConsumption.Tank,HelperClasses.Capacity.Tank,avgSpeed)
        {

        }
        public override string ToString()
        {
            return base.ToString() + $"| {FuelConsumed()} L";
        }

        public void Move(int distance)
        {
            for (var tenKmIterator = 0; tenKmIterator < (distance / 10); tenKmIterator++)
            {
                if (HelperClasses.FuelConsumption.ThirtyPercentFailChance())
                    distance += 5;
                TripDistanceTraveled += 10;
            }
        }
        public double FuelConsumed()
        {
            return (int)(TripDistanceTraveled * ((double)100 / HelperClasses.FuelConsumption.Tank));
        }
        public int GetNumberOfTrips(int numPassengers)
        {
            if (numPassengers <= HelperClasses.Capacity.Tank)
                return 1;
            return 2 * (numPassengers / HelperClasses.Capacity.Tank) + 1;
        }
        public void StartNewTrip(int distanceLand, int numPassengers)
        {
            TripDistanceTraveled = 0;
            for (var tripIterator = 0; tripIterator < GetNumberOfTrips(numPassengers); tripIterator++)
                Move(distanceLand);
        }
    }
}
