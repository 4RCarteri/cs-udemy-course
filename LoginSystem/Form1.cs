﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoginSystem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            FormLogin formLogin = new FormLogin();
            while(UserRegister.LoggedUser == null)
            {
                Visible = false;
                formLogin.ShowDialog();

                if (FormLogin.Cancel)
                {
                    Application.Exit();
                    return;
                }
            }

            Visible = true;
            labelWelcome.Text = $"Welcome, {UserRegister.LoggedUser.Username}!";

        }

    }
}
