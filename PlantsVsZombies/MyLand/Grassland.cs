using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace PlantsVsZombies.MyLand
{
    class Grassland
    {
        private Point grass2StartLocation;
        private Point grass3StartLocation;
        private Point grass4StartLocation;
        private Point Roll2Location;
        private Point RollCop2Location;
        private Point Roll3Location;
        private Point RollCop3Location;
        private Point Roll4Location;
        private Point RollCop4Location;
        private Image imageGrassLand2;
        private Image imageGrassLand3;
        private Image imageGrassLand4;
        private Image imageGround;
        private Image imageRoll;
        private Rectangle r2;
        private Rectangle r3;
        private Rectangle r4;

        public Grassland()
        {
            grass2StartLocation = new Point(210, 215);
            grass3StartLocation = new Point(210, 345);
            grass4StartLocation = new Point(210, 475);
            Roll2Location = new Point(190, 210);
            RollCop2Location = new Point(190, 310);
            Roll3Location = new Point(190, 340);
            RollCop3Location = new Point(190, 440);
            Roll4Location = new Point(190, 470);
            RollCop4Location = new Point(190, 570);
            imageGrassLand2 = Image.FromFile("Images/interface/sod1row.png");
            imageGrassLand3 = Image.FromFile("Images/interface/sod1row2.png");
            imageGrassLand4 = Image.FromFile("Images/interface/sod1row3.png");
            imageGround = Image.FromFile("Images/interface/SodRoll.png");
            imageRoll = Image.FromFile("Images/interface/SodRollCap.png");
            r2 = new Rectangle();
            r2.Height = imageGrassLand2.Height;
            r2.Location = grass2StartLocation;
            r3 = new Rectangle();
            r3.Height = imageGrassLand3.Height;
            r3.Location = grass3StartLocation;
            r4 = new Rectangle();
            r4.Height = imageGrassLand4.Height;
            r4.Location = grass4StartLocation;
        }

        int length = 0;
        public void nextAction()
        {
            if (length >= 620) { return; }
            Roll2Location.X += 10;
            Roll3Location.X += 10;
            Roll4Location.X += 10;
            RollCop2Location.X += 10;
            RollCop3Location.X += 10;
            RollCop4Location.X += 10;
            length += 10;
            r2.Width = length;
            r3.Width = length;
            r4.Width = length;
        }

        public void display(Graphics g)
        {
            g.DrawImageUnscaledAndClipped(imageGrassLand2, r2);
            g.DrawImageUnscaledAndClipped(imageGrassLand3, r3);
            g.DrawImageUnscaledAndClipped(imageGrassLand3, r4);
            if (length < 620)
            {
                g.DrawImage(imageGround, Roll2Location);
                g.DrawImage(imageRoll, RollCop2Location);
                g.DrawImage(imageGround, Roll3Location);
                g.DrawImage(imageRoll, RollCop3Location);
                g.DrawImage(imageGround, Roll4Location);
                g.DrawImage(imageRoll, RollCop4Location);
            }
        }
    }
}
