using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesObjects
{
    internal class Program
    {
        delegate void Operaction(int n1, int n2);

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

            #region Methods with reference
            int value = 10;
            methods.SumValue(value);
            Console.WriteLine("Value: {0}", value);

            methods.Sum10(ref value);
            Console.WriteLine("Value: {0}", value);
            #endregion

            #region Methods overloading
            int n = methods.Sum(5, 10, 15);
            int n3 = methods.Sum(5, 10);

            Console.WriteLine("Sum 3: {0}", n3);
            Console.WriteLine("Sum 2: {0}", n);
            #endregion

            #region Delegate
            Console.WriteLine("Delegate");
            Delegate @delegate = new Delegate();

            Operaction operaction = null;
            operaction += @delegate.Sum;
            operaction += @delegate.Multiply;
            operaction += @delegate.Divide;
            operaction += @delegate.Subtract;

            operaction(2,2);

            operaction -= @delegate.Subtract;
            operaction(2, 2);
            #endregion
        }
    }

    class MyClass 
    { 
    
    }


}
