using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImportantClasses
{
    public partial class Form1: Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Hello World");
            //MessageBox.Show("Message to show", "Message title");
            DialogResult dialogResult = MessageBox.Show("Message to show", "Message title", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
            lblResult.Text = dialogResult.ToString();
        }

        private void btnRandom_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            Random random1 = new Random(DateTime.Now.Millisecond);

            int value = random.Next(1, 100);
            double v = random1.NextDouble();

            lblResult.Text = v.ToString();
        }

        private void btnTimeSpan_Click(object sender, EventArgs e)
        {
            TimeSpan timeSpan = TimeSpan.FromMinutes(30);
            lblResult.Text = timeSpan.ToString();

            lblResult.Text = TimeSpan.TicksPerMinute.ToString();

            TimeSpan begin = new TimeSpan(1, 2, 0);
            TimeSpan end = new TimeSpan(2, 3, 0);
            TimeSpan interval = end - begin;

            TimeSpan timeSpan1 = begin.Add(end);

            lblResult.Text = interval.TotalHours.ToString();
        }

        private void btnDateTime_Click(object sender, EventArgs e)
        {
            lblResult.Text = DateTime.Now.ToString();
            lblResult.Text = DateTime.Today.ToString();
            lblResult.Text = DateTime.DaysInMonth(2021, 2).ToString();
            lblResult.Text = DateTime.IsLeapYear(2021).ToString();
            lblResult.Text = DateTime.Now.ToLongDateString();
            lblResult.Text = DateTime.Now.ToShortDateString();
            lblResult.Text = DateTime.Now.ToLongTimeString();
            lblResult.Text = DateTime.Now.ToShortTimeString();
            lblResult.Text = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");

            DateTime dateTime = new DateTime(2021, 2, 1);
            lblResult.Text = dateTime.ToString();
            TimeSpan timeSpan = new TimeSpan(1, 2, 3,5,8);
            lbl2.Text = dateTime.Add(timeSpan).ToString();

            lblResult.Text = dateTime.DayOfWeek.ToString();
            lblResult.Text = dateTime.DayOfYear.ToString();
        }

        private void btnColor_Click(object sender, EventArgs e)
        {
            lblResult.BackColor = Color.DarkGreen;
            lblResult.ForeColor = Color.FromArgb(120, 255, 255, 255);
            lblResult.ForeColor = Color.FromArgb(100, Color.Red);
            lblResult.ForeColor = Color.FromKnownColor(KnownColor.Control);
            lblResult.ForeColor = Color.FromName("Red");

            btnColor.ForeColor = lblResult.ForeColor;
        }
    }
}
