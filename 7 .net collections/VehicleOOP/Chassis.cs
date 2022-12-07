namespace VehicleOOP
{
    /// <summary>
    /// Chassis of a vehicle
    /// </summary>
    public class Chassis
    {
        public int wheelQuantity;
        public string number;
        public double load;
        public Chassis(int wheelQuantity, string number, double load)
        {
            this.wheelQuantity = wheelQuantity;
            this.number = number;
            this.load = load;
        }
        public override string ToString()
        {
            string result;
            const int width = 20;
            result = string.Format("{0}{1}\n", "\tNumber of wheels:".PadRight(width), wheelQuantity);
            result += string.Format("{0}{1}\n", "\tNumber:".PadRight(width), number);
            result += string.Format("{0}{1}\n", "\tLoad:".PadRight(width), load);
            return result;
        }
    }

}
