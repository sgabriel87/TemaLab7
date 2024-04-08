
using System;
using System.Reflection;
using System.Security.Cryptography.X509Certificates;
using System.Text.RegularExpressions;

namespace TemaLab7
{
    internal class Car
    {
        private string brand;
        private string model;
        private int yearOfManufacture;
        private Engine motor;
        private Door[] doors;

        /// <summary>
        /// Enter the Data for the Car!
        /// </summary>
        /// <param name="Brand"></param>
        /// <param name="Model"></param>
        /// <param name="YearOfManufacture"></param>
        /// <param name="EngineCapacity"></param>
        /// <param name="FuelType"></param>
        /// <param name="Power"></param>
        /// <param name="NumberOfDoors"></param>
        public Car(string brand, string model, int yearOfManufacture, int engineCapacity, string fuelType, int power, int numberOfDoors)
        {
            this.brand = brand;
            this.model = model;
            this.yearOfManufacture = yearOfManufacture;
            motor = new Engine(engineCapacity, fuelType, power);
            doors = new Door[numberOfDoors];
            for (int i = 0; i < numberOfDoors; i++)
            {
                doors[i] = new Door(numberOfDoors);
            }
        }

        public string GetDescription()
        {
            return $"{brand}, {model}, {yearOfManufacture}, {motor.GetDescription()}, {doors.Length}";
        }

        public void StartCar()
        {
            Console.WriteLine("The car starts...\n" );
            foreach (var door in doors)
            {
                door.Close();
            }
            motor.StartMotor();
        }

        public void StopCar()
        {
            Console.WriteLine("\nThe car stops...");
            motor.StopMotor();
            foreach (var door in doors)
            {
                door.Open();
            }
        }
    }
}
