using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesObjects
{
    internal class Car : Vehicle
    {
        public int MaxSpeed { get; set; }


        public void Start()
        {
            Console.WriteLine("Starting the vehicle");
        }
    }
}
