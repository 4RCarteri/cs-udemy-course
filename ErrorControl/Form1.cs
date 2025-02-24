using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ErrorControl
{
    public partial class Form1: Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int[] num = { 1, 2, 3, 4, 5 };

            string res = "";

            try
            {
                for (int i = 0; i <= 5; i++)
                {
                    res += num[i] + " ";
                }

                label1.Text = res;
            }
            catch (IndexOutOfRangeException ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                MessageBox.Show("The 'try catch' is finished", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }
    }
}
