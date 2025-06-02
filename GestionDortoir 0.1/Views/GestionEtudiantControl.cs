using GestionDortoir_0._1.Controllers;
using GestionDortoir_0._1.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionDortoir_0._1.Views
{
    public partial class GestionEtudiantControl : UserControl
    {
        private EtudiantController controller = new EtudiantController();
        public GestionEtudiantControl()
        {
            InitializeComponent();
        }

        private void btnEnregistrer_Click(object sender, EventArgs e)
        {
            //Verification des champs obligatoires
            if (string.IsNullOrEmpty(textBoxNomEtudiant.Text)||
                string.IsNullOrEmpty(textBoxMatricule.Text)|| 
                string.IsNullOrEmpty(textBoxAnneeEtude.Text)||
                string.IsNullOrEmpty(Combofiliere.Text))
            {
                MessageBox.Show("Veuillez remplir tous les champs requis.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            //Création de l'étudiant
            var etu = new Etudiants()
            {
                Matricule = int.Parse(textBoxMatricule.Text),
                Nom = textBoxNomEtudiant.Text,
                Prenom = textBoxPrenomEtudiant.Text,
                Filiere = Combofiliere.Text,
                DateNaissance = dateDeNaissance.Value,
                LieuNaissance = textBoxLieuNaissance.Text,
                Picture = pictureBoxEtudiant.Image != null ? ImageToByteArray(pictureBoxEtudiant.Image) : null,
                NomPere = textNomPere.Text,
                ProfessionPere = textProfPere.Text,
                NomMere = textNomMere.Text,
                ProfessionMere = textProfMere.Text,
                AnneeEtude = textBoxAnneeEtude.Text,
                NumeroEtudiant = textNumEtudiant.Text,
                NumeroTelPere = textNumPere.Text,
                NumeroTelMere = textNumMere.Text,
                NomTuteur = textNomTuteur.Text,
                ProfessionTuteur = textProfTuteur.Text,
                NumeroTelTuteur = textNumTuteur.Text,
                AdresseParent = textAdresseParent.Text,
                AdresseTuteur = textAdresseTuteur.Text,
            };
            //Enregistrement
            var controller = new EtudiantController();
            if (controller.EnregistrerEtudiant(etu))
            {
                MessageBox.Show("Étudiant enregistré avec succès !");
                ResetForm();
            }
            
        }
        //Fonction pour reinitialiser les champs 
        private void ResetForm()
        {
            textBoxMatricule.Clear();
            textBoxNomEtudiant.Clear();
            textBoxPrenomEtudiant.Clear();
            textBoxLieuNaissance.Clear();
            textNomPere.Clear();
            textProfPere.Clear();
            textNomMere.Clear();
            textProfMere.Clear();
            textBoxAnneeEtude.Clear();
            textNumEtudiant.Clear();
            textNumPere.Clear();
            textNumMere.Clear();
            textNomTuteur.Clear();
            textProfTuteur.Clear();
            textNumTuteur.Clear();
            textAdresseParent.Clear();
            textAdresseTuteur.Clear();

            Combofiliere.SelectedIndex = -1;
            dateDeNaissance.MaxDate = DateTime.Today;
            dateDeNaissance.Value = DateTime.Today;

            pictureBoxEtudiant.Image = null;

            textBoxMatricule.Focus();
        }
        //Ouvre le dossier et ajoute l'image
        private void btnPhoto_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog()) {
                ofd.Filter = "Images (*.jpg;*.jpeg;*.png)|*.jpg;*.jpeg;*.png";
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    pictureBoxEtudiant.Image = Image.FromFile(ofd.FileName);
                }
            }
        }
        // Conversion de l'image en byte
        private byte[] ImageToByteArray(Image image)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                image.Save(ms, image.RawFormat);
                return ms.ToArray();
            }
        }
        //Réinitialiser les champs (boutton)
        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            ResetForm();
        }

        private void GestionEtudiantControl_Load(object sender, EventArgs e)
        {
            ChargerEtudiants();
        }
        private void ChargerEtudiants()
        {
            List<Etudiants> liste = controller.GetAllEtudiants();

            dataGridViewEtudiants.DataSource = liste;

            //Pas visible
            dataGridViewEtudiants.Columns["Picture"].Visible = false;
            dataGridViewEtudiants.Columns["LieuNaissance"].Visible = false;
            dataGridViewEtudiants.Columns["NomPere"].Visible = false;
            dataGridViewEtudiants.Columns["ProfessionPere"].Visible = false;
            dataGridViewEtudiants.Columns["NomMere"].Visible = false;
            dataGridViewEtudiants.Columns["ProfessionMere"].Visible = false;
            dataGridViewEtudiants.Columns["NumeroTelPere"].Visible = false;
            dataGridViewEtudiants.Columns["NumeroTelMere"].Visible = false;
            dataGridViewEtudiants.Columns["NomTuteur"].Visible = false;
            dataGridViewEtudiants.Columns["ProfessionTuteur"].Visible = false;
            dataGridViewEtudiants.Columns["NumeroTelTuteur"].Visible = false;
            dataGridViewEtudiants.Columns["AdresseParent"].Visible = false;
            dataGridViewEtudiants.Columns["AdresseTuteur"].Visible = false;
            dataGridViewEtudiants.Columns["NumeroEtudiant"].Visible = false;
            //Visible
            dataGridViewEtudiants.Columns["Matricule"].HeaderText = "Matricule";
            dataGridViewEtudiants.Columns["Nom"].HeaderText = "Nom";
            dataGridViewEtudiants.Columns["Prenom"].HeaderText = "Prénom";
            dataGridViewEtudiants.Columns["Filiere"].HeaderText = "Filière";
            dataGridViewEtudiants.Columns["DateNaissance"].HeaderText = "Date de naissance";
            dataGridViewEtudiants.Columns["AnneeEtude"].HeaderText = "Année d’étude";
        }

        private void GestionEtudiantControl_Load_1(object sender, EventArgs e)
        {
            var liste = controller.GetAllEtudiants();
            MessageBox.Show("Nombre d'étudiants : " + liste.Count);
            ChargerEtudiants();
        }
    }
}
