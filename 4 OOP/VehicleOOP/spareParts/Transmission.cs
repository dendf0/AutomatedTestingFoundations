using System;

namespace VehicleOOP
{
    public class Transmission
    {
        public enum Types
        {
            Automatic,
            Manual,
            SemiAutomatic,
            ContinuouslyVariable
        }

        public Transmission.Types type;
        public int gearQuantity;
        public string manufacturer;

        public Transmission(int gearQuantity, string manufacturer, Transmission.Types type = Types.Automatic)
        {
            if (gearQuantity < 0)
            {
                throw new ArgumentException("Gear quantity cannot be negative");
            }
            this.gearQuantity = gearQuantity;
            this.manufacturer = manufacturer;
            this.type = type;
        }

        public override string ToString()
        {
            string result;
            const int width = 20;
            result = string.Format("{0}{1}\n", "\tType:".PadRight(width), type);
            result += string.Format("{0}{1}\n", "\tNumber of gears:".PadRight(width), gearQuantity);
            result += string.Format("{0}{1}\n", "\tManufacturer:".PadRight(width), manufacturer);
            return result;
        }
    }
}