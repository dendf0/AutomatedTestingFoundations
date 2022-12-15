namespace VehicleOOP
{
    public class Truck : Vehicle
    {
        public Truck(Engine engine, Chassis chassis, Transmission transmission)
            : base(engine, chassis, transmission) { }

        public override string ToString()
        {
            string result;
            result = string.Format("Truck:\n");
            result += base.ToString();
            return result;
        }
    }

}
