using System;
using System.Threading;
using System.Windows.Forms;

namespace _19_FormDetails
{
    public partial class SecondForm : Form
    {
        public string Message { get; set; }

        public SecondForm()
        {
            InitializeComponent();
        }
        public SecondForm(string message)
        {
            InitializeComponent();
            this.Message = message;
        }

        private void btnMain_Click(object sender, EventArgs e)
        {
            Close();
            new Thread(() => Application.Run(new MainForm())).Start();
        }

        private void SecondForm_Load(object sender, EventArgs e)
        {
            txtMessage.Text = Message;
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            if (txtMessage.Text == "" || txtMessage.Text == null)
            {
                Message = null;
            }
            else
            {
                Message = txtMessage.Text;
            }
            Close();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Message = null;
            Close();
        }
    }
}
