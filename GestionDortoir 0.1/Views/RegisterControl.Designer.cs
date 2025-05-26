namespace GestionDortoir_0._1.Views
{
    partial class RegisterControl
    {
        private System.ComponentModel.IContainer components = null;

        private Guna.UI2.WinForms.Guna2TextBox txtNom;
        private Guna.UI2.WinForms.Guna2TextBox txtEmail;
        private Guna.UI2.WinForms.Guna2TextBox txtPassword;
        private Guna.UI2.WinForms.Guna2TextBox txtConfirmPassword;
        private Guna.UI2.WinForms.Guna2ComboBox comboRole;
        private Guna.UI2.WinForms.Guna2Button btnRegister;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        private void InitializeComponent()
        {
            this.txtNom = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtEmail = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtPassword = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtConfirmPassword = new Guna.UI2.WinForms.Guna2TextBox();
            this.comboRole = new Guna.UI2.WinForms.Guna2ComboBox();
            this.btnRegister = new Guna.UI2.WinForms.Guna2Button();
            this.linkConnexion = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // txtNom
            // 
            this.txtNom.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNom.DefaultText = "";
            this.txtNom.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtNom.Location = new System.Drawing.Point(91, 118);
            this.txtNom.Name = "txtNom";
            this.txtNom.PlaceholderText = "Nom complet";
            this.txtNom.SelectedText = "";
            this.txtNom.Size = new System.Drawing.Size(250, 36);
            this.txtNom.TabIndex = 0;
            // 
            // txtEmail
            // 
            this.txtEmail.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtEmail.DefaultText = "";
            this.txtEmail.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtEmail.Location = new System.Drawing.Point(91, 168);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.PlaceholderText = "Adresse e-mail";
            this.txtEmail.SelectedText = "";
            this.txtEmail.Size = new System.Drawing.Size(250, 36);
            this.txtEmail.TabIndex = 1;
            // 
            // txtPassword
            // 
            this.txtPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPassword.DefaultText = "";
            this.txtPassword.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtPassword.Location = new System.Drawing.Point(91, 218);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PlaceholderText = "Mot de passe";
            this.txtPassword.SelectedText = "";
            this.txtPassword.Size = new System.Drawing.Size(250, 36);
            this.txtPassword.TabIndex = 2;
            this.txtPassword.UseSystemPasswordChar = true;
            // 
            // txtConfirmPassword
            // 
            this.txtConfirmPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtConfirmPassword.DefaultText = "";
            this.txtConfirmPassword.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtConfirmPassword.Location = new System.Drawing.Point(91, 268);
            this.txtConfirmPassword.Name = "txtConfirmPassword";
            this.txtConfirmPassword.PlaceholderText = "Confirmer le mot de passe";
            this.txtConfirmPassword.SelectedText = "";
            this.txtConfirmPassword.Size = new System.Drawing.Size(250, 36);
            this.txtConfirmPassword.TabIndex = 3;
            this.txtConfirmPassword.UseSystemPasswordChar = true;
            // 
            // comboRole
            // 
            this.comboRole.BackColor = System.Drawing.Color.Transparent;
            this.comboRole.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comboRole.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboRole.FocusedColor = System.Drawing.Color.Empty;
            this.comboRole.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.comboRole.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.comboRole.ItemHeight = 30;
            this.comboRole.Items.AddRange(new object[] {
            "etudiant",
            "precepteur",
            "sous-precepteur",
            "visiteur"});
            this.comboRole.Location = new System.Drawing.Point(91, 318);
            this.comboRole.Name = "comboRole";
            this.comboRole.Size = new System.Drawing.Size(250, 36);
            this.comboRole.StartIndex = 0;
            this.comboRole.TabIndex = 4;
            // 
            // btnRegister
            // 
            this.btnRegister.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnRegister.ForeColor = System.Drawing.Color.White;
            this.btnRegister.Location = new System.Drawing.Point(141, 378);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(150, 40);
            this.btnRegister.TabIndex = 5;
            this.btnRegister.Text = "S\'inscrire";
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // linkConnexion
            // 
            this.linkConnexion.AutoSize = true;
            this.linkConnexion.Location = new System.Drawing.Point(175, 431);
            this.linkConnexion.Name = "linkConnexion";
            this.linkConnexion.Size = new System.Drawing.Size(84, 13);
            this.linkConnexion.TabIndex = 6;
            this.linkConnexion.TabStop = true;
            this.linkConnexion.Text = "Connectez-vous";
            this.linkConnexion.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkConnexion_LinkClicked);
            // 
            // RegisterControl
            // 
            this.Controls.Add(this.linkConnexion);
            this.Controls.Add(this.txtNom);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtConfirmPassword);
            this.Controls.Add(this.comboRole);
            this.Controls.Add(this.btnRegister);
            this.Name = "RegisterControl";
            this.Size = new System.Drawing.Size(900, 600);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel linkConnexion;
    }
}
