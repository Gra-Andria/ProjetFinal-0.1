using GestionDortoir_0._1.Controllers;
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
            LoadChambres();
        }
        private void LoadChambres()
        {
            var chambres = ChambreController.GetAllChambres();
            foreach (var chambre in chambres)
            {
                var card = new ChambreCard(chambre);
                panelChambre.Controls.Add(card);
            }
        }
    }
}
