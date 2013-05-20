using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace PlantsVsZombies
{
    class ProgressBar
    {
        Rectangle rec_Circle;//将草圈画在此矩形中
        Rectangle rec_bar;//将草坪画在此矩形中
        Image image;
        Image image_bar;

        int n = 0;
        public ProgressBar()
        {
            rec_Circle = new Rectangle(228, 483, 64, 61);
            rec_bar = new Rectangle(238, 490, 0, 55);
            image = Image.FromFile("Images/grassCircle.png");
            image_bar = Image.FromFile("Images/grassbar.jpg");

        }
        public void nextAction()
        {
            if (rec_Circle.X >= 540)
            {
                return;
            }
            rec_bar.Width += 15;
            rec_Circle.X += 15;
            rec_Circle.Y += 1;
            rec_Circle.Height -= 1;
            rec_Circle.Width -= 1;
        }

        public int getX()
        {
            return rec_Circle.X;
        }

        public void display(Graphics g)
        {
            g.DrawImageUnscaledAndClipped(image_bar, rec_bar);
            if (rec_Circle.X <= 540)
            {
                switch (n)
                {

                    case 1: g.DrawImage(image, rec_Circle); break;


                    case 2: image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                        g.DrawImage(image, rec_Circle); break;

                    case 3: image.RotateFlip(RotateFlipType.Rotate180FlipNone);
                        g.DrawImage(image, rec_Circle); break;
                    default: image.RotateFlip(RotateFlipType.Rotate270FlipNone);
                        g.DrawImage(image, rec_Circle); n = 0; break;

                }
            }
        }
    }
}
