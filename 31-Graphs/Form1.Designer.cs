namespace _31_Graphs
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtXValue = new System.Windows.Forms.TextBox();
            this.txtYValue = new System.Windows.Forms.TextBox();
            this.btnValues = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.X = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Y = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnClean = new System.Windows.Forms.Button();
            this.cbGraphType = new System.Windows.Forms.ComboBox();
            this.cbPalletColor = new System.Windows.Forms.ComboBox();
            this.cb3D = new System.Windows.Forms.CheckBox();
            this.btnRandom = new System.Windows.Forms.Button();
            this.graph = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.timer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.graph)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(78, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Graph";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Axis X";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(146, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Axis Y";
            // 
            // txtXValue
            // 
            this.txtXValue.Location = new System.Drawing.Point(2, 76);
            this.txtXValue.Name = "txtXValue";
            this.txtXValue.Size = new System.Drawing.Size(100, 20);
            this.txtXValue.TabIndex = 3;
            this.txtXValue.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtXValue_KeyPress);
            // 
            // txtYValue
            // 
            this.txtYValue.Location = new System.Drawing.Point(122, 76);
            this.txtYValue.Name = "txtYValue";
            this.txtYValue.Size = new System.Drawing.Size(100, 20);
            this.txtYValue.TabIndex = 4;
            this.txtYValue.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtYValue_KeyPress);
            // 
            // btnValues
            // 
            this.btnValues.Location = new System.Drawing.Point(82, 102);
            this.btnValues.Name = "btnValues";
            this.btnValues.Size = new System.Drawing.Size(75, 23);
            this.btnValues.TabIndex = 5;
            this.btnValues.Text = "Insert values";
            this.btnValues.UseVisualStyleBackColor = true;
            this.btnValues.Click += new System.EventHandler(this.btnValues_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.X,
            this.Y});
            this.dataGridView1.Location = new System.Drawing.Point(2, 131);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(240, 150);
            this.dataGridView1.TabIndex = 6;
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // X
            // 
            this.X.HeaderText = "Axis X";
            this.X.Name = "X";
            this.X.ReadOnly = true;
            // 
            // Y
            // 
            this.Y.HeaderText = "Axis Y";
            this.Y.Name = "Y";
            this.Y.ReadOnly = true;
            // 
            // btnClean
            // 
            this.btnClean.Location = new System.Drawing.Point(82, 287);
            this.btnClean.Name = "btnClean";
            this.btnClean.Size = new System.Drawing.Size(75, 23);
            this.btnClean.TabIndex = 7;
            this.btnClean.Text = "Clear";
            this.btnClean.UseVisualStyleBackColor = true;
            this.btnClean.Click += new System.EventHandler(this.btnClean_Click);
            // 
            // cbGraphType
            // 
            this.cbGraphType.FormattingEnabled = true;
            this.cbGraphType.Location = new System.Drawing.Point(2, 316);
            this.cbGraphType.Name = "cbGraphType";
            this.cbGraphType.Size = new System.Drawing.Size(121, 21);
            this.cbGraphType.TabIndex = 8;
            this.cbGraphType.SelectedIndexChanged += new System.EventHandler(this.cbGraphType_SelectedIndexChanged);
            // 
            // cbPalletColor
            // 
            this.cbPalletColor.FormattingEnabled = true;
            this.cbPalletColor.Location = new System.Drawing.Point(129, 316);
            this.cbPalletColor.Name = "cbPalletColor";
            this.cbPalletColor.Size = new System.Drawing.Size(121, 21);
            this.cbPalletColor.TabIndex = 9;
            this.cbPalletColor.SelectedIndexChanged += new System.EventHandler(this.cbPalletColor_SelectedIndexChanged);
            // 
            // cb3D
            // 
            this.cb3D.AutoSize = true;
            this.cb3D.Location = new System.Drawing.Point(256, 320);
            this.cb3D.Name = "cb3D";
            this.cb3D.Size = new System.Drawing.Size(72, 17);
            this.cb3D.TabIndex = 10;
            this.cb3D.Text = "3D Graph";
            this.cb3D.UseVisualStyleBackColor = true;
            this.cb3D.CheckedChanged += new System.EventHandler(this.cb3D_CheckedChanged);
            // 
            // btnRandom
            // 
            this.btnRandom.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnRandom.Location = new System.Drawing.Point(334, 316);
            this.btnRandom.Name = "btnRandom";
            this.btnRandom.Size = new System.Drawing.Size(75, 23);
            this.btnRandom.TabIndex = 11;
            this.btnRandom.Text = "Random Values";
            this.btnRandom.UseVisualStyleBackColor = false;
            this.btnRandom.Click += new System.EventHandler(this.btnRandom_Click);
            // 
            // graph
            // 
            chartArea2.Name = "ChartArea1";
            this.graph.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.graph.Legends.Add(legend2);
            this.graph.Location = new System.Drawing.Point(256, 10);
            this.graph.Name = "graph";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series2.Legend = "Legend1";
            series2.Name = "X vs Y";
            this.graph.Series.Add(series2);
            this.graph.Size = new System.Drawing.Size(443, 300);
            this.graph.TabIndex = 12;
            this.graph.Text = "chart1";
            // 
            // timer
            // 
            this.timer.Interval = 500;
            this.timer.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(718, 352);
            this.Controls.Add(this.graph);
            this.Controls.Add(this.btnRandom);
            this.Controls.Add(this.cb3D);
            this.Controls.Add(this.cbPalletColor);
            this.Controls.Add(this.cbGraphType);
            this.Controls.Add(this.btnClean);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnValues);
            this.Controls.Add(this.txtYValue);
            this.Controls.Add(this.txtXValue);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.graph)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtXValue;
        private System.Windows.Forms.TextBox txtYValue;
        private System.Windows.Forms.Button btnValues;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn X;
        private System.Windows.Forms.DataGridViewTextBoxColumn Y;
        private System.Windows.Forms.Button btnClean;
        private System.Windows.Forms.ComboBox cbGraphType;
        private System.Windows.Forms.ComboBox cbPalletColor;
        private System.Windows.Forms.CheckBox cb3D;
        private System.Windows.Forms.Button btnRandom;
        private System.Windows.Forms.DataVisualization.Charting.Chart graph;
        private System.Windows.Forms.Timer timer;
    }
}

