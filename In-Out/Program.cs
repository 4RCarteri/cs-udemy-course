using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace In_Out
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Breaking line");
            Console.Write("Without breaking line");

            // caching ascii code
            int code = Console.Read();
            Console.WriteLine(code);

            // reading a line
            string line = Console.ReadLine();
            Console.WriteLine(line);
            Console.ReadKey();
        }
    }
}
