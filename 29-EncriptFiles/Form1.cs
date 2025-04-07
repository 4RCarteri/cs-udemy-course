using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Security.Cryptography;

namespace _29_EncriptFiles
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Encryption.cspp = new CspParameters();
            Encryption.EncrFolder = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + @"\encryption\Encrypt\";
            Encryption.DecrFolder = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + @"\encryption\Decrypt\";
            Encryption.SrcFolder = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + @"\encryption\Decrypt\";
        }

        private void btnEncriptFile_Click(object sender, EventArgs e)
        {
            if(Encryption.rsa == null)
            {
                lblMessage.ForeColor = Color.Red;
                lblMessage.Text = "Key not defined.";
            }
            else
            {
                OpenFileDialog dialog = new OpenFileDialog();
                dialog.InitialDirectory = Encryption.SrcFolder;
                if(dialog.ShowDialog() == DialogResult.OK)
                {
                    string fName = dialog.FileName;
                    FileInfo fInfo = new FileInfo(fName);
                    string name = fInfo.FullName;
                    lblMessage.Text = Encryption.EncryptFile(name);
                }
            }
        }

        private void btnDecriptFile_Click(object sender, EventArgs e)
        {
            if (Encryption.rsa == null)
            {
                lblMessage.ForeColor = Color.Red;
                lblMessage.Text = "Key not defined.";
            }
            else
            {
                OpenFileDialog dialog = new OpenFileDialog();
                dialog.InitialDirectory = Encryption.SrcFolder;
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    string fName = dialog.FileName;
                    FileInfo fInfo = new FileInfo(fName);
                    string name = fInfo.Name;
                    lblMessage.Text = Encryption.DecryptFile(name);
                }
            }
        }

        private void btnCreateAsmKey_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtKey.Text))
            {
                lblMessage.ForeColor = Color.Red;
                lblMessage.Text = "Insert a value to define the public key";
                txtKey.Focus();
                return;
            }

            Encryption.keyName = txtKey.Text;
            lblMessage.ForeColor = Color.DarkBlue;
            lblMessage.Text = Encryption.CreateAsmKeys();
        }

        private void btnExportPublicKey_Click(object sender, EventArgs e)
        {
            if (Encryption.ExportPublicKey())
            {
                lblMessage.ForeColor = Color.DarkBlue;
                lblMessage.Text = "Public Key exported";
            }
            else
            {
                lblMessage.ForeColor= Color.Red;
                lblMessage.Text = "Public key not exported";
            }
        }

        private void btnImportPublicKey_Click(object sender, EventArgs e)
        {
            Encryption.keyName = "Public";
            lblMessage.ForeColor = Color.DarkBlue;
            lblMessage.Text = Encryption.ImportPublicKey();
        }

        private void btnGetPrivateKey_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtKey.Text))
            {
                lblMessage.ForeColor = Color.Red;
                lblMessage.Text = "Insert the private key";
                txtKey.Focus();
                return;
            }
            Encryption.keyName = txtKey.Text;
            lblMessage.ForeColor = Color.DarkBlue;
            lblMessage.Text = Encryption.GetPrivateKey();
        }
    }
}
