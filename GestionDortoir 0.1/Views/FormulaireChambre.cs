﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionDortoir_0._1.Views
{
    public partial class FormulaireChambre : Form
    {
        public FormulaireChambre()
        {
            InitializeComponent();
        }

        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            txtNumeroChambre.Text = "";
            txtNumeroChambre.Text = "";
            txtRemarque.Text = "";
            this.Close();
        }

        private void btnCreer_Click(object sender, EventArgs e)
        {

        }
    }
}
