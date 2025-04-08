using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _31_LambdaExpressions
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnRun_Click(object sender, EventArgs e)
        {
            // Lambda Expression with a expression as a body
            // (input - parameter) => expression

            // Lambda Expression with a statement block as a body
            // (input - parameter) => { statement; statement; }

            Func<int, int> square1 = quadrado;

            int quadrado(int x)
            {
                return x * x;
            }

            //using lambda

            Func<int, int> square = x => x * x;
            lblResult.Text = $"Square of 5 is {square(5)}";

            // Lambda expression print the expression
            Expression<Func<int, int>> squareExpression = x => x * x;
            lblResult.Text = $"Square of 5 is {squareExpression.Compile()(5)}";

            int[] numbers = { 1, 2, 3, 4, 5 };
            var squares = numbers.Select(x => x * x);
            lblResult.Text = $"Squares: {string.Join(", ", squares)}";

            //Lambda with statement block
            Action<string> greet = name =>
            {
                string message = $"Hello, {name}!";
                lblResult.Text = message;
            };

            greet("World");

            Action line = () => lblResult.Text = "Hello, World!";

            Func<int, int, bool> isGreaterThan = (x, y) => (x > y) ? true : false;
            lblResult.Text = $"Is 5 greater than 3? {isGreaterThan(5, 3)}";

        }
    }
}
