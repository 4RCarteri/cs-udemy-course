using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _19_FormDetails
{
    public partial class MainForm: Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void btnSecond_Click(object sender, EventArgs e)
        {
            SecondForm secondForm = new SecondForm();

            // Hide() method is used to hide the current form
            Hide();

            // Show() method is used to display a non-modal dialog box
            //secondForm.Show();

            // ShowDialog() method is used to display a modal dialog box
            secondForm.ShowDialog();

            // When the second form is closed, the current form will be displayed
            Show();
        }
    }
}
