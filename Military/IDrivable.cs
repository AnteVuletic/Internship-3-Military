namespace Military
{
    public interface IDrivable
    {
        double TripDistanceTraveled { get; set; }
        void Move(int distance);
    }
}