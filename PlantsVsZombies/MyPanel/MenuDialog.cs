using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;
using PlantsVsZombies.MyPanel;

namespace PlantsVsZombies
{
    class MenuDialog : Panel
    {
        private GamePanel p;

        public MenuDialog(GamePanel p)
        {
            this.p = p;
            this.BackColor = System.Drawing.Color.Transparent;
            this.SetStyle(ControlStyles.OptimizedDoubleBuffer | ControlStyles.ResizeRedraw |
                ControlStyles.AllPaintingInWmPaint, true);
            this.Paint += new PaintEventHandler(MenuDialog2_Paint);

            initImage();
            initButton();
        }

        private void initButton()
        {
            //
            //  第一个按钮
            //
            Restart = new MyButton("重新开始");
            Restart.SetBounds(150,60,113,41);
            Restart.MouseUp += new MouseEventHandler(p.GamePanel_MouseClick);
            Restart.MouseMove += new MouseEventHandler(MenuDialog_MouseMove);
            //
            //  第二个按钮
            //
            FirstLevel = new MyButton("第一关");
            FirstLevel.SetBounds(90, 130, 113, 41);
            FirstLevel.MouseUp += new MouseEventHandler(p.GamePanel_MouseClick);
            FirstLevel.MouseMove += new MouseEventHandler(MenuDialog_MouseMove);
            //
            //  第三个按钮
            //
            SecondLevel = new MyButton("第二关");
            SecondLevel.SetBounds(210, 130, 113, 41);
            SecondLevel.MouseUp += new MouseEventHandler(p.GamePanel_MouseClick);
            SecondLevel.MouseMove += new MouseEventHandler(MenuDialog_MouseMove);
            //
            //  backGame
            //
            backGame = new Label();
            backGame.Text = "返回游戏";
            backGame.Font = new Font("正楷",15);
            backGame.SetBounds(180,450,60,50);
            backGame.MouseUp += new MouseEventHandler(p.GamePanel_MouseClick);

            this.Controls.Add(Restart);
            this.Controls.Add(FirstLevel);
            this.Controls.Add(SecondLevel);
            this.Controls.Add(backGame);
            this.MouseMove += new MouseEventHandler(MenuDialog_MouseMove);
        }

        public void initImage()
        {
            dialog_bottomleft = Image.FromFile("Images/interface/dialog_bottomleft.png");
            dialog_bottomiddle = Image.FromFile("Images/interface/dialog_bottommiddle.png");
            dialog_bottomright = Image.FromFile("Images/interface/dialog_bottomright.png");
            dialog_centerleft = Image.FromFile("Images/interface/dialog_centerleft.png");
            dialog_centermiddle = Image.FromFile("Images/interface/dialog_centermiddle.png");
            dialog_centerright = Image.FromFile("Images/interface/dialog_centerright.png");
            dialog_topleft = Image.FromFile("Images/interface/dialog_topleft.png");
            dialog_topmiddle = Image.FromFile("Images/interface/dialog_topmiddle.png");
            dialog_topright = Image.FromFile("Images/interface/dialog_topright.png");
        }
     
        public void MenuDialog2_Paint(Object sender,PaintEventArgs e)
        {
            System.Drawing.Graphics g = e.Graphics;
            //绘制背景
            DrawBackground(g);
        }

        private void DrawBackground(System.Drawing.Graphics g)
        {
            g.DrawImage(dialog_topleft, 0, 0, 107, 97);
            g.DrawImage(dialog_topmiddle, 107, 0, 93, 97);
            g.DrawImage(dialog_topmiddle, 200, 0, 93, 97);
            g.DrawImage(dialog_topright, 293, 0, 120, 97);
            g.DrawImage(dialog_centerleft, 0, 97, 107, 54);
            g.DrawImage(dialog_centermiddle, 107, 97, 93, 54);
            g.DrawImage(dialog_centermiddle, 200, 97, 93, 54);
            g.DrawImage(dialog_centerright, 293, 97, 105, 54);
            g.DrawImage(dialog_centerleft, 0, 151, 107, 54);
            g.DrawImage(dialog_centermiddle, 107, 151, 93, 54);
            g.DrawImage(dialog_centermiddle, 200, 151, 93, 54);
            g.DrawImage(dialog_centerright, 293, 151, 105, 54);
            g.DrawImage(dialog_centerleft, 0, 205, 107, 54);
            g.DrawImage(dialog_centermiddle, 107, 205, 93, 54);
            g.DrawImage(dialog_centermiddle, 200, 205, 93, 54);
            g.DrawImage(dialog_centerright, 293, 205, 105, 54);
            g.DrawImage(dialog_centerleft, 0, 259, 107, 54);
            g.DrawImage(dialog_centermiddle, 107, 259, 93, 54);
            g.DrawImage(dialog_centermiddle, 200, 259, 93, 54);
            g.DrawImage(dialog_centerright, 293, 259, 105, 54);
            g.DrawImage(dialog_centerleft, 0, 313, 107, 54);
            g.DrawImage(dialog_centermiddle, 107, 313, 93, 54);
            g.DrawImage(dialog_centermiddle, 200, 313, 93, 54);
            g.DrawImage(dialog_centerright, 293, 313, 105, 54);
            g.DrawImage(dialog_centerleft, 0, 367, 107, 54);
            g.DrawImage(dialog_centermiddle, 107, 367, 93, 54);
            g.DrawImage(dialog_centermiddle, 200, 367, 93, 54);
            g.DrawImage(dialog_centerright, 293, 367, 105, 54);
            g.DrawImage(dialog_bottomleft, 0, 421, 107, 97);
            g.DrawImage(dialog_bottomiddle, 107, 421, 93, 97);
            g.DrawImage(dialog_bottomiddle, 200, 421, 93, 97);
            g.DrawImage(dialog_bottomright, 293, 421, 108, 97);
        }


        public void MenuDialog_MouseMove(Object o, MouseEventArgs e)
        {
            if (o is MyButton || o is Label)
                Cursor = Cursors.Hand;
            else
                Cursor = Cursors.Arrow;
        }

        private Image dialog_bottomleft;
        private Image dialog_bottomiddle;
        private Image dialog_bottomright;
        private Image dialog_centermiddle;
        private Image dialog_centerleft;
        private Image dialog_centerright;
        private Image dialog_topleft;
        private Image dialog_topmiddle;
        private Image dialog_topright;
        private MyButton Restart;
        private MyButton FirstLevel;
        private MyButton SecondLevel;
        private Label backGame;
    }
}
