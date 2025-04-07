namespace _29_EncriptFiles
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblMessage = new System.Windows.Forms.Label();
            this.txtKey = new System.Windows.Forms.TextBox();
            this.btnEncriptFile = new System.Windows.Forms.Button();
            this.btnDecriptFile = new System.Windows.Forms.Button();
            this.btnCreateAsmKey = new System.Windows.Forms.Button();
            this.btnGetPrivateKey = new System.Windows.Forms.Button();
            this.btnImportPublicKey = new System.Windows.Forms.Button();
            this.btnExportPublicKey = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblMessage
            // 
            this.lblMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMessage.Location = new System.Drawing.Point(33, 23);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(363, 82);
            this.lblMessage.TabIndex = 0;
            this.lblMessage.Text = "Key not defined";
            this.lblMessage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtKey
            // 
            this.txtKey.Location = new System.Drawing.Point(29, 129);
            this.txtKey.Name = "txtKey";
            this.txtKey.Size = new System.Drawing.Size(367, 20);
            this.txtKey.TabIndex = 1;
            // 
            // btnEncriptFile
            // 
            this.btnEncriptFile.Location = new System.Drawing.Point(12, 180);
            this.btnEncriptFile.Name = "btnEncriptFile";
            this.btnEncriptFile.Size = new System.Drawing.Size(75, 23);
            this.btnEncriptFile.TabIndex = 2;
            this.btnEncriptFile.Text = "Encript file";
            this.btnEncriptFile.UseVisualStyleBackColor = true;
            this.btnEncriptFile.Click += new System.EventHandler(this.btnEncriptFile_Click);
            // 
            // btnDecriptFile
            // 
            this.btnDecriptFile.Location = new System.Drawing.Point(186, 180);
            this.btnDecriptFile.Name = "btnDecriptFile";
            this.btnDecriptFile.Size = new System.Drawing.Size(75, 23);
            this.btnDecriptFile.TabIndex = 3;
            this.btnDecriptFile.Text = "Decript file";
            this.btnDecriptFile.UseVisualStyleBackColor = true;
            this.btnDecriptFile.Click += new System.EventHandler(this.btnDecriptFile_Click);
            // 
            // btnCreateAsmKey
            // 
            this.btnCreateAsmKey.Location = new System.Drawing.Point(378, 180);
            this.btnCreateAsmKey.Name = "btnCreateAsmKey";
            this.btnCreateAsmKey.Size = new System.Drawing.Size(75, 23);
            this.btnCreateAsmKey.TabIndex = 4;
            this.btnCreateAsmKey.Text = "Create keys";
            this.btnCreateAsmKey.UseVisualStyleBackColor = true;
            this.btnCreateAsmKey.Click += new System.EventHandler(this.btnCreateAsmKey_Click);
            // 
            // btnGetPrivateKey
            // 
            this.btnGetPrivateKey.Location = new System.Drawing.Point(359, 209);
            this.btnGetPrivateKey.Name = "btnGetPrivateKey";
            this.btnGetPrivateKey.Size = new System.Drawing.Size(111, 23);
            this.btnGetPrivateKey.TabIndex = 5;
            this.btnGetPrivateKey.Text = "Get private key";
            this.btnGetPrivateKey.UseVisualStyleBackColor = true;
            this.btnGetPrivateKey.Click += new System.EventHandler(this.btnGetPrivateKey_Click);
            // 
            // btnImportPublicKey
            // 
            this.btnImportPublicKey.Location = new System.Drawing.Point(176, 209);
            this.btnImportPublicKey.Name = "btnImportPublicKey";
            this.btnImportPublicKey.Size = new System.Drawing.Size(103, 23);
            this.btnImportPublicKey.TabIndex = 6;
            this.btnImportPublicKey.Text = "Import public key";
            this.btnImportPublicKey.UseVisualStyleBackColor = true;
            this.btnImportPublicKey.Click += new System.EventHandler(this.btnImportPublicKey_Click);
            // 
            // btnExportPublicKey
            // 
            this.btnExportPublicKey.Location = new System.Drawing.Point(12, 214);
            this.btnExportPublicKey.Name = "btnExportPublicKey";
            this.btnExportPublicKey.Size = new System.Drawing.Size(117, 23);
            this.btnExportPublicKey.TabIndex = 7;
            this.btnExportPublicKey.Text = "Export public key";
            this.btnExportPublicKey.UseVisualStyleBackColor = true;
            this.btnExportPublicKey.Click += new System.EventHandler(this.btnExportPublicKey_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(482, 266);
            this.Controls.Add(this.btnExportPublicKey);
            this.Controls.Add(this.btnImportPublicKey);
            this.Controls.Add(this.btnGetPrivateKey);
            this.Controls.Add(this.btnCreateAsmKey);
            this.Controls.Add(this.btnDecriptFile);
            this.Controls.Add(this.btnEncriptFile);
            this.Controls.Add(this.txtKey);
            this.Controls.Add(this.lblMessage);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.TextBox txtKey;
        private System.Windows.Forms.Button btnEncriptFile;
        private System.Windows.Forms.Button btnDecriptFile;
        private System.Windows.Forms.Button btnCreateAsmKey;
        private System.Windows.Forms.Button btnGetPrivateKey;
        private System.Windows.Forms.Button btnImportPublicKey;
        private System.Windows.Forms.Button btnExportPublicKey;
    }
}

