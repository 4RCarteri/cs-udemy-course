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
        public int Sum(int num1, int num2)
        {
            int result = num1 + num2;
            Console.WriteLine("The sum of {0} and {1} is {2}", num1, num2, result);
            return result;
        }

        // Method with return value
        public int Multiply(int num1, int num2)
        {
            return num1 * num2;
        }

        // Method by reference
        public void SumValue(int value)
        {
            value += 10;
        }
        public void Sum10(ref int value)
        {
            value += 10;
        }

        // Method overloading
        public int Sum(int num1, int num2, int num3)
        {
            int result = num1 + num2 + num3;
            return result;
        }

    }
}
