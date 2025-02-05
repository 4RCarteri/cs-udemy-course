using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoginSystem
{
    public partial class FormLogin : Form
    {
        public static bool Cancel = false;
        
        public FormLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (UserRegister.Login(txtUsername.Text, txtPassword.Text))
            {
                MessageBox.Show("Login successful!");
                this.Close();
            }
            else
            {
                MessageBox.Show("Login failed!");
                txtUsername.Text = "";
                txtPassword.Text = "";
                txtUsername.Focus();
                Close();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Cancel = true;
            Close();
        }
    }
}
