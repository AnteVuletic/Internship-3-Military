using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Military.Vehicles
{
    public class Distance
    {
        public int DistanceWater { get; set; }
        public int DistanceGround { get; set; }
        public int DistanceTotal { get; set; }

        public Distance(int distanceWater, int distanceGround)
        {
            DistanceWater = distanceWater;
            DistanceGround = distanceGround;
            DistanceTotal = distanceGround + distanceWater;
        }

        public Distance(int distance)
        {
            DistanceTotal = distance;
        }
    }
}
