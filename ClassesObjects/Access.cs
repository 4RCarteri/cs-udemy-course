using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesObjects
{
    internal class Access
    {
        string password = "1234";

        public bool login(string password)
        {
            return this.password == password ? true : false;
        }
    }
}
