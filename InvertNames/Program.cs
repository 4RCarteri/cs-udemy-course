using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvertNames
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string s1, s2, s3, s4, aux;
            Console.WriteLine("Write the first name:");
            s1 = Console.ReadLine();
            Console.WriteLine("Write the second name:");
            s2 = Console.ReadLine();
            Console.WriteLine("Write the third name:");
            s3 = Console.ReadLine();
            Console.WriteLine("Write the fourth name:");
            s4 = Console.ReadLine();

            aux = s1;
            s1 = s4;
            s4 = aux;
            aux = s2;
            s2 = s3;
            s3 = aux;

            Console.WriteLine("Inverted names: {0}, {1}, {2}, {3}", s1, s2, s3, s4);
        }
    }
}
