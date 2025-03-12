using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using _28_Operations;

namespace _28_Matematica
{
    public partial class Form1: Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            _28_Operations.Mathematics.Value1 = 1;
            _28_Operations.Mathematics.Value2 = 2;

            listBox1.Items.Add("Sum: " + _28_Operations.Mathematics.Sum());
            listBox1.Items.Add("Subtraction: " + _28_Operations.Mathematics.Subtraction());
        }
    }
}
