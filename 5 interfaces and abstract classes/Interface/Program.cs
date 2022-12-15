using System;

namespace Interface
{
    public class Program
    {
        static void Main(string[] args)
        {
            Bird bird = new Bird();
            Plane plane = new Plane();
            Drone drone = new Drone();

            Coordinate coordBird = new Coordinate(5, 5, 5);
            Coordinate coordPlane = new Coordinate(150000, 100000, 50000);
            Coordinate coordDrone = new Coordinate(100, 200, 300);

            double timeBird = bird.GetFlyTime(coordBird);
            double timePlane = plane.GetFlyTime(coordPlane);
            double timeDrone = drone.GetFlyTime(coordDrone);

            Console.WriteLine("Bird flight took: {0} second(s)", (int)timeBird);
            Console.WriteLine("Plane flight took: {0} second(s)", (int)timePlane);
            Console.WriteLine("Drone flight took: {0} second(s)", (int)timeDrone);
        }
    }
}
