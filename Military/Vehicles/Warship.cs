namespace Military.Vehicles
{
    public class Warship : Vehicle,ISwimmable
    {
        public Warship(int weight, double avgSpeed) : base(weight,HelperClasses.FuelConsumption.Warship, HelperClasses.Capacity.Warship, avgSpeed)
        {

        }
        public override string ToString()
        {
            return base.ToString();
        }

        public int Swim(int distance)
        {
            return 2;
        }
    }
}