using System;
using System.Collections.Generic;
using System.Text;

namespace VehicleOOP
{
    public abstract class Vehicle
    {
        public Engine engine { set; get; }
        public Chassis chassis { set; get; }
        public Transmission transmission { set; get; }
        public Vehicle(Engine engine, Chassis chassis, Transmission transmission)
        {
            this.engine = engine;
            this.chassis = chassis;
            this.transmission = transmission;
        }
        public override string ToString()
        {
            string result;
            result = string.Format("Engine:\n{0}", engine);
            result += string.Format("Chassis:\n{0}", chassis);
            result += string.Format("Transmission:\n{0}", transmission);
            return result;
        }
    }
}
