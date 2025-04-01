using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _29_data_encryption
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnEncript_Click(object sender, EventArgs e)
        {
            EncriptMD5 md5 = new EncriptMD5();
            txtOutput.Text = md5.GetMd5Hash(txtInput.Text);
        }

        private void btnCompare_Click(object sender, EventArgs e)
        {
            string dbPassword = "81DC9BDB52D04DC20036DBD8313ED055"; // 1234
            string password = txtInput.Text;

            EncriptMD5 md5 = new EncriptMD5();

            lblResult.Text = md5.VerifyMd5Hash(password, dbPassword) ? "Password is correct" : "Password is incorrect";
        }
    }
}
