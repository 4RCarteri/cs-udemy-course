using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _25_GDI_
{
    public partial class Form1: Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Draw_Click(object sender, EventArgs e)
        {
            // Create a blank bitmap
            Bitmap sheet = new Bitmap(pictureBox1.Width, pictureBox1.Height);

            // Create a graphics object from the bitmap
            Graphics g = Graphics.FromImage(sheet);

            g.Clear(Color.White);

            pictureBox1.BackgroundImage = sheet;

            // Save the image in the root directory of the project
            string filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "sheet.jpg");
            sheet.Save(filePath, System.Drawing.Imaging.ImageFormat.Jpeg);
        }
    }
}
