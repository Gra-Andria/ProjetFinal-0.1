using GestionDortoir_0._1.Controllers;
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
    public partial class GestionChambreControl : UserControl
    {
        public GestionChambreControl()
        {
            InitializeComponent();
            AfficherTousLesChambres();
        }
        //Afficher tous les chambres
        private void AfficherTousLesChambres()
        {
            flowLayoutPanelChambres.Controls.Clear();
            List<Chambre> chambres = ChambreController.GetAllChambre();
            foreach (var chambre in chambres)
            {
                var equipements = EquipementController.GetByChambreId(chambre.numero_chambre);

                CardChambre card = new CardChambre();
                card.ChargerDonnees(chambre, equipements);

                flowLayoutPanelChambres.Controls.Add(card);
            }
        }
    }
}
