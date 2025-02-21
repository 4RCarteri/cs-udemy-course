using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _19_FormDetails
{
    public partial class MainForm : Form
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
            // Hide() method is used to hide the current form
            Hide();

            SecondForm secondForm = new SecondForm();
            secondForm.Message = "Ricardo";

            // Show() method is used to display a non-modal dialog box
            //secondForm.Show();

            // ShowDialog() method is used to display a modal dialog box
            secondForm.ShowDialog();

            if (secondForm.Message != null)
            {
                lblMain.Text = secondForm.Message;
            }

            // When the second form is closed, the current form will be displayed
            Show();
        }

        private void btnSecondFromThread_Click(object sender, EventArgs e)
        {
            Close();
            Thread t = new Thread(() => Application.Run(new SecondForm()));
            t.Start();
        }

        private void mFileNew_Click(object sender, EventArgs e)
        {
            new Thread(() => Application.Run(new MainForm())).Start();
        }

        private void mFileOpen_Click(object sender, EventArgs e)
        {
            Hide();
            new SecondForm().ShowDialog();
            Show();
        }

        private void mFileExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void mHelpAboutDev_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Developed by Ricardo", "About Developer", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void mHelpAboutVersion_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Version 1.0", "About Version", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void menuComb_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (menuComb.SelectedIndex == 0)
            {
                menuFile.Text = "File";
                menuHelp.Text = "Help";
            }
            else
            {
                menuFile.Text = "Arquivo";
                menuHelp.Text = "Ajuda";
            }
        }

        private void mSearch_KeyUp(object sender, KeyEventArgs e)
        {
            if ((e.KeyCode == Keys.Enter) && (mSearch.Text != ""))
            {
                lblMain.Text = mSearch.Text;
                mSearch.Text = "";
            }
        }
    }
}