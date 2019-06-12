using LearnCSharp.Vehicles;
using System;

namespace LearnCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            var vehicleBuilder = new VehicleBuilder();

            Vehicle avanza = vehicleBuilder
                .WithManufacture("Toyota")
                .WithType("Avanza")
                .HavingDoors(5)
                .HavingWheels(4)
                .HavingWheelRadius(18.5);

            Console.WriteLine(avanza);
            Console.ReadKey();
            Console.WriteLine();

            avanza = vehicleBuilder.Move(10);
            Console.WriteLine(avanza);
            Console.ReadKey();
            Console.WriteLine();

            avanza = vehicleBuilder.Stop();
            Console.WriteLine(avanza);
            Console.ReadKey();
            Console.WriteLine();
        }
    }
}
