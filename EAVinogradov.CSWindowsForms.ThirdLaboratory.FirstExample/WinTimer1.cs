﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EAVinogradov.CSWindowsForms.ThirdLaboratory.FirstExample
{
    public partial class WinTimer1 : Form
    {
        public WinTimer1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            userControlTimer1.TimeEnabled = !(userControlTimer1.TimeEnabled);
        }
    }
}
