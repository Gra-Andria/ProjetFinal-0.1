using GestionDortoir_0._1.Controllers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows.Forms;

namespace GestionDortoir_0._1.Views
{
    public partial class LoginControl : UserControl
    {
        private MainForm mainForm;
        public LoginControl(MainForm form)
        {
            InitializeComponent();
            this.mainForm = form;
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            // Vérifier que les champs email et mot de passe sont remplis
            if (string.IsNullOrWhiteSpace(txtEmail.Text) || string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                MessageBox.Show("Veuillez entrer votre email et mot de passe.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Tentative de connexion
            var user = AuthController.Login(txtEmail.Text.Trim(), txtPassword.Text);

            if (user != null)
            {
                if (!user.EstActive)
                {
                    MessageBox.Show("Ce compte est désactivé. Contactez l'administrateur.", "Compte désactivé", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                MessageBox.Show($"Bienvenue {user.Nom} ({user.Role}) !", "Connexion réussie", MessageBoxButtons.OK, MessageBoxIcon.Information);
                // TODO : rediriger vers le dashboard ou autre interface selon le rôle
                switch (user.Role)
                {
                    case "precepteur":
                        mainForm.ShowControl(new DashboardPrecepteur(mainForm, user));
                        break;
                    default:
                        return;
                }
            }
            else
            {
                MessageBox.Show("Email ou mot de passe incorrect.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void linkRegister_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var register = new RegisterControl(mainForm);
            mainForm.ShowControl(register);
            guna2Transition1.ShowSync(register);
        }

    }
}
