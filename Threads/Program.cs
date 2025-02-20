using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Threads
{
    class Program
    {
        static void Main(string[] args)
        {
            Thread thread = new Thread(new ThreadStart(Task));
            // IsBackground = true means that the thread will be terminated when the main thread is terminated
            thread.IsBackground = true;
            thread.Start();
            // Join() method will wait for the thread to finish
            thread.Join();


            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Main: " + i);
                Thread.Sleep(200);
            }

        }
        static void Task()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Task: " + i);
                Thread.Sleep(500);
            }
        }
    }
}
