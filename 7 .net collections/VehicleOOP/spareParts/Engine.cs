using System;

namespace VehicleOOP
{
    public class Engine
    {
        public double power;
        public double capacity;
        public Engine.Types type;
        public string serialNumber;

        public enum Types
        {
            Gasoline,
            Diesel,
            Electrical
        }

        public Engine(double power, double capacity, string serialNumber, Engine.Types type = Types.Gasoline)
        {
            if (power < 0)
            {
                throw new ArgumentException("Engine power cannot be negative");
            }
            if (power < 0)
            {
                throw new ArgumentException("Engine capacity cannot be negative");
            }

            this.power = power;
            this.capacity = capacity;
            this.serialNumber = serialNumber;
            this.type = type;
        }

        public override string ToString()
        {
            string result;
            const int WIDTH = 20;
            result = string.Format("{0}{1}\n", "\tPower:".PadRight(WIDTH), power);
            result += string.Format("{0}{1}\n", "\tCapacity:".PadRight(WIDTH), capacity);
            result += string.Format("{0}{1}\n", "\tSerial Number:".PadRight(WIDTH), serialNumber);
            result += string.Format("{0}{1}\n", "\tType:".PadRight(WIDTH), type);
            return result;
        }
    }

}
