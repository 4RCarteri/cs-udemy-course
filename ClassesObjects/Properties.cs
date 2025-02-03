using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesObjects
{
    internal class Properties
    {
        private string _nome;
        private string Surname { get; set; }
        private int _age;

        public string Name
        {
            get { return _nome; }
            set { _nome = value; }
        }

        public int Age
        {
            get { return _age; }
            set
            {
                if (value < 18)
                {
                    throw new ArgumentException("Age cannot be less tahn 18");
                }
                _age = value;
            }
        }
        public void Introduce()
        {

        }
    }
}
