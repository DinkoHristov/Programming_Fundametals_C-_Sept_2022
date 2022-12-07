
using System;
using System.Collections.Generic;

namespace _06._Vehicle_Catalogue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Vehicle> vehicles = new List<Vehicle>();

            string command = string.Empty;
            while ((command = Console.ReadLine()) != "End")
            {
                string[] vehicleInfo = command.Split();
                string vehicleType = vehicleInfo[0];
                string model = vehicleInfo[1];
                string color = vehicleInfo[2];
                double horsePower = double.Parse(vehicleInfo[3]);

                Vehicle vehicle = new Vehicle(vehicleType, model, color, horsePower);
                vehicles.Add(vehicle);
            }

            string vehicleCommand = string.Empty;
            while ((vehicleCommand = Console.ReadLine()) != "Close the Catalogue")
            {
                foreach(Vehicle vehicle in vehicles)
                {
                    if (vehicle.Model == vehicleCommand)
                    {
                        string letter = vehicle.VehicleType;
                        string newLetter = string.Empty;
                        for (int i = 0; i < letter.Length; i++)
                        {
                            if (i == 0)
                            {
                                newLetter += letter[i].ToString().ToUpper();
                                continue;
                            }

                            newLetter += letter[i];
                        }

                        Console.WriteLine($"Type: {newLetter}");
                        Console.WriteLine($"Model: {vehicle.Model}");
                        Console.WriteLine($"Color: {vehicle.Color}");
                        Console.WriteLine($"Horsepower: {vehicle.HorsePower}");
                    }
                }
            }

            double carHorsePowerAverage = 0;
            double carsCount = 0;
            double truckHorsePowerAverage = 0;
            double trucksCount = 0;

            foreach (Vehicle vehicle in vehicles)
            {
                if (vehicle.VehicleType == "car")
                {
                    carHorsePowerAverage += vehicle.HorsePower;
                    carsCount++;
                }
                else if (vehicle.VehicleType == "truck")
                {
                    truckHorsePowerAverage += vehicle.HorsePower;
                    trucksCount++;
                }
            }

            Console.WriteLine($"Cars have average horsepower of: {carHorsePowerAverage / carsCount:F2}.");
            Console.WriteLine($"Trucks have average horsepower of: {truckHorsePowerAverage / trucksCount:F2}.");
        }
    }

    public class Vehicle
    {
        public Vehicle(string vehicleType, string model, string color, double horsePower)
        {
            VehicleType = vehicleType;
            Model = model;
            Color = color;
            HorsePower = horsePower;
        }

        public string VehicleType { get; private set; }

        public string Model { get; private set; }

        public string Color { get; private set; }

        public double HorsePower { get; private set; }
    }
}
