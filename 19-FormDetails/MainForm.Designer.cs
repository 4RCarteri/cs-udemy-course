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
            this.SuspendLayout();
            // 
            // lblMain
            // 
            this.lblMain.AutoSize = true;
            this.lblMain.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMain.Location = new System.Drawing.Point(338, 47);
            this.lblMain.Name = "lblMain";
            this.lblMain.Size = new System.Drawing.Size(86, 37);
            this.lblMain.TabIndex = 0;
            this.lblMain.Text = "Main";
            this.lblMain.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnSecond
            // 
            this.btnSecond.Location = new System.Drawing.Point(12, 390);
            this.btnSecond.Name = "btnSecond";
            this.btnSecond.Size = new System.Drawing.Size(172, 48);
            this.btnSecond.TabIndex = 1;
            this.btnSecond.Text = "Second Form";
            this.btnSecond.UseVisualStyleBackColor = true;
            this.btnSecond.Click += new System.EventHandler(this.btnSecond_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSecond);
            this.Controls.Add(this.lblMain);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMain;
        private System.Windows.Forms.Button btnSecond;
    }
}

