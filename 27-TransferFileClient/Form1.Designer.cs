namespace _27_TransferFileClient
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnSend = new System.Windows.Forms.Button();
            this.inkFile = new System.Windows.Forms.LinkLabel();
            this.txtIP = new System.Windows.Forms.TextBox();
            this.numPort = new System.Windows.Forms.NumericUpDown();
            this.lblStatus = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numPort)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(31, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(287, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Transfer File Client";
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(38, 188);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(75, 23);
            this.btnSend.TabIndex = 1;
            this.btnSend.Text = "Send File";
            this.btnSend.UseVisualStyleBackColor = true;
            // 
            // inkFile
            // 
            this.inkFile.AutoSize = true;
            this.inkFile.Location = new System.Drawing.Point(35, 151);
            this.inkFile.Name = "inkFile";
            this.inkFile.Size = new System.Drawing.Size(59, 13);
            this.inkFile.TabIndex = 2;
            this.inkFile.TabStop = true;
            this.inkFile.Text = "Choose file";
            // 
            // txtIP
            // 
            this.txtIP.Location = new System.Drawing.Point(38, 103);
            this.txtIP.Name = "txtIP";
            this.txtIP.Size = new System.Drawing.Size(100, 20);
            this.txtIP.TabIndex = 3;
            this.txtIP.Text = "127.0.0.1";
            // 
            // numPort
            // 
            this.numPort.Location = new System.Drawing.Point(171, 103);
            this.numPort.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.numPort.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numPort.Name = "numPort";
            this.numPort.Size = new System.Drawing.Size(67, 20);
            this.numPort.TabIndex = 4;
            this.numPort.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            // 
            // lblStatus
            // 
            this.lblStatus.Location = new System.Drawing.Point(12, 214);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(392, 97);
            this.lblStatus.TabIndex = 5;
            this.lblStatus.Text = "Status";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(416, 320);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.numPort);
            this.Controls.Add(this.txtIP);
            this.Controls.Add(this.inkFile);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.numPort)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.LinkLabel inkFile;
        private System.Windows.Forms.TextBox txtIP;
        private System.Windows.Forms.NumericUpDown numPort;
        private System.Windows.Forms.Label lblStatus;
    }
}

