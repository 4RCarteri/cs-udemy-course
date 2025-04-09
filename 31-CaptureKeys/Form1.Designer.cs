namespace _31_CaptureKeys
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
            this.lblResult = new System.Windows.Forms.Label();
            this.btnKeyX = new System.Windows.Forms.Button();
            this.btnKeyEnter = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResult.Location = new System.Drawing.Point(46, 25);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(143, 25);
            this.lblResult.TabIndex = 0;
            this.lblResult.Text = "Press a key...";
            // 
            // btnKeyX
            // 
            this.btnKeyX.Location = new System.Drawing.Point(41, 159);
            this.btnKeyX.Name = "btnKeyX";
            this.btnKeyX.Size = new System.Drawing.Size(75, 23);
            this.btnKeyX.TabIndex = 1;
            this.btnKeyX.Text = "Key X";
            this.btnKeyX.UseVisualStyleBackColor = true;
            this.btnKeyX.Click += new System.EventHandler(this.btnKeyX_Click);
            this.btnKeyX.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.form_KeyPress);
            // 
            // btnKeyEnter
            // 
            this.btnKeyEnter.Location = new System.Drawing.Point(177, 159);
            this.btnKeyEnter.Name = "btnKeyEnter";
            this.btnKeyEnter.Size = new System.Drawing.Size(75, 23);
            this.btnKeyEnter.TabIndex = 2;
            this.btnKeyEnter.Text = "Key Enter";
            this.btnKeyEnter.UseVisualStyleBackColor = true;
            this.btnKeyEnter.Click += new System.EventHandler(this.btnKeyEnter_Click);
            this.btnKeyEnter.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.form_KeyPress);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(379, 242);
            this.Controls.Add(this.btnKeyEnter);
            this.Controls.Add(this.btnKeyX);
            this.Controls.Add(this.lblResult);
            this.Name = "Form1";
            this.Text = "Form1";
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.form_KeyPress);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Button btnKeyX;
        private System.Windows.Forms.Button btnKeyEnter;
    }
}

