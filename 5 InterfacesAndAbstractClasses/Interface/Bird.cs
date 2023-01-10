using System;
using System.Collections.Generic;
using System.Text;

namespace Interface
{
    public class Bird : FlyingThing, IFlyable
    {
        public void FlyTo(Coordinate coord)
        {
            currentCoordinate = coord;
        }

        public double GetFlyTime(Coordinate coord)
        {
            double time = 0;
            Random rnd = new Random();
            //random speed between 1 and 20 km/h
            speed = rnd.Next(1, 20) / 3.6;
            double distance = Distance(coord);
            time = distance / speed;
            return time;
        }

        public Bird(Coordinate coord) : base(coord) { }

        public Bird() : base() { }
    }
}