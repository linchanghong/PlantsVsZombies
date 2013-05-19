using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using System.Drawing;
using System.IO;
using System.Drawing.Imaging;

namespace PlantsVsZombies
{
    class Resources
    {
        //根据植物名称获取植物图片
        public ArrayList BoxImage(string name)
        {
            ArrayList images = new ArrayList();
            string file = ("Images/Plants/" + name + "/" + name + ".gif");
            GifToJpg(file, images);
            return images;
        }
        //角色类型的图片
        public ArrayList BulletType(string type)
        {
            ArrayList images = new ArrayList();
            GifToJpg("Images/Plants/" + type + ".gif", images);
            return images;
        }

        public Image CardType(string type)
        {
            Image image = Image.FromFile(Path.Combine(@"Images\Card\Plants\",
                type + ".png"));
            return image;
        }

        public ArrayList PlantType(string type)
        {
            ArrayList images = new ArrayList();
            GifToJpg("Images/Plants/" + type + "/" + type + ".gif", images);
            return images;
        }

        public ArrayList ZombieType(string type)
        {
            ArrayList images = new ArrayList();
            GifToJpg("Images/Zombies/" + type + "/" + type + ".gif", images);
            return images;
        }

        public ArrayList ZombieAttack(string type)
        {
            ArrayList images = new ArrayList();
            GifToJpg("Images/Zombies/" + type + "/" + type + "Attack.gif", images);
            return images;
        }

        public ArrayList ZombieDead(string type)
        {
            ArrayList images = new ArrayList();
            GifToJpg("Images/Zombies/" + type + "/" + type + "LostHead.gif", images);
            GifToJpg("Images/Zombies/" + type + "/" + type + "Die.gif", images);
            return images;
        }

        //阳光
        public ArrayList Sun()
        {
            ArrayList images = new ArrayList();
            GifToJpg(@"Images\Sun.gif", images);
            return images;
        }

        public void GifToJpg(string file, ArrayList images)
        {
            Image myImage = Image.FromFile(file);
            FrameDimension fd = new FrameDimension(myImage.FrameDimensionsList[0]);
            int framecount = myImage.GetFrameCount(fd);
            string path = file.Replace(Path.GetExtension(file), "");

            //资源是否已存在
            bool exists = Directory.Exists(path);
            //创建新文件夹
            if (!exists)
                Directory.CreateDirectory(path);
            //MessageBox.Show(file+": "+"framecount:" + framecount);

            //保存各帧
            for (int i = 0; i < framecount; i++)
            {
                myImage.SelectActiveFrame(fd, i);
                if (!exists)
                {
                    myImage.Save(Path.Combine(path, "frame_" + i + ".Png"), ImageFormat.Png);
                }

                Image image = Image.FromFile(Path.Combine(path, "frame_" + i + ".Png"));
                images.Add(image);
            }
        }

        internal ArrayList PeaBulletHit()
        {
            ArrayList images = new ArrayList();
            GifToJpg(@"Images\Plants\PeaBulletHit.gif", images);
            return images;
        }

        public ArrayList PrepareGrowPlants()
        {
            ArrayList images = new ArrayList();
            GifToJpg(@"Images\PrepareGrowPlants.gif", images);
            return images;
        }

        public static Image NormalBackground()
        {
            Image image = Image.FromFile(@"Images\interface\background1unsodded2.jpg");
            return image;
        }
    }
}
