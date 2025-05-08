using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _31_CylinderVolume
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double R, A, h, V;
            R = 0;
            while (R <= 0)
            {
                Console.Write("Type the the cylinder base radius: ");
                R = double.Parse(Console.ReadLine());
            }

            h = 0;
            while (h <= 0)
            {
                Console.Write("Type the cylinder height: ");
                h = double.Parse(Console.ReadLine());
            }

            Console.WriteLine();

            //Base area
            A = Math.PI * Math.Pow(R, 2);

            //Volume
            V = A * h;
            Console.WriteLine($"Cylinder volume {V}");
        }
    }
}
