﻿namespace P01_RawData
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Engine
    {
        private List<Car> cars;

        public Engine()
        {
            this.cars = new List<Car>();
        }

        public void Run()
        {
            var lines = int.Parse(Console.ReadLine());
            for (int i = 0; i < lines; i++)
            {
                var parameters = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                var car = CarCreator(parameters);
                cars.Add(car);
            }

            string command = Console.ReadLine();
            if (command == "fragile")
            {
                List<string> fragile = cars
                    .Where(x => x.CargoType == "fragile" && x.Tires.Any(y => y.Pressure < 1))
                    .Select(x => x.Model)
                    .ToList();

                PrintInfo(fragile);
            }
            else
            {
                List<string> flamable = cars
                    .Where(x => x.CargoType == "flamable" && x.EnginePower > 250)
                    .Select(x => x.Model)
                    .ToList();

                PrintInfo(flamable);
            }
        }

        private void PrintInfo(List<string> cars)
        {
            Console.WriteLine(string.Join(Environment.NewLine, cars));
        }

        private Car CarCreator(string[] parameters)
        {
            string model = parameters[0];
            int engineSpeed = int.Parse(parameters[1]);
            int enginePower = int.Parse(parameters[2]);
            int cargoWeight = int.Parse(parameters[3]);
            string cargoType = parameters[4];

            double tire1Pressure = double.Parse(parameters[5]);
            int tire1age = int.Parse(parameters[6]);
            var tire1 = new Tire(tire1age, tire1Pressure);

            double tire2Pressure = double.Parse(parameters[7]);
            int tire2age = int.Parse(parameters[8]);
            var tire2 = new Tire(tire2age, tire2Pressure);

            double tire3Pressure = double.Parse(parameters[9]);
            int tire3age = int.Parse(parameters[10]);
            var tire3 = new Tire(tire3age, tire3Pressure);

            double tire4Pressure = double.Parse(parameters[11]);
            int tire4age = int.Parse(parameters[12]);
            var tire4 = new Tire(tire4age, tire4Pressure);

            var car = new Car(model, engineSpeed, enginePower, cargoWeight, cargoType, tire1, tire2, tire3, tire4);
            return car;
        }
    }
}