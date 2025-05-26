using GestionDortoir_0._1.Models;
using System;
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
    public partial class DashboardPrecepteur : UserControl
    {
        private MainForm mainForm;
        private Utilisateur utilisateur;
        public DashboardPrecepteur(MainForm form, Utilisateur user)
        {
            InitializeComponent();
            this.mainForm = form;
            this.utilisateur = user;

            labelNom.Text = user.Nom;
            labelRole.Text = user.Role;
        }

    }
}
