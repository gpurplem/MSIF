﻿using MSIF.Controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MSIF
{
    public partial class Test : Form
    {
        public Test()
        {
            InitializeComponent();
            UsuarioController controller = new UsuarioController();
            //controller.ReadTeste();
            label1.Text = "aiii";
        }

        private void Test_Load(object sender, EventArgs e)
        {

        }
    }
}
