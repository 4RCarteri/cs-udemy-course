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
                "Ali", "Veli", "Deli", "Mehmeteee", "Ayşe", "Fatma", "Hayriye", "Hüseyin", "Hasan", "Hüseyin"
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
                {"São Paulo", "Brazil"},
                {"New York", "USA"},
                {"California", "USA"},
                {"Tokyo", "Japan"},
                {"Kyoto", "Japan"},
                {"Paris", "France"},
                {"Lyon", "France"},
                {"Berlin", "Germany"},
                {"Munich", "Germany"}
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

        private void btnGroupBy_Click(object sender, EventArgs e)
        {
            listBox.Items.Clear();

            var res = from state in states orderby state.Key group state by state.Value;

            foreach (var item in res)
            {
                listBox.Items.Add(item.Key);
                foreach (var city in item)
                {
                    listBox.Items.Add("\t" + city.Key);
                }
            }
        }

        private void btnAggregation_Click(object sender, EventArgs e)
        {
            listBox.Items.Clear();

            var count1 = names.Count();
            listBox.Items.Add(count1 + " names");

            var count2 = (from name in names where name.StartsWith("H") select name).Count();
            listBox.Items.Add(count2 + " names starting with H");

            var mean2 = (from product in products select product.Value).Average();
            listBox.Items.Add("Mean: " + mean2);

            var sum2 = (from product in products where product.Value > 1000 select product.Value).Sum();
            listBox.Items.Add("Sum: " + sum2);

            var min2 = (from num in numbers select num).Min();
            listBox.Items.Add("Min: " + min2);

            var max2 = (from num in numbers select num).Max();
            listBox.Items.Add("Max: " + max2);

            string biggerName = (from name in names orderby name.Length descending select name).First();
            listBox.Items.Add("Bigger name: " + biggerName);
            
            biggerName = names.Aggregate((longer, next) => { return longer.Length > next.Length ? longer : next; });
            listBox.Items.Add("Bigger name: " + biggerName);
        }

        private void btnOperators_Click(object sender, EventArgs e)
        {
            int first = numbers.FirstOrDefault();
            listBox.Items.Add("First: " + first);

            int last = numbers.LastOrDefault();
            listBox.Items.Add("Last: " + last);

            int emelemntAt = numbers.ElementAtOrDefault(5);
            listBox.Items.Add("Element at 5: " + emelemntAt);

            var res = (from product in products where product.Value > 1000 select product).FirstOrDefault();
            listBox.Items.Add("First product over 1000: " + res.Key + " - R$" + res.Value);
        }

        private void btnLambda_Click(object sender, EventArgs e)
        {
            var res = from name in names select name;
            res = names.Select(name => name);
            listBox.Items.AddRange(res.ToArray());

            var res2 = from name in names where name.StartsWith("H") select name;
            res2 = names.Where(name => name.StartsWith("H"));
            listBox.Items.AddRange(res2.ToArray());

            var res3 = from product in products orderby product.Key select product;
            res3 = products.OrderBy(product => product.Key);
            listBox.Items.AddRange(res3.Select(product => product.Key + " - R$" + product.Value).ToArray());

            var res4 = from state in states orderby state.Key group state by state.Value;
            res4 = states.OrderBy(state => state.Key).GroupBy(state => state.Value);
            listBox.Items.AddRange(res4.ToArray());



        }
    }
}
