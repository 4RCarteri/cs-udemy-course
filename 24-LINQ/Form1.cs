using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _24_LINQ
{
    public partial class Form1: Form
    {
        List<string> names;
        List<int> numbers;
        Dictionary<string, double> products;
        Dictionary<string, string> states;

        public Form1()
        {
            InitializeComponent();

            names = new List<string>
            {
                "Ali", "Veli", "Deli", "Mehmet", "Ayşe", "Fatma", "Hayriye", "Hüseyin", "Hasan", "Hüseyin"
            };

            numbers = new List<int>
            {
                1, 2, 3, 4, 5, 6, 7, 8, 9, 10
            };

            products = new Dictionary<string, double>
            {
                {"Laptop", 5000},
                {"Mouse", 50},
                {"Keyboard", 100},
                {"Monitor", 1500},
                {"Tablet", 2000},
                {"Phone", 3000},
                {"Headphone", 200},
                {"Speaker", 500},
                {"Microphone", 300},
                {"Webcam", 1000}
            };

            states = new Dictionary<string, string>
            {
                {"Rio de Janeiro", "Brazil"},
                {"Istanbul", "Turkey"},
                {"New York", "USA"},
                {"London", "UK"},
                {"Paris", "France"},
                {"Berlin", "Germany"},
                {"Tokyo", "Japan"},
                {"Moscow", "Russia"},
                {"Rome", "Italy"},
                {"Madrid", "Spain"}
            };
        }

        private void btnRun_Click(object sender, EventArgs e)
        {
            listBox.Items.Clear();

            #region numbers
            IEnumerable<int> number = from num in numbers where num % 2 == 0 select num;

            foreach (var item in number)
            {
                listBox.Items.Add(item);
            }

            // Common method, is worst than LINQ because it is not optimized
            foreach (var item in numbers)
            {
                if (item % 2 == 0)
                {
                    listBox.Items.Add(item);
                }
            }
            #endregion

            #region names

            IEnumerable<string> name = from n in names where n.StartsWith(txtSearch.Text) select n;

            listBox.Items.AddRange(name.ToArray());

            #endregion
        }

        private void btnWhere_Click(object sender, EventArgs e)
        {
            listBox.Items.Clear();
            var res = from name in names where name.ToLower().Contains(txtSearch.Text.ToLower()) select name;

            listBox.Items.AddRange(res.ToArray());
        }

        private void btnOrderBy_Click(object sender, EventArgs e)
        {
            listBox.Items.Clear();

            var res = from product in products orderby product.Key select product;

            foreach (var item in res)
            {
                listBox.Items.Add(item.Key + " - R$" + item.Value);
            }
        }
    }
}
