namespace Military.Vehicles
{
    public class Tank : Vehicle
    {
        public Tank(int weight,int avgSpeed) : base(weight,30,6,avgSpeed)
        {

        }
        public override string ToString()
        {
            return base.ToString();
        }
    }
}
