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
    public partial class MenuForm : Form
    {
        public MenuForm()
        {
            InitializeComponent();
        }
        MusicControl mc = new MusicControl();

        private void picXuan_MouseEnter(object sender, EventArgs e)
        {
            picXuan.Image = Image.FromFile("Images/interface/xuanxiang1.png");
            MusicControl.playButtonMusic();
        }

        private void picXuan_MouseLeave(object sender, EventArgs e)
        {
            picXuan.Image = Image.FromFile("Images/interface/xuanxiang.png");
            MusicControl.stopButtonMusic();
        }

        private void picExit_MouseEnter(object sender, EventArgs e)
        {
            picExit.Image = Image.FromFile("Images/interface/menuexit1.png");
            MusicControl.stopBackMusic();
        }

        private void picExit_MouseLeave(object sender, EventArgs e)
        {
            picExit.Image = Image.FromFile("Images/interface/menuexit.png");
            MusicControl.playBackMusic();
        }

        private void picMenuHelp_MouseEnter(object sender, EventArgs e)
        {
            picMenuHelp.Image = Image.FromFile("Images/interface/menuhelp.png");
            MusicControl.playButtonMusic();
        }

        private void picMenuHelp_MouseLeave(object sender, EventArgs e)
        {
            picMenuHelp.Image = Image.FromFile("Images/interface/menuhelp1.png");
            MusicControl.stopButtonMusic();
        }

        private void MenuForm_Load(object sender, EventArgs e)
        {
            timer_all.Enabled = true; 
        }
        #region 左边菜单
        //掉下来
        private void timer_all_Tick(object sender, EventArgs e)
        {
            Point ptLocationWellcome = picWellcome.Location;//定义一个点，更改picWellcome坐标
            Point ptLocationClick = picClickMe.Location;//定义一个点，更改picClickMe坐标
            if (picWellcome.Location.Y >= 0 )
            {
                timer_all.Enabled=false;
                timer_ClickMe.Enabled = true;
            }
            else
            {
                ptLocationWellcome.Y += 10;
                picWellcome.Location = ptLocationWellcome;
                ptLocationClick.Y += 10;
                picClickMe.Location = ptLocationClick;
            } 
        }
        //惯性
        private void timer_ClickMe_Tick(object sender, EventArgs e)
        {
            Point ptLocationWellcome = picWellcome.Location;//定义一个点，更改picWellcome坐标
            Point ptLocationClick = picClickMe.Location;//定义一个点，更改picClickMe坐标

            ptLocationWellcome.Y -= 2;
            picWellcome.Location = ptLocationWellcome;

            ptLocationClick.Y += 2;
            picClickMe.Location = ptLocationClick;

            if (ptLocationWellcome.Y <= -6)
            {
                timer_ClickMe.Enabled = false;
                timerLast.Enabled = true;
            }
        }

        //上升到原来位置
        private void timerLast_Tick(object sender, EventArgs e)
        {
            Point ptLocationClick = picClickMe.Location;//定义一个点，更改picClickMe坐标
            ptLocationClick.Y -= 2;
            picClickMe.Location = ptLocationClick;

            if (ptLocationClick.Y <= 138)
            {
                timerLast.Enabled = false;
            }
        }
        #endregion
        private void picClickMe_MouseEnter(object sender, EventArgs e)
        {
            picClickMe.Image = Image.FromFile("Images/SelectorScreen_WoodSign2_press.png");
        }

        private void picClickMe_MouseLeave(object sender, EventArgs e)
        {
            picClickMe.Image = Image.FromFile("Images/SelectorScreen_WoodSign2.png");
        }

        private void picExit_Click(object sender, EventArgs e)
        {
            QuitForm qf = new QuitForm();
            qf.Show();
        }
        #region  绘制多边形
        private void MenuForm_Paint(object sender, PaintEventArgs e)
        {
            //初始化一个GraphicsPath类的对象,label_risk
            System.Drawing.Drawing2D.GraphicsPath riskGraphicsPath = new System.Drawing.Drawing2D.GraphicsPath();
            Point[] riskpoint = { new Point(0, 0), new Point(0, 80), new Point(90, 100), new Point(150, 114), new Point(330, 114), new Point(330, 0) };
            riskGraphicsPath.AddPolygon(riskpoint);
            //将控件的Region属性设置为上面创建的GraphicsPath对象
            labMao.Region = new Region(riskGraphicsPath);

            //label_easygame
            System.Drawing.Drawing2D.GraphicsPath easygameGraphicsPath = new System.Drawing.Drawing2D.GraphicsPath();
            Point[] point = { new Point(0, 0), new Point(0, 80), new Point(303, 129), new Point(303, 40) };
            easygameGraphicsPath.AddPolygon(point);
            //将控件的Region属性设置为上面创建的GraphicsPath对象
            labSmall.Region = new Region(easygameGraphicsPath);
        }
      #endregion

        private void labMao_MouseEnter(object sender, EventArgs e)
        {
            labMao.Image = Image.FromFile("Images/interface/mao.png");
            MusicControl.playButtonMusic();
            labMao.Update();
        }

        private void labMao_MouseLeave(object sender, EventArgs e)
        {
            labMao.Image = null;
            MusicControl.stopButtonMusic();
        }

        private void labSmall_MouseEnter(object sender, EventArgs e)
        {
            labSmall.Image = Image.FromFile("Images/interface/small.png");
            MusicControl.playButtonMusic();
        }

        private void labSmall_MouseLeave(object sender, EventArgs e)
        {
            labSmall.Image = null;
            MusicControl.stopButtonMusic();
        }

        private void labTujian_MouseEnter(object sender, EventArgs e)
        {
            labTujian.Image = Image.FromFile("Images/interface/tujian.png");
            MusicControl.playButtonMusic();
        }

        private void labTujian_MouseLeave(object sender, EventArgs e)
        {
            labTujian.Image = null;
            MusicControl.stopButtonMusic();
        }

        private void labShop_MouseEnter(object sender, EventArgs e)
        {
            labShop.Image = Image.FromFile("Images/interface/shop.png");
            MusicControl.playButtonMusic();
        }

        private void labShop_MouseLeave(object sender, EventArgs e)
        {
            labShop.Image = null;
            MusicControl.stopButtonMusic();
        }

        private void picClickMe_MouseEnter_1(object sender, EventArgs e)
        {
            picClickMe.Image = Image.FromFile("Images/SelectorScreen_WoodSign2_press.png");
            MusicControl.playButtonMusic();
        }

        private void picClickMe_MouseLeave_1(object sender, EventArgs e)
        {
            picClickMe.Image = Image.FromFile("Images/SelectorScreen_WoodSign2.png");
            MusicControl.stopButtonMusic();
        }

        
    }
}
