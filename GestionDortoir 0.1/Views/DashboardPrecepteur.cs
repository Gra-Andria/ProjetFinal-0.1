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
        //Chargement les Panel
        private void LoadUserControl(UserControl userControl) { 
            panelPrincipale.Controls.Clear();
            userControl.Dock = DockStyle.Fill;
            panelPrincipale.Controls.Add(userControl);
        }
        //Transition du sidebar
        bool sidebarExpand = true;
        private void sidebarTransition_Tick(object sender, EventArgs e)
        {
            if (sidebarExpand) {
                panelMenu.Width -= 10;
                if (panelMenu.Width <= 60) { 
                    sidebarExpand = false;
                    sidebarTransition.Stop();
                } 
            }
            else
            {
                panelMenu.Width += 10;
                if (panelMenu.Width >= 218)
                {
                    sidebarExpand = true;
                    sidebarTransition.Stop();
                }
            }
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            sidebarTransition.Start();
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            LoadUserControl(new DashboardControl());
        }

        private void btnEtudiant_Click(object sender, EventArgs e)
        {
            LoadUserControl(new GestionEtudiantControl());
        }

        private void btnChambre_Click(object sender, EventArgs e)
        {
            LoadUserControl(new GestionChambreControl());
        }

        private void btnPlanning_Click(object sender, EventArgs e)
        {
            LoadUserControl(new PlannificationControl());
        }

        private void btnRapport_Click(object sender, EventArgs e)
        {
            LoadUserControl(new GenerationRapport());
        }
    }
}
