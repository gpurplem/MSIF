﻿using System;
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
    public partial class ContatoResumo : UserControl
    {
        public ContatoResumo(String apelido)
        {
            InitializeComponent();
            lblNomeUsuario.Text = apelido;
        }

        private void ContatoResumo_Load(object sender, EventArgs e)
        {

        }
    }
}
