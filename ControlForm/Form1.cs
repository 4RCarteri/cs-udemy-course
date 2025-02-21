using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControlForm
{
    public partial class Form1: Form
    {
        Label label1;
        Button btn1;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label1 = new Label();
            label1.Location = new Point(100, 50);
            label1.AutoSize = false;
            label1.Size = new Size(500, 200);
            label1.BackColor = Color.White;
            label1.ForeColor = Color.Black;
            label1.Font = new Font("Arial", 12);
            label1.Text = "Hello World!";

            btn1 = new Button();
            btn1.Location = new Point(250, 285);
            btn1.Size = new Size(200, 60);
            btn1.Text = "Click Me!";

            btn1.Click += btn1_Click;

            this.Controls.Add(label1);
            this.Controls.Add(btn1);


        }

        private void btn1_Click(object sender, EventArgs e)
        {
            label1.Text = "Hello C#";
        }

    }
}
