using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _31_CaptureKeys
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Select();
        }

        private void btnKeyX_Click(object sender, EventArgs e)
        {
            lblResult.Text = "Key X clicked";
        }

        private void btnKeyEnter_Click(object sender, EventArgs e)
        {
            lblResult.Text = "Key enter clicked";
        }

        private void form_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)97)
            {
                btnKeyEnter.PerformClick();
                lblResult.Text += " - Key a pressed";
            }
        }
    }
}
