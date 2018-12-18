namespace Military.Vehicles
{
    public class Tank : Vehicle,IDrivable
    {
        public Tank(int weight,double avgSpeed) : base(weight,HelperClasses.FuelConsumption.Tank,HelperClasses.Capacity.Tank,avgSpeed)
        {

        }
        public override string ToString()
        {
            return base.ToString();
        }

        public int Move(int distance)
        {
            return 2;
        }
    }
}
