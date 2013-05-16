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
    public partial class QuitForm : Form
    {
        public QuitForm()
        {
            InitializeComponent();
        }

        private void labexit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #region  窗体移动
        private bool isMouseDown = false;
        private Point FormLocation;
        private Point mouseOffset;
        private void QuitForm_MouseDown(object sender, MouseEventArgs e)
        {

            if (e.Button == MouseButtons.Left)
            {
                isMouseDown = true;
                FormLocation = this.Location;
                mouseOffset = Control.MousePosition;
            }
        }

        private void QuitForm_MouseUp(object sender, MouseEventArgs e)
        {
            isMouseDown = false;
        }

        private void QuitForm_MouseMove(object sender, MouseEventArgs e)
        {
            int _x = 0;
            int _y = 0;
            if (isMouseDown)
            {
                Point pt = Control.MousePosition;
                _x = mouseOffset.X - pt.X;
                _y = mouseOffset.Y - pt.Y;

                this.Location = new Point(FormLocation.X - _x, FormLocation.Y - _y);
            }
        }
        #endregion
    }
}
