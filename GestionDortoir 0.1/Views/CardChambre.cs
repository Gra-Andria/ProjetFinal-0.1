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
    public partial class CardChambre : UserControl
    {
        public CardChambre()
        {
            InitializeComponent();
        }
        public void ChargerDonnees(Chambre chambre, List<Equipement> equipements)
        {
            lblNumero.Text = $"Chambre n°{chambre.numero_chambre}";
            lblCapacite.Text = $"Capacité : {chambre.capacite}";
            lblRemarque.Text = $"Remarque : {chambre.remarque}";

            lstEquipements.Controls.Clear(); 

            foreach (var eq in equipements)
            {
                Label lblEq = new Label();
                lblEq.Text = "• " + eq.Nom; 
                lblEq.AutoSize = true;
                lstEquipements.Controls.Add(lblEq);
            }
        }
    }
}
