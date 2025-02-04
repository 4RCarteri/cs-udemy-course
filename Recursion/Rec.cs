using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recursion
{
    internal class Rec
    {

        public void Execute(string message, int n)
        {
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(message);
            }
        }

        public void ExecuteRec(string message, int n)
        {
            if (n == 0)
            {
                return;
            }
            Console.WriteLine(message);
            ExecuteRec(message, n - 1);
        }
    }
}
