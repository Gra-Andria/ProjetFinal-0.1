using GestionDortoir_0._1.Controllers;
using GestionDortoir_0._1.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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

            // Validation email
            if (!IsValidEmail(txtEmail.Text))
            {
                MessageBox.Show("L'adresse email n'est pas valide.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Vérification  mots de passe pareil
            if (txtPassword.Text != txtConfirmPassword.Text)
            {
                MessageBox.Show("Les mots de passe ne correspondent pas !", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Validation mot de passe 
            if (!IsValidPassword(txtPassword.Text))
            {
                MessageBox.Show("Le mot de passe doit contenir au moins 8 caractères, dont une majuscule, une minuscule, un chiffre et un caractère spécial.",
                                "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Préparation des données 
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

            // Enregistrement 
            if (AuthController.Register(user))
            {
                MessageBox.Show("Inscription réussie !", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
                var login = new LoginControl(mainForm);
                mainForm.ShowControl(login);
                guna2Transition1.ShowSync(login);
            }
            else
            {
                MessageBox.Show("Erreur lors de l'inscription. L'email est peut-être déjà utilisé.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //Validation email
        private bool IsValidEmail(string email)
        {
            string forme = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";
            return Regex.IsMatch(email, forme);
        }
        //Validation mot de passe 
        private bool IsValidPassword(string password)
        {
            string pattern = @"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[^\da-zA-Z]).{8,}$";
            return Regex.IsMatch(password, pattern);
        }

        private void linkConnexion_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var login = new LoginControl(mainForm);        
            mainForm.ShowControl(login);                    
            guna2Transition1.ShowSync(login);
        }

    }
}
