using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Convert
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Implicit convertion
            byte b = 100; // 8 bits, 0 to 255
            ushort us; // 16 bits, 0 to 65.535

            us = b;

            // error
            // us = 1000; 
            // b = us;
            #endregion

            #region Explicit convert
            // It can be done by casting but it can cause data loss
            ushort num1 = 1000;
            byte num2= (byte) num1;
            Console.WriteLine(num2); // 232
            #endregion
        }
    }
}
