using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesObjects
{
    internal class Delegate
    {
        public void Sum(int n1, int n2) {
            Console.WriteLine("A soma de {0} e {1} é {2}", n1, n2, n1 + n2);
        }

        public void Subtract(int n1, int n2)
        {
            Console.WriteLine("A subtração de {0} e {1} é {2}", n1, n2, n1 - n2);
        }

        public void Multiply(int n1, int n2)
        {
            Console.WriteLine("A multiplicação de {0} e {1} é {2}", n1, n2, n1 * n2);
        }

        public void Divide(int n1, int n2)
        {
            Console.WriteLine("A divisão de {0} e {1} é {2}", n1, n2, n1 / n2);
        }
    }
}
