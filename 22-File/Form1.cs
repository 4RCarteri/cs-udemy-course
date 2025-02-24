using System;
using System.IO;
using System.Windows.Forms;

namespace _22_File
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnExecute_Click(object sender, EventArgs e)
        {
            string folder = @"C:\";
            string file = "test.txt";

            if (!File.Exists(folder + file))
            {
                File.Create(folder + file).Close();
                lblResult.Text = "File created";
            }
            else
            {
                lblResult.Text = "File already exists";
            }

            if (File.Exists(folder + file))
            {
                File.Copy(folder + file, folder + "copy.txt", true);
                lblResult.Text = "File copied";
            }
            else
            {
                lblResult.Text = "File does not exist";
            }

            File.Move(folder + file, folder + "move.txt");
            lblResult.Text = "File moved";

            lblResult.Text = File.GetCreationTime(folder + file).ToString();

            File.WriteAllText(folder + file, lblResult.Text);


            File.Delete(folder + file);
            File.Delete(folder + "copy.txt");
            File.Delete(folder + "move.txt");
            lblResult.Text = "File deleted";

        }
    }
}
