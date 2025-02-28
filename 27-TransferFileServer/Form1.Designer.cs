namespace _27_TransferFileServer
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
            this.logsList = new System.Windows.Forms.ListBox();
            this.linkFolder = new System.Windows.Forms.LinkLabel();
            this.connectServer = new System.Windows.Forms.Button();
            this.stopServer = new System.Windows.Forms.Button();
            this.inputPort = new System.Windows.Forms.NumericUpDown();
            this.txtBoxIP = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.inputPort)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(54, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(298, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Transfer File Server";
            // 
            // logsList
            // 
            this.logsList.FormattingEnabled = true;
            this.logsList.Location = new System.Drawing.Point(12, 242);
            this.logsList.Name = "logsList";
            this.logsList.Size = new System.Drawing.Size(430, 186);
            this.logsList.TabIndex = 1;
            // 
            // linkFolder
            // 
            this.linkFolder.AutoSize = true;
            this.linkFolder.Location = new System.Drawing.Point(12, 206);
            this.linkFolder.Name = "linkFolder";
            this.linkFolder.Size = new System.Drawing.Size(66, 13);
            this.linkFolder.TabIndex = 2;
            this.linkFolder.TabStop = true;
            this.linkFolder.Text = "Select folder";
            this.linkFolder.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkFolder_LinkClicked);
            // 
            // connectServer
            // 
            this.connectServer.Location = new System.Drawing.Point(15, 149);
            this.connectServer.Name = "connectServer";
            this.connectServer.Size = new System.Drawing.Size(205, 37);
            this.connectServer.TabIndex = 3;
            this.connectServer.Text = "Connect Server";
            this.connectServer.UseVisualStyleBackColor = true;
            this.connectServer.Click += new System.EventHandler(this.connectServer_Click);
            // 
            // stopServer
            // 
            this.stopServer.Location = new System.Drawing.Point(243, 149);
            this.stopServer.Name = "stopServer";
            this.stopServer.Size = new System.Drawing.Size(199, 37);
            this.stopServer.TabIndex = 4;
            this.stopServer.Text = "Stop Server";
            this.stopServer.UseVisualStyleBackColor = true;
            this.stopServer.Click += new System.EventHandler(this.stopServer_Click);
            // 
            // inputPort
            // 
            this.inputPort.Location = new System.Drawing.Point(132, 104);
            this.inputPort.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.inputPort.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.inputPort.Name = "inputPort";
            this.inputPort.Size = new System.Drawing.Size(51, 20);
            this.inputPort.TabIndex = 5;
            this.inputPort.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            // 
            // txtBoxIP
            // 
            this.txtBoxIP.Location = new System.Drawing.Point(15, 104);
            this.txtBoxIP.Name = "txtBoxIP";
            this.txtBoxIP.Size = new System.Drawing.Size(100, 20);
            this.txtBoxIP.TabIndex = 6;
            this.txtBoxIP.Text = "127.0.0.1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 450);
            this.Controls.Add(this.txtBoxIP);
            this.Controls.Add(this.inputPort);
            this.Controls.Add(this.stopServer);
            this.Controls.Add(this.connectServer);
            this.Controls.Add(this.linkFolder);
            this.Controls.Add(this.logsList);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.inputPort)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox logsList;
        private System.Windows.Forms.LinkLabel linkFolder;
        private System.Windows.Forms.Button connectServer;
        private System.Windows.Forms.Button stopServer;
        private System.Windows.Forms.NumericUpDown inputPort;
        private System.Windows.Forms.TextBox txtBoxIP;
    }
}

