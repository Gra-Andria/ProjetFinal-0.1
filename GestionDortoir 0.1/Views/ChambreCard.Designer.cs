using Guna.UI2.WinForms;
using System.Drawing;
using System.Windows.Forms;

namespace GestionDortoir_0._1.Views
{
    partial class ChambreCard
    {
        private System.ComponentModel.IContainer components = null;

        private Guna2HtmlLabel lblNumero;
        private Guna2HtmlLabel lblCapacite;
        private Guna2Button lblDisponibilite;
        private ListBox lstOccupants;
        private ListBox lstEquipements;
        private Guna2Button btnAssigner;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblNumero = new Guna2HtmlLabel();
            this.lblCapacite = new Guna2HtmlLabel();
            this.lstOccupants = new ListBox();
            this.lstEquipements = new ListBox();
            this.btnAssigner = new Guna2Button();

            this.SuspendLayout();

            // UserControl
            this.Size = new Size(280, 340);
            this.BackColor = Color.White;

            // lblNumero
            this.lblNumero.Location = new Point(10, 10);
            this.lblNumero.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            this.lblNumero.Size = new Size(250, 25);
            this.lblNumero.BackColor = Color.Transparent;

           


            // lblCapacite
            this.lblCapacite.Location = new Point(120, 60);
            this.lblCapacite.Font = new Font("Segoe UI", 9F);
            this.lblCapacite.Size = new Size(100, 20);
            this.lblCapacite.BackColor = Color.Transparent;

            // lblDisponibilite
            this.lblDisponibilite = new Guna2Button();
            this.lblDisponibilite.Location = new Point(10, 85);
            this.lblDisponibilite.Size = new Size(100, 25);
            this.lblDisponibilite.Text = "Disponible";
            this.lblDisponibilite.FillColor = Color.MediumSeaGreen;
            this.lblDisponibilite.ForeColor = Color.White;
            this.lblDisponibilite.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            this.lblDisponibilite.BorderRadius = 6;
            this.lblDisponibilite.Enabled = false; // empêche le clic
            this.lblDisponibilite.Cursor = Cursors.Default;

            // lstOccupants
            this.lstOccupants.Location = new Point(10, 120);
            this.lstOccupants.Size = new Size(250, 60);

            // lstEquipements
            this.lstEquipements.Location = new Point(10, 190);
            this.lstEquipements.Size = new Size(250, 60);

            // btnAssigner
            this.btnAssigner.Location = new Point(10, 270);
            this.btnAssigner.Size = new Size(250, 40);
            this.btnAssigner.Text = "Assigner un étudiant";
            this.btnAssigner.FillColor = Color.MediumSlateBlue;
            this.btnAssigner.ForeColor = Color.White;
            this.btnAssigner.BorderRadius = 8;
            this.btnAssigner.Font = new Font("Segoe UI", 9F, FontStyle.Bold);

            // Ajouter les contrôles
            this.Controls.Add(this.lblNumero);
            this.Controls.Add(this.lblCapacite);
            this.Controls.Add(this.lblDisponibilite);
            this.Controls.Add(this.lstOccupants);
            this.Controls.Add(this.lstEquipements);
            this.Controls.Add(this.btnAssigner);

            this.ResumeLayout(false);
        }
    }
}
