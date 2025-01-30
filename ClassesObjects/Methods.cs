using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesObjects
{
    internal class Methods
    {
        // Simple method
        public void Greet()
        {
            Console.WriteLine("Hello, welcome");
        }

        // Method with parameters
        public void Sum(int num1, int num2)
        {
            int result = num1 + num2;
            Console.WriteLine("The sum of {0} and {1} is {2}", num1, num2, result);
        }

        
    }
}
