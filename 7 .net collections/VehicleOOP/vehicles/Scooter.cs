namespace VehicleOOP
{
    public class Scooter : Vehicle
    {
        public Scooter(Engine engine, Chassis chassis, Transmission transmission)
            : base(engine, chassis, transmission) { }

        public override string ToString()
        {
            string result;
            result = string.Format("Scooter:\n");
            result += base.ToString();
            return result;
        }
    }

}
