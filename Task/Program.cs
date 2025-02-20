using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tasks
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Task part 1
            //Task task = new Task(Task1);
            //task.Start();

            //Task.Run(Task1);

            Task.Factory.StartNew(Task1);

            Task.Run(() =>
            {
                for (int i = 0; i < 10; i++)
                {
                    Console.WriteLine("Lambda task: " + i);
                    System.Threading.Thread.Sleep(500);
                }
            });

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Main: " + i);
                System.Threading.Thread.Sleep(200);
            }
            #endregion


        }

        static private void Task1()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Task: " + i);
                System.Threading.Thread.Sleep(500);
            }
        }
    }
}
