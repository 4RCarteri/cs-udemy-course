﻿namespace _24_LINQ
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
            this.listBox = new System.Windows.Forms.ListBox();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnRun = new System.Windows.Forms.Button();
            this.btnWhere = new System.Windows.Forms.Button();
            this.btnOrderBy = new System.Windows.Forms.Button();
            this.btnGroupBy = new System.Windows.Forms.Button();
            this.btnAggregation = new System.Windows.Forms.Button();
            this.btnOperators = new System.Windows.Forms.Button();
            this.btnLambda = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBox
            // 
            this.listBox.FormattingEnabled = true;
            this.listBox.Location = new System.Drawing.Point(12, 15);
            this.listBox.Name = "listBox";
            this.listBox.Size = new System.Drawing.Size(252, 420);
            this.listBox.TabIndex = 0;
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(270, 15);
            this.txtSearch.Multiline = true;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(185, 55);
            this.txtSearch.TabIndex = 1;
            // 
            // btnRun
            // 
            this.btnRun.Location = new System.Drawing.Point(270, 76);
            this.btnRun.Name = "btnRun";
            this.btnRun.Size = new System.Drawing.Size(185, 31);
            this.btnRun.TabIndex = 2;
            this.btnRun.Text = "Run";
            this.btnRun.UseVisualStyleBackColor = true;
            this.btnRun.Click += new System.EventHandler(this.btnRun_Click);
            // 
            // btnWhere
            // 
            this.btnWhere.Location = new System.Drawing.Point(270, 113);
            this.btnWhere.Name = "btnWhere";
            this.btnWhere.Size = new System.Drawing.Size(185, 31);
            this.btnWhere.TabIndex = 3;
            this.btnWhere.Text = "Where";
            this.btnWhere.UseVisualStyleBackColor = true;
            this.btnWhere.Click += new System.EventHandler(this.btnWhere_Click);
            // 
            // btnOrderBy
            // 
            this.btnOrderBy.Location = new System.Drawing.Point(270, 150);
            this.btnOrderBy.Name = "btnOrderBy";
            this.btnOrderBy.Size = new System.Drawing.Size(185, 31);
            this.btnOrderBy.TabIndex = 4;
            this.btnOrderBy.Text = "OrderBy";
            this.btnOrderBy.UseVisualStyleBackColor = true;
            this.btnOrderBy.Click += new System.EventHandler(this.btnOrderBy_Click);
            // 
            // btnGroupBy
            // 
            this.btnGroupBy.Location = new System.Drawing.Point(270, 187);
            this.btnGroupBy.Name = "btnGroupBy";
            this.btnGroupBy.Size = new System.Drawing.Size(185, 31);
            this.btnGroupBy.TabIndex = 5;
            this.btnGroupBy.Text = "Group By";
            this.btnGroupBy.UseVisualStyleBackColor = true;
            this.btnGroupBy.Click += new System.EventHandler(this.btnGroupBy_Click);
            // 
            // btnAggregation
            // 
            this.btnAggregation.Location = new System.Drawing.Point(270, 224);
            this.btnAggregation.Name = "btnAggregation";
            this.btnAggregation.Size = new System.Drawing.Size(185, 31);
            this.btnAggregation.TabIndex = 6;
            this.btnAggregation.Text = "Aggregation";
            this.btnAggregation.UseVisualStyleBackColor = true;
            this.btnAggregation.Click += new System.EventHandler(this.btnAggregation_Click);
            // 
            // btnOperators
            // 
            this.btnOperators.Location = new System.Drawing.Point(270, 261);
            this.btnOperators.Name = "btnOperators";
            this.btnOperators.Size = new System.Drawing.Size(185, 31);
            this.btnOperators.TabIndex = 7;
            this.btnOperators.Text = "Element operators";
            this.btnOperators.UseVisualStyleBackColor = true;
            this.btnOperators.Click += new System.EventHandler(this.btnOperators_Click);
            // 
            // btnLambda
            // 
            this.btnLambda.Location = new System.Drawing.Point(270, 298);
            this.btnLambda.Name = "btnLambda";
            this.btnLambda.Size = new System.Drawing.Size(185, 31);
            this.btnLambda.TabIndex = 8;
            this.btnLambda.Text = "Lambda";
            this.btnLambda.UseVisualStyleBackColor = true;
            this.btnLambda.Click += new System.EventHandler(this.btnLambda_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 450);
            this.Controls.Add(this.btnLambda);
            this.Controls.Add(this.btnOperators);
            this.Controls.Add(this.btnAggregation);
            this.Controls.Add(this.btnGroupBy);
            this.Controls.Add(this.btnOrderBy);
            this.Controls.Add(this.btnWhere);
            this.Controls.Add(this.btnRun);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.listBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnRun;
        private System.Windows.Forms.Button btnWhere;
        private System.Windows.Forms.Button btnOrderBy;
        private System.Windows.Forms.Button btnGroupBy;
        private System.Windows.Forms.Button btnAggregation;
        private System.Windows.Forms.Button btnOperators;
        private System.Windows.Forms.Button btnLambda;
    }
}

