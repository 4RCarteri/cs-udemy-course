﻿using System;
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

        private void btnDirInfo_Click(object sender, EventArgs e)
        {
            DirectoryInfo directoryInfo = new DirectoryInfo(@"C:\courseCS");

            if (!directoryInfo.Exists)
            {
                directoryInfo.Create();
            }

            listDirInfo.Items.Add("Full name: " + directoryInfo.FullName);
            listDirInfo.Items.Add("Name: " + directoryInfo.Name);
            listDirInfo.Items.Add("Parent: " + directoryInfo.Parent);
            listDirInfo.Items.Add("Root: " + directoryInfo.Root);
            listDirInfo.Items.Add("Creation time: " + directoryInfo.CreationTime);
            listDirInfo.Items.Add("Last access time: " + directoryInfo.LastAccessTime);

            directoryInfo.Delete();

        }

        private void btnWriteTxt_Click(object sender, EventArgs e)
        {
            StreamWriter sw = new StreamWriter(@"C:\test.txt");

            // The difference between WriteLine and Write is that WriteLine adds a new line
            sw.WriteLine(txtContent.Text);

            sw.Write(txtContent.Text);

            // Flush: clear the buffer
            sw.Flush();

            // Dispose: close the file
            sw.Dispose();
            sw.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string path = @"C:\teste.txt";
            File.Create(path).Close();
            StreamWriter sw = new StreamWriter(path);

            sw.WriteLine("The difference between WriteLine and Write is that WriteLine adds a new line");
            sw.Close();

            StreamReader sr = new StreamReader(path);
            txtRead.Text = sr.ReadToEnd();
            txtRead.Text = sr.ReadLine();

            sr.Close();
            File.Delete(path);
        }

        private void bntBinRead_Click(object sender, EventArgs e)
        {
            string path = @"C:\teste.txt";
            File.Create(path).Close();
            StreamWriter sw = new StreamWriter(path);

            sw.WriteLine("The difference between WriteLine and Write is that WriteLine adds a new line");
            sw.Close();

            BinaryReader br = new BinaryReader(File.OpenRead(path));

            while(br.BaseStream.Position < br.BaseStream.Length)
            {
                txtBinRead.Text += br.ReadByte().ToString() + " ";
            }



            br.Close();
            byte[] buffer = File.ReadAllBytes(path);
        }

        private void btnWriteBin_Click(object sender, EventArgs e)
        {
            string path = @"C:\teste.txt";
            File.Create(path).Close();
            StreamWriter sw = new StreamWriter(path);

            sw.WriteLine("The difference between WriteLine and Write is that WriteLine adds a new line");
            sw.Close();

            BinaryWriter bw = new BinaryWriter(File.OpenWrite(path));

            bw.Write("Hello");

            bw.Close();

        }
    }
}
