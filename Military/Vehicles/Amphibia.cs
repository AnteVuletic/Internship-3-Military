namespace Military.Vehicles
{
    public class Amphibia : Vehicle
    {
        public Amphibia(int weight, int avgSpeed) : base(weight, 20, 70, avgSpeed)
        {

        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}