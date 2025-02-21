namespace _19_FormDetails
{
    partial class MainForm
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
            this.lblMain = new System.Windows.Forms.Label();
            this.btnSecond = new System.Windows.Forms.Button();
            this.btnSecondFromThread = new System.Windows.Forms.Button();
            this.menuBar = new System.Windows.Forms.MenuStrip();
            this.menuFile = new System.Windows.Forms.ToolStripMenuItem();
            this.mFileNew = new System.Windows.Forms.ToolStripMenuItem();
            this.mFileOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.mFileExit = new System.Windows.Forms.ToolStripMenuItem();
            this.menuHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.mHelpAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.mHelpAboutDev = new System.Windows.Forms.ToolStripMenuItem();
            this.mHelpAboutVersion = new System.Windows.Forms.ToolStripMenuItem();
            this.menuComb = new System.Windows.Forms.ToolStripComboBox();
            this.mSearch = new System.Windows.Forms.ToolStripTextBox();
            this.menuBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblMain
            // 
            this.lblMain.AutoSize = true;
            this.lblMain.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMain.Location = new System.Drawing.Point(225, 31);
            this.lblMain.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMain.Name = "lblMain";
            this.lblMain.Size = new System.Drawing.Size(86, 37);
            this.lblMain.TabIndex = 0;
            this.lblMain.Text = "Main";
            this.lblMain.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnSecond
            // 
            this.btnSecond.Location = new System.Drawing.Point(8, 253);
            this.btnSecond.Margin = new System.Windows.Forms.Padding(2);
            this.btnSecond.Name = "btnSecond";
            this.btnSecond.Size = new System.Drawing.Size(115, 31);
            this.btnSecond.TabIndex = 1;
            this.btnSecond.Text = "Second Form";
            this.btnSecond.UseVisualStyleBackColor = true;
            this.btnSecond.Click += new System.EventHandler(this.btnSecond_Click);
            // 
            // btnSecondFromThread
            // 
            this.btnSecondFromThread.Location = new System.Drawing.Point(127, 253);
            this.btnSecondFromThread.Margin = new System.Windows.Forms.Padding(2);
            this.btnSecondFromThread.Name = "btnSecondFromThread";
            this.btnSecondFromThread.Size = new System.Drawing.Size(115, 31);
            this.btnSecondFromThread.TabIndex = 2;
            this.btnSecondFromThread.Text = "Second Form Thread";
            this.btnSecondFromThread.UseVisualStyleBackColor = true;
            this.btnSecondFromThread.Click += new System.EventHandler(this.btnSecondFromThread_Click);
            // 
            // menuBar
            // 
            this.menuBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuFile,
            this.menuHelp,
            this.menuComb,
            this.mSearch});
            this.menuBar.Location = new System.Drawing.Point(0, 0);
            this.menuBar.Name = "menuBar";
            this.menuBar.Size = new System.Drawing.Size(533, 27);
            this.menuBar.TabIndex = 3;
            this.menuBar.Text = "menuStrip1";
            // 
            // menuFile
            // 
            this.menuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mFileNew,
            this.mFileOpen,
            this.toolStripSeparator1,
            this.mFileExit});
            this.menuFile.Name = "menuFile";
            this.menuFile.ShortcutKeyDisplayString = "";
            this.menuFile.Size = new System.Drawing.Size(37, 23);
            this.menuFile.Text = "File";
            // 
            // mFileNew
            // 
            this.mFileNew.Image = global::_19_FormDetails.Properties.Resources.New;
            this.mFileNew.Name = "mFileNew";
            this.mFileNew.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.mFileNew.Size = new System.Drawing.Size(180, 22);
            this.mFileNew.Text = "New";
            this.mFileNew.Click += new System.EventHandler(this.mFileNew_Click);
            // 
            // mFileOpen
            // 
            this.mFileOpen.Image = global::_19_FormDetails.Properties.Resources.Open;
            this.mFileOpen.Name = "mFileOpen";
            this.mFileOpen.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.mFileOpen.Size = new System.Drawing.Size(180, 22);
            this.mFileOpen.Text = "Open";
            this.mFileOpen.Click += new System.EventHandler(this.mFileOpen_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(100, 6);
            // 
            // mFileExit
            // 
            this.mFileExit.Image = global::_19_FormDetails.Properties.Resources.Exit;
            this.mFileExit.Name = "mFileExit";
            this.mFileExit.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F)));
            this.mFileExit.Size = new System.Drawing.Size(180, 22);
            this.mFileExit.Text = "Exit";
            this.mFileExit.Click += new System.EventHandler(this.mFileExit_Click);
            // 
            // menuHelp
            // 
            this.menuHelp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mHelpAbout});
            this.menuHelp.Name = "menuHelp";
            this.menuHelp.Size = new System.Drawing.Size(44, 23);
            this.menuHelp.Text = "Help";
            // 
            // mHelpAbout
            // 
            this.mHelpAbout.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mHelpAboutDev,
            this.mHelpAboutVersion});
            this.mHelpAbout.Name = "mHelpAbout";
            this.mHelpAbout.Size = new System.Drawing.Size(107, 22);
            this.mHelpAbout.Text = "About";
            // 
            // mHelpAboutDev
            // 
            this.mHelpAboutDev.Name = "mHelpAboutDev";
            this.mHelpAboutDev.Size = new System.Drawing.Size(145, 22);
            this.mHelpAboutDev.Text = "Develompent";
            this.mHelpAboutDev.Click += new System.EventHandler(this.mHelpAboutDev_Click);
            // 
            // mHelpAboutVersion
            // 
            this.mHelpAboutVersion.Name = "mHelpAboutVersion";
            this.mHelpAboutVersion.Size = new System.Drawing.Size(145, 22);
            this.mHelpAboutVersion.Text = "Version";
            this.mHelpAboutVersion.Click += new System.EventHandler(this.mHelpAboutVersion_Click);
            // 
            // menuComb
            // 
            this.menuComb.Name = "menuComb";
            this.menuComb.Size = new System.Drawing.Size(121, 23);
            this.menuComb.SelectedIndexChanged += new System.EventHandler(this.menuComb_SelectedIndexChanged);
            // 
            // mSearch
            // 
            this.mSearch.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.mSearch.Name = "mSearch";
            this.mSearch.Size = new System.Drawing.Size(100, 23);
            this.mSearch.KeyUp += new System.Windows.Forms.KeyEventHandler(this.mSearch_KeyUp);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(533, 292);
            this.Controls.Add(this.btnSecondFromThread);
            this.Controls.Add(this.btnSecond);
            this.Controls.Add(this.lblMain);
            this.Controls.Add(this.menuBar);
            this.MainMenuStrip = this.menuBar;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.menuBar.ResumeLayout(false);
            this.menuBar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMain;
        private System.Windows.Forms.Button btnSecond;
        private System.Windows.Forms.Button btnSecondFromThread;
        private System.Windows.Forms.MenuStrip menuBar;
        private System.Windows.Forms.ToolStripMenuItem menuFile;
        private System.Windows.Forms.ToolStripMenuItem mFileNew;
        private System.Windows.Forms.ToolStripMenuItem mFileOpen;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem mFileExit;
        private System.Windows.Forms.ToolStripMenuItem menuHelp;
        private System.Windows.Forms.ToolStripMenuItem mHelpAbout;
        private System.Windows.Forms.ToolStripMenuItem mHelpAboutDev;
        private System.Windows.Forms.ToolStripMenuItem mHelpAboutVersion;
        private System.Windows.Forms.ToolStripComboBox menuComb;
        private System.Windows.Forms.ToolStripTextBox mSearch;
    }
}

