using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using plantsVSzombies;
using PlantsVsZombies.MyPanel;

namespace PlantsVsZombies
{
    public partial class MainForm : Form
    {
        private Image image;
        private Image newBmp;
        private double _opacity = 0.0;
        private PictureEffect draw;
        private Graphics graphicsBmp;
        private Graphics graphicsPanel;

        private GamePanel gp;
        //数据模型
        private Map map;
        //控制器
        private Controller c;

        MusicControl mc = new MusicControl();

        private void GetImage()
        {
            image = new Bitmap("Images/logo.jpg");//image类型
            newBmp = new Bitmap(MainPanel.Width, MainPanel.Height);//image类型
            graphicsBmp = Graphics.FromImage(newBmp);//Graphics类型
            _opacity = 0.0;//double类型
            timer_logo.Interval = 1;//事件发生的频率
            timer_logo.Enabled = true;

        }


        public void init()
        {
            initController();
            initPanel();
            initMap();
        }

        //淡入淡出效果
        private void fadeOutIn()
        {
            if (_opacity <= 1.0)
            {
                draw.ChangeTransparency(image, graphicsBmp, newBmp.Size, _opacity);
                graphicsPanel.DrawImage(newBmp, MainPanel.ClientRectangle, 0, 0, newBmp.Width, newBmp.Height, GraphicsUnit.Pixel);
                _opacity = _opacity + 0.02;
            }
            else
            {
                draw.ChangeTransparency(image, graphicsBmp, newBmp.Size, 2 - _opacity);
                graphicsPanel.DrawImage(newBmp, MainPanel.ClientRectangle, 0, 0, newBmp.Width, newBmp.Height, GraphicsUnit.Pixel);
                _opacity = _opacity + 0.05;
            }
            if (2 - _opacity < 0.0 + 0.05 && 2 - _opacity > 0.0 - 0.05)
            {
                timer_logo.Enabled = false;
                MainPanel.Controls.Remove(MainPanel);
                initForm();
            }
        }

        private void timer_logo_Tick(object sender, EventArgs e)
        {
            fadeOutIn();
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (graphicsBmp != null)
            {
                graphicsBmp.Dispose();
            }
            if (graphicsPanel != null)
            {
                graphicsPanel.Dispose();
            }
        }

        public MainForm()
        {
            this.Size = new Size(800,600);
            InitializeComponent();
            draw = new PictureEffect();//淡入淡出
            graphicsPanel = MainPanel.CreateGraphics();//淡入淡出
            MusicControl.OpenBackMusic();
            init();
        }
        public void initForm()
        {
            WellcomeForm wf = new WellcomeForm();
            wf.TopLevel = false;
            MainPanel.Controls.Clear();
            MainPanel.Controls.Add(wf);
            wf.Dock = DockStyle.Fill;
            wf.Show();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            GetImage();
            MusicControl.playBackMusic();
            MusicControl.OpenButtonMusic();
        }


        private void initController()
        {
            c = new Controller();
        }

        private void initPanel()
        {
            gp = new GamePanel(c);
            gp.SetBounds(-120, 0, 1400, 600);
        }

        private void initMap()
        {
            map = new Map(gp);
            c.setMap(map);
        }

        internal void showMisson()
        {
            this.Controls.Clear();
            this.Controls.Add(gp);
            this.Size = new Size(900, 620);
        }
    }
}
