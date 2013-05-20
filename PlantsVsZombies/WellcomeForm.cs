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
    public partial class WellcomeForm : Form
    {
        public WellcomeForm()
        {
            InitializeComponent();
            ///
            //防止闪屏
            ///
            SetStyle(ControlStyles.AllPaintingInWmPaint, true);
            SetStyle(ControlStyles.UserPaint, true);
            SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
        }

        private void timer_title_Tick(object sender, EventArgs e)
        {
            Point ptLocationTitel = picTitle.Location;
            if (ptLocationTitel.Y >= 6)
            {
                timer_title.Enabled = false;
            }
            else
            {
                ptLocationTitel.Y += 14;
                picTitle.Location = ptLocationTitel;
            }
        }
        private void WellcomeForm_Load(object sender, EventArgs e)
        {
            timer_title.Enabled = true;
            timer1_grassCircle.Enabled = true;//picturebox开始移动
        }

        private void labStart_MouseEnter(object sender, EventArgs e)
        {
            labStart.Image = Image.FromFile("Images/interface/start.png");
        }

        private void labStart_MouseLeave(object sender, EventArgs e)
        {
            labStart.Image = null;
        }

        private void labStart_Click(object sender, EventArgs e)
        {
            MainForm mf = (MainForm)this.Parent.Parent;
            MenuForm menuf = new MenuForm(mf);
            mf.MainPanel.Controls.Clear();
            menuf.TopLevel = false;
            mf.MainPanel.Controls.Add(menuf);
            menuf.Show();
        }

        ProgressBar bar = new ProgressBar();
        Rectangle rec = new Rectangle(230, 484, 64, 61);//将图片画在此矩形中
        Image image_grassCircle = Image.FromFile("Images/grassCircle.png");

        private void timer1_grassCircle_Tick(object sender, EventArgs e)
        {
            bar.nextAction();
            this.Invalidate();
        }


        private void WellcomeForm_Paint(object sender, PaintEventArgs e)
        {
            bar.display(e.Graphics);
        }
    }
}
