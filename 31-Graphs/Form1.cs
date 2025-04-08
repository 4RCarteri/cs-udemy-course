using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace _31_Graphs
{
    public partial class Form1 : Form
    {
        Dictionary<double, double> values;
        int countX = 0;

        private void Form1_Load(object sender, EventArgs e)
        {
            txtXValue.Focus();

            for (int i = 0; i < 35; i++)
            {
                cbGraphType.Items.Add((SeriesChartType)i);
            }

            for (int i = 0; i < 13; i++)
            {
                cbPalletColor.Items.Add((KnownColor)i);
            }
        }

        public Form1()
        {
            InitializeComponent();
            values = new Dictionary<double, double>();
        }

        private void btnValues_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtXValue.Text) || string.IsNullOrEmpty(txtYValue.Text))
            {
                MessageBox.Show("Please enter both X and Y values.");
                return;
            }

            if(values.ContainsKey(double.Parse(txtXValue.Text)))
            {
                values[double.Parse(txtXValue.Text)] = double.Parse(txtYValue.Text);
            }
            else
            {
                values.Add(double.Parse(txtXValue.Text), double.Parse(txtYValue.Text));
            }

            var items = from value in values orderby value.Key ascending select value;

            dataGridView1.Rows.Clear();
            graph.Series[0].Points.Clear();

            foreach(var item in items)
            {
                dataGridView1.Rows.Add(item.Key, item.Value);
                graph.Series[0].Points.AddXY(item.Key, item.Value);
            }

            graph.Update();

            txtXValue.Text = "";
            txtYValue.Text = "";
            txtXValue.Focus();
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            txtXValue.Text = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[0].Value.ToString();
            txtYValue.Text = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[1].Value.ToString();
        }

        private void btnClean_Click(object sender, EventArgs e)
        {
            values.Clear();
            dataGridView1.Rows.Clear();
            txtXValue.Text = "";
            txtYValue.Text = "";
            txtXValue.Focus();
            countX = 0;
            graph.Series[0].Points.Clear();
        }
        

        private void cbGraphType_SelectedIndexChanged(object sender, EventArgs e)
        {
            graph.Series[0].ChartType = (SeriesChartType)cbGraphType.SelectedItem;
        }

        private void cbPalletColor_SelectedIndexChanged(object sender, EventArgs e)
        {
            graph.Palette = (ChartColorPalette)cbPalletColor.SelectedItem;
        }

        private void cb3D_CheckedChanged(object sender, EventArgs e)
        {
            graph.ChartAreas[0].Area3DStyle.Enable3D = cb3D.Checked;
        }

        private void btnRandom_Click(object sender, EventArgs e)
        {
            timer.Enabled = !timer.Enabled;
        }

        private void txtXValue_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((!char.IsDigit(e.KeyChar) && 
                    e.KeyChar != (char)8 && 
                    e.KeyChar != (char)13 && 
                    e.KeyChar != (char)44) || 
                (txtXValue.Text.Contains((char)44) && 
                    e.KeyChar == (char)44))
            {
                e.Handled = true;
            }
        }

        private void txtYValue_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((!char.IsDigit(e.KeyChar) &&
                    e.KeyChar != (char)8 &&
                    e.KeyChar != (char)13 &&
                    e.KeyChar != (char)44) ||
                (txtYValue.Text.Contains((char)44) &&
                    e.KeyChar == (char)44))
            {
                e.Handled = true;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if(graph.Series[0].Points.Count > 10)
            {
                graph.Series[0].Points.RemoveAt(0);
                graph.Update();
            }

            double y = (double)new Random((int)DateTime.Now.Ticks).Next(0, 1000);

            graph.Series[0].Points.AddXY(countX++, y);
            dataGridView1.Rows.Add(countX, y);
            dataGridView1.CurrentCell = dataGridView1.Rows[dataGridView1.Rows.Count - 1].Cells[0];
        }
    }
}
