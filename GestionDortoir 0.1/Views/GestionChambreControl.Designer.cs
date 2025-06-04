namespace GestionDortoir_0._1.Views
{
    partial class GestionChambreControl
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GestionChambreControl));
            this.tabControlChambre = new Guna.UI2.WinForms.Guna2TabControl();
            this.tabPlan = new System.Windows.Forms.TabPage();
            this.tabGestionChambre = new System.Windows.Forms.TabPage();
            this.flowLayoutPanelChambres = new System.Windows.Forms.FlowLayoutPanel();
            this.tabMateriels = new System.Windows.Forms.TabPage();
            this.tabAffectation = new System.Windows.Forms.TabPage();
            this.panelChambre = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.btnAjouter = new Guna.UI2.WinForms.Guna2Button();
            this.tabControlChambre.SuspendLayout();
            this.tabGestionChambre.SuspendLayout();
            this.tabAffectation.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControlChambre
            // 
            this.tabControlChambre.Alignment = System.Windows.Forms.TabAlignment.Left;
            this.tabControlChambre.Controls.Add(this.tabPlan);
            this.tabControlChambre.Controls.Add(this.tabGestionChambre);
            this.tabControlChambre.Controls.Add(this.tabMateriels);
            this.tabControlChambre.Controls.Add(this.tabAffectation);
            this.tabControlChambre.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlChambre.ItemSize = new System.Drawing.Size(180, 40);
            this.tabControlChambre.Location = new System.Drawing.Point(0, 0);
            this.tabControlChambre.Name = "tabControlChambre";
            this.tabControlChambre.SelectedIndex = 0;
            this.tabControlChambre.Size = new System.Drawing.Size(1166, 732);
            this.tabControlChambre.TabButtonHoverState.BorderColor = System.Drawing.Color.Empty;
            this.tabControlChambre.TabButtonHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(100)))), ((int)(((byte)(180)))));
            this.tabControlChambre.TabButtonHoverState.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.tabControlChambre.TabButtonHoverState.ForeColor = System.Drawing.Color.White;
            this.tabControlChambre.TabButtonHoverState.InnerColor = System.Drawing.Color.White;
            this.tabControlChambre.TabButtonIdleState.BorderColor = System.Drawing.Color.Empty;
            this.tabControlChambre.TabButtonIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.tabControlChambre.TabButtonIdleState.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.tabControlChambre.TabButtonIdleState.ForeColor = System.Drawing.Color.White;
            this.tabControlChambre.TabButtonIdleState.InnerColor = System.Drawing.Color.White;
            this.tabControlChambre.TabButtonSelectedState.BorderColor = System.Drawing.Color.Transparent;
            this.tabControlChambre.TabButtonSelectedState.FillColor = System.Drawing.Color.White;
            this.tabControlChambre.TabButtonSelectedState.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.tabControlChambre.TabButtonSelectedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(50)))), ((int)(((byte)(150)))));
            this.tabControlChambre.TabButtonSelectedState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.tabControlChambre.TabButtonSize = new System.Drawing.Size(180, 40);
            this.tabControlChambre.TabIndex = 1;
            this.tabControlChambre.TabMenuBackColor = System.Drawing.Color.Silver;
            // 
            // tabPlan
            // 
            this.tabPlan.Location = new System.Drawing.Point(184, 4);
            this.tabPlan.Name = "tabPlan";
            this.tabPlan.Padding = new System.Windows.Forms.Padding(3);
            this.tabPlan.Size = new System.Drawing.Size(978, 724);
            this.tabPlan.TabIndex = 0;
            this.tabPlan.Text = "Plan du dortoir";
            this.tabPlan.UseVisualStyleBackColor = true;
            // 
            // tabGestionChambre
            // 
            this.tabGestionChambre.Controls.Add(this.btnAjouter);
            this.tabGestionChambre.Controls.Add(this.flowLayoutPanelChambres);
            this.tabGestionChambre.Location = new System.Drawing.Point(184, 4);
            this.tabGestionChambre.Name = "tabGestionChambre";
            this.tabGestionChambre.Padding = new System.Windows.Forms.Padding(3);
            this.tabGestionChambre.Size = new System.Drawing.Size(978, 724);
            this.tabGestionChambre.TabIndex = 1;
            this.tabGestionChambre.Text = "Gestion des chambres";
            this.tabGestionChambre.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanelChambres
            // 
            this.flowLayoutPanelChambres.AutoScroll = true;
            this.flowLayoutPanelChambres.Location = new System.Drawing.Point(3, 61);
            this.flowLayoutPanelChambres.Name = "flowLayoutPanelChambres";
            this.flowLayoutPanelChambres.Padding = new System.Windows.Forms.Padding(15);
            this.flowLayoutPanelChambres.Size = new System.Drawing.Size(972, 620);
            this.flowLayoutPanelChambres.TabIndex = 0;
            // 
            // tabMateriels
            // 
            this.tabMateriels.Location = new System.Drawing.Point(184, 4);
            this.tabMateriels.Name = "tabMateriels";
            this.tabMateriels.Size = new System.Drawing.Size(978, 724);
            this.tabMateriels.TabIndex = 2;
            this.tabMateriels.Text = "Matériels & Equipements";
            this.tabMateriels.UseVisualStyleBackColor = true;
            // 
            // tabAffectation
            // 
            this.tabAffectation.Controls.Add(this.panelChambre);
            this.tabAffectation.Location = new System.Drawing.Point(184, 4);
            this.tabAffectation.Name = "tabAffectation";
            this.tabAffectation.Size = new System.Drawing.Size(978, 724);
            this.tabAffectation.TabIndex = 3;
            this.tabAffectation.Text = "Affectation & Réaffectation";
            this.tabAffectation.UseVisualStyleBackColor = true;
            // 
            // panelChambre
            // 
            this.panelChambre.Location = new System.Drawing.Point(20, 81);
            this.panelChambre.Name = "panelChambre";
            this.panelChambre.Size = new System.Drawing.Size(924, 624);
            this.panelChambre.TabIndex = 0;
            // 
            // btnAjouter
            // 
            this.btnAjouter.BorderColor = System.Drawing.Color.CornflowerBlue;
            this.btnAjouter.BorderRadius = 11;
            this.btnAjouter.BorderThickness = 2;
            this.btnAjouter.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAjouter.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAjouter.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAjouter.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAjouter.FillColor = System.Drawing.Color.LightBlue;
            this.btnAjouter.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.btnAjouter.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnAjouter.Image = ((System.Drawing.Image)(resources.GetObject("btnAjouter.Image")));
            this.btnAjouter.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnAjouter.ImageSize = new System.Drawing.Size(30, 30);
            this.btnAjouter.Location = new System.Drawing.Point(76, 10);
            this.btnAjouter.Name = "btnAjouter";
            this.btnAjouter.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.btnAjouter.Size = new System.Drawing.Size(117, 45);
            this.btnAjouter.TabIndex = 1;
            this.btnAjouter.Text = "Ajouter";
            // 
            // GestionChambreControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tabControlChambre);
            this.Name = "GestionChambreControl";
            this.Size = new System.Drawing.Size(1166, 732);
            this.tabControlChambre.ResumeLayout(false);
            this.tabGestionChambre.ResumeLayout(false);
            this.tabAffectation.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2TabControl tabControlChambre;
        private System.Windows.Forms.TabPage tabPlan;
        private System.Windows.Forms.TabPage tabGestionChambre;
        private System.Windows.Forms.TabPage tabMateriels;
        private System.Windows.Forms.TabPage tabAffectation;
        private Guna.UI2.WinForms.Guna2GradientPanel panelChambre;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelChambres;
        private Guna.UI2.WinForms.Guna2Button btnAjouter;
    }
}
