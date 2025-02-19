namespace ImportantClasses
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
            this.btnMessageBox = new System.Windows.Forms.Button();
            this.lblResult = new System.Windows.Forms.Label();
            this.btnRandom = new System.Windows.Forms.Button();
            this.btnTimeSpan = new System.Windows.Forms.Button();
            this.btnDateTime = new System.Windows.Forms.Button();
            this.lbl2 = new System.Windows.Forms.Label();
            this.btnColor = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnMessageBox
            // 
            this.btnMessageBox.Location = new System.Drawing.Point(12, 285);
            this.btnMessageBox.Name = "btnMessageBox";
            this.btnMessageBox.Size = new System.Drawing.Size(208, 72);
            this.btnMessageBox.TabIndex = 0;
            this.btnMessageBox.Text = "MessageBox";
            this.btnMessageBox.UseVisualStyleBackColor = true;
            this.btnMessageBox.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblResult
            // 
            this.lblResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResult.Location = new System.Drawing.Point(13, 13);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(340, 73);
            this.lblResult.TabIndex = 1;
            this.lblResult.Text = "label1";
            // 
            // btnRandom
            // 
            this.btnRandom.Location = new System.Drawing.Point(226, 285);
            this.btnRandom.Name = "btnRandom";
            this.btnRandom.Size = new System.Drawing.Size(208, 72);
            this.btnRandom.TabIndex = 2;
            this.btnRandom.Text = "Random";
            this.btnRandom.UseVisualStyleBackColor = true;
            this.btnRandom.Click += new System.EventHandler(this.btnRandom_Click);
            // 
            // btnTimeSpan
            // 
            this.btnTimeSpan.Location = new System.Drawing.Point(440, 285);
            this.btnTimeSpan.Name = "btnTimeSpan";
            this.btnTimeSpan.Size = new System.Drawing.Size(208, 72);
            this.btnTimeSpan.TabIndex = 3;
            this.btnTimeSpan.Text = "TimeSpan";
            this.btnTimeSpan.UseVisualStyleBackColor = true;
            this.btnTimeSpan.Click += new System.EventHandler(this.btnTimeSpan_Click);
            // 
            // btnDateTime
            // 
            this.btnDateTime.Location = new System.Drawing.Point(654, 285);
            this.btnDateTime.Name = "btnDateTime";
            this.btnDateTime.Size = new System.Drawing.Size(208, 72);
            this.btnDateTime.TabIndex = 4;
            this.btnDateTime.Text = "DateTime";
            this.btnDateTime.UseVisualStyleBackColor = true;
            this.btnDateTime.Click += new System.EventHandler(this.btnDateTime_Click);
            // 
            // lbl2
            // 
            this.lbl2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl2.Location = new System.Drawing.Point(13, 97);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(340, 73);
            this.lbl2.TabIndex = 5;
            this.lbl2.Text = "label1";
            // 
            // btnColor
            // 
            this.btnColor.Location = new System.Drawing.Point(12, 366);
            this.btnColor.Name = "btnColor";
            this.btnColor.Size = new System.Drawing.Size(208, 72);
            this.btnColor.TabIndex = 6;
            this.btnColor.Text = "Color";
            this.btnColor.UseVisualStyleBackColor = true;
            this.btnColor.Click += new System.EventHandler(this.btnColor_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(874, 450);
            this.Controls.Add(this.btnColor);
            this.Controls.Add(this.lbl2);
            this.Controls.Add(this.btnDateTime);
            this.Controls.Add(this.btnTimeSpan);
            this.Controls.Add(this.btnRandom);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.btnMessageBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnMessageBox;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Button btnRandom;
        private System.Windows.Forms.Button btnTimeSpan;
        private System.Windows.Forms.Button btnDateTime;
        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.Button btnColor;
    }
}

