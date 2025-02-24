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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
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
    }
}

