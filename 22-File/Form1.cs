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

            if (File.Exists(folder + file))
            {
                File.Move(folder + file, folder + "move.txt");
                lblResult.Text = "File moved";
            }

            lblResult.Text = File.GetCreationTime(folder + file).ToString();

            File.WriteAllText(folder + file, lblResult.Text);


            File.Delete(folder + file);
            File.Delete(folder + "copy.txt");
            File.Delete(folder + "move.txt");
            lblResult.Text = "File deleted";

        }

        private void btnFileInfo_Click(object sender, EventArgs e)
        {
            listInfo.Items.Clear();
            File.Create(@"C:\test.txt").Close();
            FileInfo fileInfo = new FileInfo(@"C:\test.txt");

            if (fileInfo.Exists)
            {
                listInfo.Items.Add("Full name: " + fileInfo.FullName);
                listInfo.Items.Add("Name: " + fileInfo.Name);
                listInfo.Items.Add("Extension: " + fileInfo.Extension);
                listInfo.Items.Add("Directory name: " + fileInfo.DirectoryName);
                listInfo.Items.Add("Length: " + fileInfo.Length);
                listInfo.Items.Add("Creation time: " + fileInfo.CreationTime);
                listInfo.Items.Add("Last access time: " + fileInfo.LastAccessTime);
                listInfo.Items.Add("Last write time: " + fileInfo.LastWriteTime);
            }
            else
            {
                listInfo.Items.Add("File does not exist");
            }
        }

        private void btnDir_Click(object sender, EventArgs e)
        {
            string path = @"C:\courseCS";

            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
                listDir.Items.Add("Directory created");
            }

            string[] dirs = Directory.GetDirectories(path);

            string[] files = Directory.GetFiles(path);

            Directory.Delete(path, true);

            string[] drives = Directory.GetLogicalDrives();
            listDir.Items.AddRange(drives);
        }
    }
}
