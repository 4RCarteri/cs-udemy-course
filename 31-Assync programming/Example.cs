using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _31_Assync_programming
{
    internal class Example
    {
        bool Task_TResult()
        {
            return DateTime.IsLeapYear(DateTime.Now.Year);
        }

        void Task_Void()
        {
            Task.Delay(2000);
            Form1.lstRes.Items.Add("Task_long_executed");
        }

        public void Task_long()
        {
            bool isLeapYear = Task_TResult();

            Form1.lstRes.Items.Add($"{DateTime.Now.Year} {(isLeapYear ? "is" : "is not")} a leap year");
            Task_Void();
        }
    }
}
