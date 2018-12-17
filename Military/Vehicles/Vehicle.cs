namespace Military.Vehicles
{
    public abstract class Vehicle
    {
        public static int Id { get; private set; }
        public int Weight { get; set; }
        public int AvgSpeed { get; set; }
        public int FuelConsumption { get; set; }
        public int Capacity { get; set; }

        protected Vehicle(int weight, int fuelConsumption, int capacity, int avgSpeed)
        {
            Id++;
            Weight = weight;
            FuelConsumption = fuelConsumption;
            Capacity = capacity;
            AvgSpeed = avgSpeed;
        }

        public override string ToString()
        {
            return $"{Id} | {Weight}kg | {AvgSpeed}km/h | {FuelConsumption} L/100km| {Capacity} People";
        }
    }
}