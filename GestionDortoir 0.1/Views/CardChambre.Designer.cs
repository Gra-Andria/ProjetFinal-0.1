namespace GestionDortoir_0._1.Views
{
    partial class CardChambre
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
            this.lblNumero = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblCapacite = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblRemarque = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lstEquipements = new System.Windows.Forms.FlowLayoutPanel();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2Panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblNumero
            // 
            this.lblNumero.BackColor = System.Drawing.Color.Transparent;
            this.lblNumero.Location = new System.Drawing.Point(24, 44);
            this.lblNumero.Name = "lblNumero";
            this.lblNumero.Size = new System.Drawing.Size(40, 15);
            this.lblNumero.TabIndex = 0;
            this.lblNumero.Text = "Numero";
            // 
            // lblCapacite
            // 
            this.lblCapacite.BackColor = System.Drawing.Color.Transparent;
            this.lblCapacite.Location = new System.Drawing.Point(179, 44);
            this.lblCapacite.Name = "lblCapacite";
            this.lblCapacite.Size = new System.Drawing.Size(45, 15);
            this.lblCapacite.TabIndex = 1;
            this.lblCapacite.Text = "Capacité";
            // 
            // lblRemarque
            // 
            this.lblRemarque.BackColor = System.Drawing.Color.Transparent;
            this.lblRemarque.Location = new System.Drawing.Point(24, 104);
            this.lblRemarque.Name = "lblRemarque";
            this.lblRemarque.Size = new System.Drawing.Size(52, 15);
            this.lblRemarque.TabIndex = 2;
            this.lblRemarque.Text = "Remarque";
            // 
            // lstEquipements
            // 
            this.lstEquipements.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lstEquipements.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstEquipements.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lstEquipements.Location = new System.Drawing.Point(24, 153);
            this.lstEquipements.Name = "lstEquipements";
            this.lstEquipements.Size = new System.Drawing.Size(200, 100);
            this.lstEquipements.TabIndex = 3;
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.LightCyan;
            this.guna2Panel1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.guna2Panel1.BorderRadius = 11;
            this.guna2Panel1.BorderThickness = 2;
            this.guna2Panel1.Controls.Add(this.lblNumero);
            this.guna2Panel1.Controls.Add(this.lstEquipements);
            this.guna2Panel1.Controls.Add(this.lblCapacite);
            this.guna2Panel1.Controls.Add(this.lblRemarque);
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2Panel1.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(250, 300);
            this.guna2Panel1.TabIndex = 4;
            // 
            // CardChambre
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.Controls.Add(this.guna2Panel1);
            this.Name = "CardChambre";
            this.Size = new System.Drawing.Size(250, 300);
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2HtmlLabel lblNumero;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblCapacite;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblRemarque;
        private System.Windows.Forms.FlowLayoutPanel lstEquipements;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
    }
}
