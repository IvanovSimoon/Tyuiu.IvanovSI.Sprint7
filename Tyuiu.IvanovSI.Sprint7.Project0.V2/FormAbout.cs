﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;
namespace Tyuiu.IvanovSI.Sprint7.Project0.V2
{
    public partial class FormAbout : MetroForm
    {
        public FormAbout()
        {
            InitializeComponent();
        }

        private void buttonOk_ISI_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
