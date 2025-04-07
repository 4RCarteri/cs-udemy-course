using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _31_Assync_programming
{
    internal class ExampleAssync
    {
        async Task<bool> Task_TResultAsync()
        {
            return await Task.FromResult<bool>(DateTime.IsLeapYear(DateTime.Now.Year));
        }

        async Task Task_Void_Async()
        {
            await Task.Delay(2000);
            Form1.lstRes.Items.Add("Task_long_executed");
        }

        public async Task Task_longAsync()
        {
            bool isLeapYear = await Task_TResultAsync();

            Form1.lstRes.Items.Add($"{DateTime.Now.Year} {(isLeapYear ? "is" : "is not")} a leap year");
            Task_Void_Async();
        }
    }
}
