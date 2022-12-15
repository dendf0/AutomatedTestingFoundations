using System;
using System.Collections.Generic;
using System.Text;

namespace Interface
{
    public class Plane : FlyingThing, IFlyable
    {
        public void FlyTo(Coordinate coord)
        {
            //max plane flight distance
            if (Distance(coord) <= maxDistance)
            {
                currentCoordinate = coord;
            }
        }

        public double Fly10KM()
        {
            return 10000 / speed;
        }

        public double GetFlyTime(Coordinate coord)
        {

            double distance = Distance(coord);
            if (distance > 15000000)
            {
                Console.WriteLine("Planes can't fly further than 15'000'000 m");
                return 0;
            }
            double time = 0;
            speed = 200 / 3.6;
            while (distance >= 10000)
            {
                time += Fly10KM();
                distance -= 10000;
                //1000 km/h as max plane speed
                if (speed < 1000 / 3.6)
                {
                    speed += 10 / 3.6;
                }
            }
            time += distance / speed;
            return time;
        }

        public Plane(Coordinate coord) : base(coord)
        {
            maxDistance = 15000000;
        }

        public Plane() : base()
        {
            maxDistance = 15000000;
        }
    }
}
