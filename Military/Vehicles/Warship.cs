namespace Military.Vehicles
{
    public class Warship : Vehicle,ISwimmable
    {
        public double TripDistanceTraveled { get; set; }
        public Warship(int weight, double avgSpeed) : base(weight,HelperClasses.FuelConsumption.Warship, HelperClasses.Capacity.Warship, avgSpeed)
        {

        }
        public override string ToString()
        {
            return base.ToString();
        }

        public void Swim(int distance)
        {
            for (var tenMinuteIterator = 0; tenMinuteIterator < (distance / 3); tenMinuteIterator++)
            {
                if (HelperClasses.FuelConsumption.FiftyPercentFailChance())
                    distance += 3;
                TripDistanceTraveled += 3;
            }
        }
    }
}