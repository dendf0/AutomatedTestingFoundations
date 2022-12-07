using System;
using System.Collections.Generic;
using System.Text;

namespace Interface
{
    /// <summary>
    /// Coordinate of a thing in 3-dimensional space
    /// </summary>
    struct Coordinate
    {
        public uint x;
        public uint y;
        public uint z;
        public Coordinate(uint x, uint y, uint z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }
    }
    abstract class FlyingThing
    {
        // m
        public Coordinate currentCoordinate;
        public double maxDistance;
        // m/s
        public double speed;
        public double maxSpeed;
        /// <summary>
        /// Distance to coordinate
        /// </summary>
        /// <param name="coord"></param>
        /// <returns>
        /// Distance from current position to parameter coordinate
        /// </returns>
        public double Distance(Coordinate coord)
        {
            double distance = Math.Sqrt(
                (currentCoordinate.x - coord.x) * (currentCoordinate.x - coord.x) +
                (currentCoordinate.y - coord.y) * (currentCoordinate.y - coord.y) +
                (currentCoordinate.z - coord.z) * (currentCoordinate.z - coord.z));
            return distance;
        }
        public FlyingThing(Coordinate coord)
        {
            currentCoordinate = coord;
        }
        public FlyingThing()
        {
            currentCoordinate.x = 0;
            currentCoordinate.y = 0;
            currentCoordinate.z = 0;
        }
    }
}
