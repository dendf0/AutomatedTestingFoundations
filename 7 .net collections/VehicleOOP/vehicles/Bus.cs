namespace VehicleOOP
{
    public class Bus : Vehicle
    {
        public Bus(Engine engine, Chassis chassis, Transmission transmission)
            : base(engine, chassis, transmission) { }

        public override string ToString()
        {
            string result;
            result = string.Format("Bus:\n");
            result += base.ToString();
            return result;
        }
    }

}
