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

            //Task.Factory.StartNew(Task1);

            //Task.Run(() =>
            //{
            //    for (int i = 0; i < 10; i++)
            //    {
            //        Console.WriteLine("Lambda task: " + i);
            //        System.Threading.Thread.Sleep(500);
            //    }
            //});

            //for (int i = 0; i < 10; i++)
            //{
            //    Console.WriteLine("Main: " + i);
            //    System.Threading.Thread.Sleep(200);
            //}
            #endregion

            #region Task part 2
            //Task[] tasks =
            //{
            //    Task.Factory.StartNew(() =>
            //    {
            //       Console.WriteLine("Task 1: ");
            //    }),
            //    Task.Factory.StartNew(() =>
            //    { 
            //        Console.WriteLine("Task 2: ");
            //    }),
            //    Task.Factory.StartNew(() =>
            //    { 
            //        Console.WriteLine("Task 3: ");
            //    }),
            //};

            //Task.WaitAll(tasks);

            //Console.WriteLine("Main thread is finished");
            #endregion

            #region Task part 3
            Task<int> task = Task.Factory.StartNew(() => { return 5; });
            Console.WriteLine(task.Result);

            Task<int> task1 = Task.Factory.StartNew(() =>
            {
                return new Random().Next(10);
            });

            Task<int> task2 = task1.ContinueWith((t) =>
            {
                return t.Result * 2;
            });

            Task<string> task3 = task2.ContinueWith((t) =>
            {
                return t.Result.ToString();
            });

            Console.WriteLine(task3.Result);
            #endregion
        }

        static int Double(int value)
        {
            return value * 2;
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
