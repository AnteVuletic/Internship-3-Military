namespace Military
{
    public interface ISwimmable
    {
        double TripDistanceTraveled { get; set; }
        void Swim(int distance);
    }
}