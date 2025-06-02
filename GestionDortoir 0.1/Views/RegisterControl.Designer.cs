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
            Guna.UI2.AnimatorNS.Animation animation1 = new Guna.UI2.AnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegisterControl));
            this.txtNom = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtEmail = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtPassword = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtConfirmPassword = new Guna.UI2.WinForms.Guna2TextBox();
            this.comboRole = new Guna.UI2.WinForms.Guna2ComboBox();
            this.btnRegister = new Guna.UI2.WinForms.Guna2Button();
            this.linkConnexion = new System.Windows.Forms.LinkLabel();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2CustomGradientPanel3 = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            this.guna2Separator1 = new Guna.UI2.WinForms.Guna2Separator();
            this.labelBienvenue = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.guna2HtmlLabel2 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2Transition1 = new Guna.UI2.WinForms.Guna2Transition();
            this.guna2CustomGradientPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNom
            // 
            this.txtNom.BackColor = System.Drawing.Color.Transparent;
            this.txtNom.BorderColor = System.Drawing.Color.Silver;
            this.txtNom.BorderRadius = 7;
            this.txtNom.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.guna2Transition1.SetDecoration(this.txtNom, Guna.UI2.AnimatorNS.DecorationType.None);
            this.txtNom.DefaultText = "";
            this.txtNom.FillColor = System.Drawing.Color.Silver;
            this.txtNom.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtNom.ForeColor = System.Drawing.Color.MidnightBlue;
            this.txtNom.Location = new System.Drawing.Point(42, 161);
            this.txtNom.Name = "txtNom";
            this.txtNom.PlaceholderForeColor = System.Drawing.Color.MidnightBlue;
            this.txtNom.PlaceholderText = "Nom complet";
            this.txtNom.SelectedText = "";
            this.txtNom.Size = new System.Drawing.Size(250, 40);
            this.txtNom.TabIndex = 0;
            // 
            // txtEmail
            // 
            this.txtEmail.BackColor = System.Drawing.Color.Transparent;
            this.txtEmail.BorderColor = System.Drawing.Color.Silver;
            this.txtEmail.BorderRadius = 7;
            this.txtEmail.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.guna2Transition1.SetDecoration(this.txtEmail, Guna.UI2.AnimatorNS.DecorationType.None);
            this.txtEmail.DefaultText = "";
            this.txtEmail.FillColor = System.Drawing.Color.Silver;
            this.txtEmail.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtEmail.ForeColor = System.Drawing.Color.MidnightBlue;
            this.txtEmail.Location = new System.Drawing.Point(42, 221);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.PlaceholderForeColor = System.Drawing.Color.MidnightBlue;
            this.txtEmail.PlaceholderText = "Adresse e-mail";
            this.txtEmail.SelectedText = "";
            this.txtEmail.Size = new System.Drawing.Size(250, 40);
            this.txtEmail.TabIndex = 1;
            // 
            // txtPassword
            // 
            this.txtPassword.BackColor = System.Drawing.Color.Transparent;
            this.txtPassword.BorderColor = System.Drawing.Color.Silver;
            this.txtPassword.BorderRadius = 7;
            this.txtPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.guna2Transition1.SetDecoration(this.txtPassword, Guna.UI2.AnimatorNS.DecorationType.None);
            this.txtPassword.DefaultText = "";
            this.txtPassword.FillColor = System.Drawing.Color.Silver;
            this.txtPassword.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtPassword.ForeColor = System.Drawing.Color.MidnightBlue;
            this.txtPassword.Location = new System.Drawing.Point(42, 278);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PlaceholderForeColor = System.Drawing.Color.MidnightBlue;
            this.txtPassword.PlaceholderText = "Mot de passe";
            this.txtPassword.SelectedText = "";
            this.txtPassword.Size = new System.Drawing.Size(250, 40);
            this.txtPassword.TabIndex = 2;
            this.txtPassword.UseSystemPasswordChar = true;
            // 
            // txtConfirmPassword
            // 
            this.txtConfirmPassword.BackColor = System.Drawing.Color.Transparent;
            this.txtConfirmPassword.BorderColor = System.Drawing.Color.Silver;
            this.txtConfirmPassword.BorderRadius = 7;
            this.txtConfirmPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.guna2Transition1.SetDecoration(this.txtConfirmPassword, Guna.UI2.AnimatorNS.DecorationType.None);
            this.txtConfirmPassword.DefaultText = "";
            this.txtConfirmPassword.FillColor = System.Drawing.Color.Silver;
            this.txtConfirmPassword.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtConfirmPassword.ForeColor = System.Drawing.Color.MidnightBlue;
            this.txtConfirmPassword.Location = new System.Drawing.Point(42, 337);
            this.txtConfirmPassword.Name = "txtConfirmPassword";
            this.txtConfirmPassword.PlaceholderForeColor = System.Drawing.Color.MidnightBlue;
            this.txtConfirmPassword.PlaceholderText = "Confirmer le mot de passe";
            this.txtConfirmPassword.SelectedText = "";
            this.txtConfirmPassword.Size = new System.Drawing.Size(250, 40);
            this.txtConfirmPassword.TabIndex = 3;
            this.txtConfirmPassword.UseSystemPasswordChar = true;
            // 
            // comboRole
            // 
            this.comboRole.BackColor = System.Drawing.Color.Transparent;
            this.comboRole.BorderColor = System.Drawing.Color.Silver;
            this.comboRole.BorderRadius = 7;
            this.guna2Transition1.SetDecoration(this.comboRole, Guna.UI2.AnimatorNS.DecorationType.None);
            this.comboRole.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comboRole.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboRole.FillColor = System.Drawing.Color.Silver;
            this.comboRole.FocusedColor = System.Drawing.Color.Empty;
            this.comboRole.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.comboRole.ForeColor = System.Drawing.Color.MidnightBlue;
            this.comboRole.ItemHeight = 30;
            this.comboRole.Items.AddRange(new object[] {
            "etudiant",
            "precepteur",
            "sous-precepteur",
            "visiteur"});
            this.comboRole.Location = new System.Drawing.Point(42, 394);
            this.comboRole.Name = "comboRole";
            this.comboRole.Size = new System.Drawing.Size(250, 36);
            this.comboRole.StartIndex = 0;
            this.comboRole.TabIndex = 4;
            // 
            // btnRegister
            // 
            this.btnRegister.BackColor = System.Drawing.Color.Transparent;
            this.btnRegister.BorderRadius = 7;
            this.guna2Transition1.SetDecoration(this.btnRegister, Guna.UI2.AnimatorNS.DecorationType.None);
            this.btnRegister.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(76)))), ((int)(((byte)(153)))));
            this.btnRegister.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.btnRegister.ForeColor = System.Drawing.Color.White;
            this.btnRegister.Image = ((System.Drawing.Image)(resources.GetObject("btnRegister.Image")));
            this.btnRegister.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btnRegister.ImageOffset = new System.Drawing.Point(5, 0);
            this.btnRegister.Location = new System.Drawing.Point(103, 446);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Padding = new System.Windows.Forms.Padding(5);
            this.btnRegister.Size = new System.Drawing.Size(113, 40);
            this.btnRegister.TabIndex = 5;
            this.btnRegister.Text = "S\'inscrire";
            this.btnRegister.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // linkConnexion
            // 
            this.linkConnexion.AutoSize = true;
            this.linkConnexion.BackColor = System.Drawing.Color.Transparent;
            this.guna2Transition1.SetDecoration(this.linkConnexion, Guna.UI2.AnimatorNS.DecorationType.None);
            this.linkConnexion.Font = new System.Drawing.Font("Arial Narrow", 9.75F);
            this.linkConnexion.Location = new System.Drawing.Point(166, 503);
            this.linkConnexion.Name = "linkConnexion";
            this.linkConnexion.Size = new System.Drawing.Size(69, 16);
            this.linkConnexion.TabIndex = 6;
            this.linkConnexion.TabStop = true;
            this.linkConnexion.Text = "Connectez ici";
            this.linkConnexion.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkConnexion_LinkClicked);
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2Transition1.SetDecoration(this.guna2HtmlLabel1, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(547, 653);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(272, 17);
            this.guna2HtmlLabel1.TabIndex = 7;
            this.guna2HtmlLabel1.Text = "© 2025 Gracia Andriamiarana. Tous droits réservés.";
            // 
            // guna2CustomGradientPanel3
            // 
            this.guna2CustomGradientPanel3.BorderColor = System.Drawing.Color.MidnightBlue;
            this.guna2CustomGradientPanel3.BorderRadius = 11;
            this.guna2CustomGradientPanel3.BorderThickness = 2;
            this.guna2CustomGradientPanel3.Controls.Add(this.guna2HtmlLabel2);
            this.guna2CustomGradientPanel3.Controls.Add(this.guna2Separator1);
            this.guna2CustomGradientPanel3.Controls.Add(this.labelBienvenue);
            this.guna2CustomGradientPanel3.Controls.Add(this.guna2PictureBox1);
            this.guna2CustomGradientPanel3.Controls.Add(this.txtNom);
            this.guna2CustomGradientPanel3.Controls.Add(this.linkConnexion);
            this.guna2CustomGradientPanel3.Controls.Add(this.txtEmail);
            this.guna2CustomGradientPanel3.Controls.Add(this.txtConfirmPassword);
            this.guna2CustomGradientPanel3.Controls.Add(this.btnRegister);
            this.guna2CustomGradientPanel3.Controls.Add(this.comboRole);
            this.guna2CustomGradientPanel3.Controls.Add(this.txtPassword);
            this.guna2Transition1.SetDecoration(this.guna2CustomGradientPanel3, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2CustomGradientPanel3.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(13)))), ((int)(((byte)(43)))));
            this.guna2CustomGradientPanel3.Location = new System.Drawing.Point(244, 63);
            this.guna2CustomGradientPanel3.Name = "guna2CustomGradientPanel3";
            this.guna2CustomGradientPanel3.Size = new System.Drawing.Size(879, 550);
            this.guna2CustomGradientPanel3.TabIndex = 8;
            // 
            // guna2Separator1
            // 
            this.guna2Separator1.BackColor = System.Drawing.Color.Transparent;
            this.guna2Transition1.SetDecoration(this.guna2Separator1, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Separator1.FillColor = System.Drawing.Color.MidnightBlue;
            this.guna2Separator1.FillThickness = 2;
            this.guna2Separator1.Location = new System.Drawing.Point(190, 100);
            this.guna2Separator1.Name = "guna2Separator1";
            this.guna2Separator1.Size = new System.Drawing.Size(95, 18);
            this.guna2Separator1.TabIndex = 11;
            // 
            // labelBienvenue
            // 
            this.labelBienvenue.BackColor = System.Drawing.Color.Transparent;
            this.guna2Transition1.SetDecoration(this.labelBienvenue, Guna.UI2.AnimatorNS.DecorationType.None);
            this.labelBienvenue.Font = new System.Drawing.Font("Times New Roman", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBienvenue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(76)))), ((int)(((byte)(153)))));
            this.labelBienvenue.Location = new System.Drawing.Point(103, 58);
            this.labelBienvenue.Name = "labelBienvenue";
            this.labelBienvenue.Size = new System.Drawing.Size(189, 47);
            this.labelBienvenue.TabIndex = 10;
            this.labelBienvenue.Text = "Inscription";
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.guna2PictureBox1.BorderRadius = 15;
            this.guna2Transition1.SetDecoration(this.guna2PictureBox1, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2PictureBox1.Dock = System.Windows.Forms.DockStyle.Right;
            this.guna2PictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("guna2PictureBox1.Image")));
            this.guna2PictureBox1.ImageRotate = 0F;
            this.guna2PictureBox1.Location = new System.Drawing.Point(329, 0);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.Size = new System.Drawing.Size(550, 550);
            this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.guna2PictureBox1.TabIndex = 7;
            this.guna2PictureBox1.TabStop = false;
            // 
            // guna2HtmlLabel2
            // 
            this.guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent;
            this.guna2Transition1.SetDecoration(this.guna2HtmlLabel2, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2HtmlLabel2.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel2.ForeColor = System.Drawing.Color.MidnightBlue;
            this.guna2HtmlLabel2.Location = new System.Drawing.Point(81, 502);
            this.guna2HtmlLabel2.Name = "guna2HtmlLabel2";
            this.guna2HtmlLabel2.Size = new System.Drawing.Size(85, 18);
            this.guna2HtmlLabel2.TabIndex = 12;
            this.guna2HtmlLabel2.Text = "Déjà un compte ?";
            // 
            // guna2Transition1
            // 
            this.guna2Transition1.AnimationType = Guna.UI2.AnimatorNS.AnimationType.Transparent;
            this.guna2Transition1.Cursor = null;
            animation1.AnimateOnlyDifferences = true;
            animation1.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.BlindCoeff")));
            animation1.LeafCoeff = 0F;
            animation1.MaxTime = 1F;
            animation1.MinTime = 0F;
            animation1.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicCoeff")));
            animation1.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicShift")));
            animation1.MosaicSize = 0;
            animation1.Padding = new System.Windows.Forms.Padding(0, 0, 0, 0);
            animation1.RotateCoeff = 0F;
            animation1.RotateLimit = 0F;
            animation1.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.ScaleCoeff")));
            animation1.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.SlideCoeff")));
            animation1.TimeCoeff = 0F;
            animation1.TransparencyCoeff = 1F;
            this.guna2Transition1.DefaultAnimation = animation1;
            // 
            // RegisterControl
            // 
            this.Controls.Add(this.guna2CustomGradientPanel3);
            this.Controls.Add(this.guna2HtmlLabel1);
            this.guna2Transition1.SetDecoration(this, Guna.UI2.AnimatorNS.DecorationType.None);
            this.Name = "RegisterControl";
            this.Size = new System.Drawing.Size(1366, 732);
            this.guna2CustomGradientPanel3.ResumeLayout(false);
            this.guna2CustomGradientPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel linkConnexion;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2CustomGradientPanel guna2CustomGradientPanel3;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private Guna.UI2.WinForms.Guna2Separator guna2Separator1;
        private Guna.UI2.WinForms.Guna2HtmlLabel labelBienvenue;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel2;
        private Guna.UI2.WinForms.Guna2Transition guna2Transition1;
    }
}
