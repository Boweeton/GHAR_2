﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GHAR_2
{
    public partial class GharMainScreenForm : Form
    {
        public GharMainScreenForm()
        {
            InitializeComponent();
        }

        void OnGharMainScreenFormLoad(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            GeneratePathsSubWindowForm generatePathsSubWindow = new GeneratePathsSubWindowForm();
            //generatePathsSubWindow.Parent = this;
            generatePathsSubWindow.Show();
        }
    }
}