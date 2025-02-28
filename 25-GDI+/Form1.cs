using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace _25_GDI_
{
    public partial class Form1 : Form
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

            #region row
            // Create a pen
            Pen pen = new Pen(Color.Black, 5);
            
            Brush brush = new SolidBrush(Color.Black);
            Pen pen1 = new Pen(brush, 10);

            // Create a point
            Point point1 = new Point(100, 0);
            Point point2 = new Point(300, 500);
            
            //g.DrawLine(pen, point1, point2);
            //g.DrawLine(pen1, 200, 250, 300, 400);

            #endregion

            #region rows
            Point[] points = {
                new Point(100, 100),
                new Point(200, 200),
                new Point(300, 100),
                new Point(400, 200),
                new Point(500, 100)
            };

            g.DrawLines(pen, points);
            #endregion

            pictureBox1.BackgroundImage = sheet;

            // Save the image in the root directory of the project
            string filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "sheet.jpg");
            sheet.Save(filePath, System.Drawing.Imaging.ImageFormat.Jpeg);
        }
    }
}
