using System;
using System.Collections.Generic;
using System.Text;

namespace Interface
{
    public class Drone : FlyingThing, IFlyable
    {
        public void FlyTo(Coordinate coord)
        {
            //max drone flight distance
            if (Distance(coord) <= maxDistance)
            {
                currentCoordinate = coord;
            }
        }

        public double GetFlyTime(Coordinate coord)
        {
            double distance = Distance(coord);
            if (distance > maxDistance)
            {
                Console.WriteLine("Drones can't fly further than 7'000 m");
                return 0;
            }
            double time = 0;
            //for each 600 seconds add 60 seconds
            time = distance / speed + ((uint)(distance / speed) % 600) * 60;
            return time;
        }

        public Drone(Coordinate coord) : base(coord)
        {
            maxDistance = 7000;
            speed = 10;
        }

        public Drone() : base()
        {
            maxDistance = 7000;
            speed = 10;
        }
    }
}