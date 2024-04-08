using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemaLab7
{
    internal class Engine
    {
        private int engineCapacity;
        private string fuelType;
        private int power;

        public Engine(int engineCapacity, string fuelType, int power)
        {
            this.engineCapacity = engineCapacity;
            this.fuelType = fuelType;
            this.power = power;
        }

        public string GetDescription()
        {
            return $"{engineCapacity}, {fuelType}, {power}";
        }
        public void StartMotor()
        {
            Console.WriteLine("The motor starts: brr");
        }
        public void StopMotor()
        {
            Console.WriteLine("The motor stops: par poc pac");
        }
    }
} 
