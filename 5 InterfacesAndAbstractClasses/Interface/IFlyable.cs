using System;

namespace Interface
{
    public interface IFlyable
    {
        /// <summary>
        /// Flies to new coordinate if possible
        /// </summary>
        /// <param name="coord"></param>
        public void FlyTo(Coordinate coord);

        /// <summary>
        /// Calculates time to get to new coordinate
        /// </summary>
        /// <param name="coord"></param>
        /// <returns>
        /// Seconds to fly to new coordinate
        /// </returns>
        public double GetFlyTime(Coordinate coord);
    }
}