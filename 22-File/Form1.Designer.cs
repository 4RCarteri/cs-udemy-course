namespace _22_File
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
            this.btnExecute = new System.Windows.Forms.Button();
            this.lblResult = new System.Windows.Forms.Label();
            this.btnFileInfo = new System.Windows.Forms.Button();
            this.listInfo = new System.Windows.Forms.ListBox();
            this.btnDir = new System.Windows.Forms.Button();
            this.listDir = new System.Windows.Forms.ListBox();
            this.btnDirInfo = new System.Windows.Forms.Button();
            this.listDirInfo = new System.Windows.Forms.ListBox();
            this.txtContent = new System.Windows.Forms.TextBox();
            this.btnWriteTxt = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.txtRead = new System.Windows.Forms.TextBox();
            this.bntBinRead = new System.Windows.Forms.Button();
            this.txtBinRead = new System.Windows.Forms.TextBox();
            this.txtWriteBinary = new System.Windows.Forms.TextBox();
            this.btnWriteBin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnExecute
            // 
            this.btnExecute.Location = new System.Drawing.Point(31, 383);
            this.btnExecute.Name = "btnExecute";
            this.btnExecute.Size = new System.Drawing.Size(75, 23);
            this.btnExecute.TabIndex = 0;
            this.btnExecute.Text = "File Execute";
            this.btnExecute.UseVisualStyleBackColor = true;
            this.btnExecute.Click += new System.EventHandler(this.btnExecute_Click);
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResult.Location = new System.Drawing.Point(25, 131);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(81, 29);
            this.lblResult.TabIndex = 1;
            this.lblResult.Text = "Result";
            // 
            // btnFileInfo
            // 
            this.btnFileInfo.Location = new System.Drawing.Point(177, 383);
            this.btnFileInfo.Name = "btnFileInfo";
            this.btnFileInfo.Size = new System.Drawing.Size(75, 23);
            this.btnFileInfo.TabIndex = 2;
            this.btnFileInfo.Text = "FileInfo Excecute";
            this.btnFileInfo.UseVisualStyleBackColor = true;
            this.btnFileInfo.Click += new System.EventHandler(this.btnFileInfo_Click);
            // 
            // listInfo
            // 
            this.listInfo.FormattingEnabled = true;
            this.listInfo.Location = new System.Drawing.Point(125, 131);
            this.listInfo.Name = "listInfo";
            this.listInfo.Size = new System.Drawing.Size(214, 199);
            this.listInfo.TabIndex = 3;
            // 
            // btnDir
            // 
            this.btnDir.Location = new System.Drawing.Point(396, 382);
            this.btnDir.Name = "btnDir";
            this.btnDir.Size = new System.Drawing.Size(75, 23);
            this.btnDir.TabIndex = 4;
            this.btnDir.Text = "Directory";
            this.btnDir.UseVisualStyleBackColor = true;
            this.btnDir.Click += new System.EventHandler(this.btnDir_Click);
            // 
            // listDir
            // 
            this.listDir.FormattingEnabled = true;
            this.listDir.Location = new System.Drawing.Point(368, 131);
            this.listDir.Name = "listDir";
            this.listDir.Size = new System.Drawing.Size(120, 95);
            this.listDir.TabIndex = 5;
            // 
            // btnDirInfo
            // 
            this.btnDirInfo.Location = new System.Drawing.Point(552, 382);
            this.btnDirInfo.Name = "btnDirInfo";
            this.btnDirInfo.Size = new System.Drawing.Size(75, 23);
            this.btnDirInfo.TabIndex = 6;
            this.btnDirInfo.Text = "Directory Info";
            this.btnDirInfo.UseVisualStyleBackColor = true;
            this.btnDirInfo.Click += new System.EventHandler(this.btnDirInfo_Click);
            // 
            // listDirInfo
            // 
            this.listDirInfo.FormattingEnabled = true;
            this.listDirInfo.Location = new System.Drawing.Point(507, 131);
            this.listDirInfo.Name = "listDirInfo";
            this.listDirInfo.Size = new System.Drawing.Size(109, 95);
            this.listDirInfo.TabIndex = 7;
            // 
            // txtContent
            // 
            this.txtContent.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContent.Location = new System.Drawing.Point(622, 131);
            this.txtContent.Multiline = true;
            this.txtContent.Name = "txtContent";
            this.txtContent.Size = new System.Drawing.Size(166, 85);
            this.txtContent.TabIndex = 8;
            // 
            // btnWriteTxt
            // 
            this.btnWriteTxt.Location = new System.Drawing.Point(680, 383);
            this.btnWriteTxt.Name = "btnWriteTxt";
            this.btnWriteTxt.Size = new System.Drawing.Size(75, 23);
            this.btnWriteTxt.TabIndex = 9;
            this.btnWriteTxt.Text = "Write txt";
            this.btnWriteTxt.UseVisualStyleBackColor = true;
            this.btnWriteTxt.Click += new System.EventHandler(this.btnWriteTxt_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(844, 382);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "Read txt";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtRead
            // 
            this.txtRead.Location = new System.Drawing.Point(810, 139);
            this.txtRead.Multiline = true;
            this.txtRead.Name = "txtRead";
            this.txtRead.Size = new System.Drawing.Size(109, 87);
            this.txtRead.TabIndex = 11;
            // 
            // bntBinRead
            // 
            this.bntBinRead.Location = new System.Drawing.Point(958, 381);
            this.bntBinRead.Name = "bntBinRead";
            this.bntBinRead.Size = new System.Drawing.Size(75, 23);
            this.bntBinRead.TabIndex = 12;
            this.bntBinRead.Text = "Read binary";
            this.bntBinRead.UseVisualStyleBackColor = true;
            this.bntBinRead.Click += new System.EventHandler(this.bntBinRead_Click);
            // 
            // txtBinRead
            // 
            this.txtBinRead.Location = new System.Drawing.Point(939, 139);
            this.txtBinRead.Name = "txtBinRead";
            this.txtBinRead.Size = new System.Drawing.Size(100, 20);
            this.txtBinRead.TabIndex = 13;
            // 
            // txtWriteBinary
            // 
            this.txtWriteBinary.Location = new System.Drawing.Point(1046, 139);
            this.txtWriteBinary.Multiline = true;
            this.txtWriteBinary.Name = "txtWriteBinary";
            this.txtWriteBinary.Size = new System.Drawing.Size(100, 20);
            this.txtWriteBinary.TabIndex = 14;
            // 
            // btnWriteBin
            // 
            this.btnWriteBin.Location = new System.Drawing.Point(1078, 381);
            this.btnWriteBin.Name = "btnWriteBin";
            this.btnWriteBin.Size = new System.Drawing.Size(75, 23);
            this.btnWriteBin.TabIndex = 15;
            this.btnWriteBin.Text = "Write binary";
            this.btnWriteBin.UseVisualStyleBackColor = true;
            this.btnWriteBin.Click += new System.EventHandler(this.btnWriteBin_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1217, 450);
            this.Controls.Add(this.btnWriteBin);
            this.Controls.Add(this.txtWriteBinary);
            this.Controls.Add(this.txtBinRead);
            this.Controls.Add(this.bntBinRead);
            this.Controls.Add(this.txtRead);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnWriteTxt);
            this.Controls.Add(this.txtContent);
            this.Controls.Add(this.listDirInfo);
            this.Controls.Add(this.btnDirInfo);
            this.Controls.Add(this.listDir);
            this.Controls.Add(this.btnDir);
            this.Controls.Add(this.listInfo);
            this.Controls.Add(this.btnFileInfo);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.btnExecute);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnExecute;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Button btnFileInfo;
        private System.Windows.Forms.ListBox listInfo;
        private System.Windows.Forms.Button btnDir;
        private System.Windows.Forms.ListBox listDir;
        private System.Windows.Forms.Button btnDirInfo;
        private System.Windows.Forms.ListBox listDirInfo;
        private System.Windows.Forms.TextBox txtContent;
        private System.Windows.Forms.Button btnWriteTxt;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtRead;
        private System.Windows.Forms.Button bntBinRead;
        private System.Windows.Forms.TextBox txtBinRead;
        private System.Windows.Forms.TextBox txtWriteBinary;
        private System.Windows.Forms.Button btnWriteBin;
    }
}

