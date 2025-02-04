using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesObjects
{
    internal class Vehicle
    {
        public string Color { get; set; }
        public string Model { get; set; }
        public void Start()
        {
            Console.WriteLine("Starting the vehicle");
        }
        public void Stop()
        {
            Console.WriteLine("Stopping the vehicle");
        }
}
