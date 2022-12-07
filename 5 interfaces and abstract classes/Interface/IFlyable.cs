using System;

namespace Interface
{
    interface IFlyable
    {
        /// <summary>
        /// Flies to new coordinate if possible
        /// </summary>
        /// <param name="coord"></param>
        void FlyTo(Coordinate coord);
        /// <summary>
        /// Calculates time to get to new coordinate
        /// </summary>
        /// <param name="coord"></param>
        /// <returns>
        /// Seconds to fly to new coordinate
        /// </returns>
        double GetFlyTime(Coordinate coord);
    }
}
