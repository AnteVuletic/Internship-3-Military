namespace Military.Vehicles
{
    public class Warship : Vehicle
    {
        public Warship(int weight, int avgSpeed) : base(weight, 70, 200, avgSpeed)
        {

        }
        public override string ToString()
        {
            return base.ToString();
        }
    }
}