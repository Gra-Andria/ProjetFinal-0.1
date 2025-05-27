using GestionDortoir_0._1.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionDortoir_0._1
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            ShowControl(new LoginControl(this));

        }
        public void ShowControl(UserControl control)
        {
            mainPanel.Controls.Clear();
            control.Dock = DockStyle.Fill;
            mainPanel.Controls.Add(control);
        }

    }
}
