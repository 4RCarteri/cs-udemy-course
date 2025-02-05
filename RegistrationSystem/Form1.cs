using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RegistrationSystem
{
    public partial class Form1 : Form
    {
        List<Person> people;

        public Form1()
        {
            InitializeComponent();
            people = new List<Person>();

            comboMS.Items.Add("Single");
            comboMS.Items.Add("Married");
            comboMS.Items.Add("Divorced");
            comboMS.Items.Add("Widowed");
            comboMS.SelectedIndex = 0;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            int index = -1;
            foreach (Person person in people)
            {
                if (person.Name == txtName.Text)
                {
                    index = people.IndexOf(p);
                }
            }

            if (txtName.Text == "")
            {
                MessageBox.Show("Please enter a name.");
                txtName.Focus();
                return;
            }

            if (txtPhone.Text == "")
            {
                MessageBox.Show("Please enter a phone number.");
                txtPhone.Focus();
                return;
            }

            char sex;
            if (radioM.Checked)
            {
                sex = 'M';
            }
            else if (radioF.Checked)
            {
                sex = 'F';
            }
            else (radioO.Checked)
            {
                sex = 'O';
            }

            Person p = new Person();
            p.Name = txtName.Text;
            p.DateBirth = txtData.Text;
            p.MaritalState = comboMS.SelectedItem.ToString();
            p.Phone = txtPhone.Text;
            p.HasHouse = checkHouse.Checked;
            p.HasVehicle = checkVehicle.Checked;
            p.Sex = sex;

            if (index < 0)
            {
                people.Add(p);
            }
            else
            {
                people[index] = p;
            }

            btnClean_Click(btnClean, EventArgs.Empty);
            List();
        }

            
        private void btnDelete_Click(object sender, EventArgs e)
        {

        }

        private void btnClean_Click(object sender, EventArgs e)
        {

        }

        private void List() { 
            list.Items.Clear();
            foreach (Person p in people)
            {
                list.Items.Add(p.Name);
            }

        }
    }
}
