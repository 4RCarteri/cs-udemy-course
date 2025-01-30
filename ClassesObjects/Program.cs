using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesObjects
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Classes an objects
            MyClass mClass = new MyClass();
            OtherClass otherClass = new OtherClass();
            OtherClass other2 = otherClass;
            #endregion

            #region Person
            Person person = new Person();
            person.name = "John";
            person.surname = "Doe";
            person.yearBirth = 1980;

            Person person2 = new Person()
            {
                name = "Jane",
                surname = "Doe",
                yearBirth = 1985
            };

            Console.WriteLine("Person 1: {0} {1} {2}", person.name, person.surname, person.yearBirth);
            person.Greet();
            person2.Greet();
            #endregion

            #region Methods with params
            Methods methods = new Methods();
            methods.Greet();
            methods.Sum(5, 10);
            #endregion
        }
    }

    class MyClass 
    { 
    
    }


}
