using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PlantsVsZombies
{
    public partial class HelpForm : Form
    {
        private MainForm mf;
        public HelpForm(MainForm mf)
        {
            this.mf = mf;
            InitializeComponent();
        }

        private void lbHelp_Click(object sender, EventArgs e)
        {
            MainForm mf = (MainForm)this.Parent.Parent;
            MenuForm menuf = new MenuForm(mf);
            mf.MainPanel.Controls.Clear();
            menuf.TopLevel = false;
            mf.MainPanel.Controls.Add(menuf);
            menuf.Show();

        }

        private void lbHelp_MouseEnter(object sender, EventArgs e)
        {
            lbHelp.Image = Image.FromFile("Images/HelpButton.jpg");
        }

        private void lbHelp_MouseLeave(object sender, EventArgs e)
        {
            lbHelp.Image = null;
        }
    }
}
