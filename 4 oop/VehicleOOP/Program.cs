using System;
using System.Linq;
using System.Xml.Linq;
using System.Collections.Generic;

namespace VehicleOOP
{
    class Program
    {
        static void Main(string[] args)
        {
            Engine carEngine = new Engine(2000, 1.6,"A12",Engine.Types.Gasoline);
            Engine carEngine2 = new Engine(2000, 1.2,"AA12",Engine.Types.Electrical);
            Chassis carChassis = new Chassis(4, "a12", 1000);
            Chassis carChassis2 = new Chassis(4, "aa12", 800);
            Transmission carTransmission = new Transmission(6, "BMW", Transmission.Types.Automatic);
            Transmission carTransmission2 = new Transmission(6, "Toyota", Transmission.Types.SemiAutomatic);

            Engine truckEngine = new Engine(5000, 5, "B34", Engine.Types.Diesel);
            Engine truckEngine2 = new Engine(4500, 4.5, "BB34", Engine.Types.Gasoline);
            Chassis truckChassis = new Chassis(10, "b34", 7000);
            Chassis truckChassis2 = new Chassis(8, "bb34", 5000);
            Transmission truckTransmission = new Transmission(6, "Man", Transmission.Types.Manual);
            Transmission truckTransmission2 = new Transmission(6, "Lada", Transmission.Types.SemiAutomatic);

            Engine busEngine = new Engine(4000, 4, "C56", Engine.Types.Gasoline);
            Engine busEngine2 = new Engine(3500, 3.5, "CC56", Engine.Types.Electrical);
            Chassis busChassis = new Chassis(6, "c56", 3000);
            Chassis busChassis2 = new Chassis(3, "cc56", 2000);
            Transmission busTransmission = new Transmission(6, "Volvo", Transmission.Types.SemiAutomatic);
            Transmission busTransmission2 = new Transmission(6, "Liaz", Transmission.Types.ContinuouslyVariable);

            Engine scooterEngine = new Engine(500, 0.5, "D78", Engine.Types.Electrical);
            Chassis scooterChassis = new Chassis(2, "d78", 300);
            Transmission scooterTransmission = new Transmission(6, "Stels", Transmission.Types.ContinuouslyVariable);

            Car car = new Car(carEngine, carChassis, carTransmission);
            Car car2 = new Car(carEngine2, carChassis2, carTransmission2);
            Truck truck = new Truck(truckEngine, truckChassis, truckTransmission);
            Truck truck2 = new Truck(truckEngine2, truckChassis2, truckTransmission2);
            Bus bus = new Bus(busEngine, busChassis, busTransmission);
            Bus bus2 = new Bus(busEngine2, busChassis2, busTransmission2);
            Scooter scooter = new Scooter(scooterEngine, scooterChassis, scooterTransmission);

            List<Vehicle> vehicles = new List<Vehicle> { car, car2, truck, truck2, bus, bus2, scooter };

            // all info on vechicles with engine capacity > 1.5
            var bigEnginesVehicles = new XElement("Vehicles",
                from v in vehicles
                where v.engine.capacity > 1.5
                select new XElement("Vehicle",
                    new XElement("Engine",
                        new XElement("Power", v.engine.power),
                        new XElement("Capacity", v.engine.capacity),
                        new XElement("Type", v.engine.type),
                        new XElement("SerialNumber", v.engine.serialNumber)),
                    new XElement("Chassis",
                        new XElement("WheelQuantity", v.chassis.wheelQuantity),
                        new XElement("Number", v.chassis.number),
                        new XElement("Load", v.chassis.load)),
                    new XElement("Transmission",
                        new XElement("GearQuantity", v.transmission.gearQuantity),
                        new XElement("Manufacturer", v.transmission.manufacturer),
                        new XElement("Type", v.transmission.type))
                        ));
            bigEnginesVehicles.Save("MoreThan1.5Engine.xml");

            // all engines of trucks and buses
            var enginesTrucksBuses = new XElement("Engines",
                from v in vehicles
                where v.GetType() == typeof(Truck) || v.GetType() == typeof(Bus)
                select new XElement("Engine",
                    new XElement("Type", v.engine.type),
                    new XElement("SerialNumber", v.engine.serialNumber),
                    new XElement("Power", v.engine.power)
                    ));
            enginesTrucksBuses.Save("EngineTrucksBuses.xml");

            // all info grouped by transmission type
            var groups = from v in vehicles
                         group v by v.transmission.type;

            var groupedByTransmission = new XElement("Vehicles");
            foreach (var grp in groups)
            {
                groupedByTransmission.Add(
                    from v in grp
                    select new XElement("Vehicle",
                        new XElement("Engine",
                            new XElement("Power", v.engine.power),
                            new XElement("Capacity", v.engine.capacity),
                            new XElement("Type", v.engine.type),
                            new XElement("SerialNumber", v.engine.serialNumber)),
                        new XElement("Chassis",
                            new XElement("WheelQuantity", v.chassis.wheelQuantity),
                            new XElement("Number", v.chassis.number),
                            new XElement("Load", v.chassis.load)),
                        new XElement("Transmission",
                            new XElement("GearQuantity", v.transmission.gearQuantity),
                            new XElement("Manufacturer", v.transmission.manufacturer),
                            new XElement("Type", v.transmission.type))
                            ));
            }
            groupedByTransmission.Save("GroupedByTransmission.xml");
        }
    }
}
