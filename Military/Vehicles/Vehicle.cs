using System;
using System.Collections.Generic;
using System.Threading;

namespace Military.Vehicles
{
    public abstract class Vehicle
    {
        public static int Id { get; private set; }
        public int Weight { get; set; }
        public double AvgSpeed { get; set; }
        public int FuelConsumption { get; set; }
        public int Capacity { get; set; }

        protected Vehicle(int weight, int fuelConsumption, int capacity, double avgSpeed)
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
        public int GetNumberOfTrips(int numPassengers)
        {
            if (numPassengers <= Capacity)
                return 1;
            return 2 * (numPassengers / Capacity) + 1;
        }


        public abstract void StartNewTrip(int numPassengers,Distance distance);
        public abstract int FuelConsumed();
    }
}