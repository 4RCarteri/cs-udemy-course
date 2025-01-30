using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesObjects
{
    internal class Person
    {
        // Attributes
        public string name;
        public string surname;
        public int yearBirth;

        // Simple method
        public void Greet()
        {
            Console.WriteLine("Hello, my name is {0} {1}", name, surname);
        }
    }
}
