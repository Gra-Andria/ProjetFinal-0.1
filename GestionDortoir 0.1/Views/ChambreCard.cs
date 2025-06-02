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
    public partial class ChambreCard : UserControl
    {
        private Chambre chambre;

        public ChambreCard(Chambre chambre)
        {
            InitializeComponent();
            this.chambre = chambre;

            lblNumero.Text = $"Chambre {chambre.numero_chambre}";
            lblCapacite.Text = $"{chambre.Occupants.Count}/{chambre.capacite}";

            lblDisponibilite.Text = chambre.Occupants.Count < chambre.capacite ? "Disponible" : "Complet";
            lblDisponibilite.FillColor = chambre.Occupants.Count < chambre.capacite ? Color.MediumSeaGreen : Color.IndianRed;

            lstOccupants.Items.Clear();
            foreach (var occ in chambre.Occupants)
                lstOccupants.Items.Add($"{occ.Nom} ({occ.AnneeEtude})");

            lstEquipements.Items.Clear();
            foreach (var eq in chambre.Equipements)
                lstEquipements.Items.Add(eq);
        }
    }
}
