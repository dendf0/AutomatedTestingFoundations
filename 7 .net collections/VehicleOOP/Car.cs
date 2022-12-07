namespace VehicleOOP
{
    public class Car : Vehicle
    {
        public Car(Engine engine, Chassis chassis, Transmission transmission)
            : base(engine, chassis, transmission) { }
        public override string ToString()
        {
            string result;
            result = string.Format("Car:\n");
            result += base.ToString();
            return result;
        }
    }

}
