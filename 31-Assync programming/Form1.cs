using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _31_Assync_programming
{
    public partial class Form1 : Form
    {
        public static ListBox lstRes;
        public Form1()
        {
            InitializeComponent();
            lstRes = listResult;
        }

        private void btnRun_Click(object sender, EventArgs e)
        {
            listResult.Items.Add("Button event started: click here");

            Example obj = new Example();
            obj.Task_long();

            listResult.Items.Add("Button event finished");
        }

        private async void btnExecAssync_Click(object sender, EventArgs e)
        {
            listResult.Items.Add("Button event started: click here");
            ExampleAssync obj = new ExampleAssync();
            obj.Task_longAsync();
            listResult.Items.Add("Button event finished");

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            listResult.Items.Clear();
        }
    }
}
