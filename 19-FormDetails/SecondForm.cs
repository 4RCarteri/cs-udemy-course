﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _19_FormDetails
{
    public partial class SecondForm: Form
    {
        public SecondForm()
        {
            InitializeComponent();
        }

        private void btnMain_Click(object sender, EventArgs e)
        {
            Close();
            new Thread(() => Application.Run(new MainForm())).Start();
        }
    }
}
