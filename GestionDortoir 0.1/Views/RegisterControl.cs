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
    public partial class RegisterControl : UserControl
    {
        MainForm mainForm;
        public RegisterControl(MainForm form)
        {
            InitializeComponent();
            this.mainForm = form;
        }
        private void btnRegister_Click(object sender, EventArgs e)
        {
            // Vérification des champs obligatoires
            if (string.IsNullOrWhiteSpace(txtNom.Text) ||
                string.IsNullOrWhiteSpace(txtEmail.Text) ||
                string.IsNullOrWhiteSpace(txtPassword.Text) ||
                string.IsNullOrWhiteSpace(txtConfirmPassword.Text) ||
                comboRole.SelectedItem == null)
            {
                MessageBox.Show("Veuillez remplir tous les champs.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Validation simple de l'email
            if (!IsValidEmail(txtEmail.Text))
            {
                MessageBox.Show("L'adresse email n'est pas valide.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Vérification correspondance des mots de passe
            if (txtPassword.Text != txtConfirmPassword.Text)
            {
                MessageBox.Show("Les mots de passe ne correspondent pas !", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Optionnel : vérification longueur du mot de passe (ex: au moins 6 caractères)
            if (txtPassword.Text.Length < 6)
            {
                MessageBox.Show("Le mot de passe doit contenir au moins 6 caractères.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Préparation des données utilisateur
            string salt = AuthController.GenerateSalt();
            string hash = AuthController.HashPassword(txtPassword.Text, salt);

            Utilisateur user = new Utilisateur
            {
                Nom = txtNom.Text.Trim(),
                Email = txtEmail.Text.Trim(),
                Salt = salt,
                PasswordHash = hash,
                Role = comboRole.SelectedItem.ToString()
            };

            // Enregistrement en base
            if (AuthController.Register(user))
            {
                MessageBox.Show("Inscription réussie !", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
                // Tu peux ici vider le formulaire ou rediriger vers login
            }
            else
            {
                MessageBox.Show("Erreur lors de l'inscription. L'email est peut-être déjà utilisé.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Méthode utilitaire simple pour valider l'email
        private bool IsValidEmail(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }


        private void linkConnexion_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            mainForm.ShowControl(new LoginControl(mainForm));
        }
        
    }
}
