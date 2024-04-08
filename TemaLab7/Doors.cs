using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemaLab7
{
    internal class Door
    {
        private int numberOfDoors;

        public Door(int numberOfDoors)
        {
            this.numberOfDoors = numberOfDoors;
        }

        public void Open()
        {
            Console.WriteLine("The door opens: click");
        }

        public void Close()
        {
            Console.WriteLine("The door closes: clack");
        }
    }
}
