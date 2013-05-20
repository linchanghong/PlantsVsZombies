using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PlantsVsZombies.MyLand;
using PlantsVsZombies.API;
using System.Threading;
using PlantsVsZombies.MyZombie;
using PlantsVsZombies.MyCleaner;
using PlantsVsZombies.ExtendRole;
using PlantsVsZombies.MyPlant;
using PlantsVsZombies.MyEnum;
using System.Drawing;

namespace PlantsVsZombies.MyMission
{
    class Mission1 : Mission
    {

        public Mission1():base()
        {
        }

        public override void initMission(Map map)
        {
            base.initMission(map);

            //初始化剩余界面信息
            LevelStart();
        }

        public override void loadBackImage()
        {
            //初始化背景图片
            Map.BackgroundImage = Resources.NormalBackground();
        }

        public override void initMap()
        {
            //初始化时间
            Map.IsDayTime = true;
            //初始化铲子
            Map.Shovel = new Shovel();
            //
            Map.SunBoard = new SunBoard(Map);
            Map.SunShine = 100;
            //草地环境
            for (int i = 0; i < 9; i++)
            {
                for (int j = 1; j < 4; j++)
                {
                    Land land = new Grass(LandX(i), LandY(j));
                    Map.Lands.Add(land);
                }
            } 
        }

        public override void initCleaners()
        {
            //Map.addCleaner(new LawnMower(Street.FIRST, Floor.FIRST));
            //Map.addCleaner(new LawnMower(Street.FIRST, Floor.SECOND));
            //Map.addCleaner(new LawnMower(Street.FIRST, Floor.THIRD));
            //Map.addCleaner(new LawnMower(Street.FIRST, Floor.FOURTH));
            //Map.addCleaner(new LawnMower(Street.FIRST, Floor.FIFTH));
        }

        public override void initCards()
        {          
           // Map.initCard(new PlantCard("Peashooter", 20));
           // Map.initCard(new PlantCard("Repeater", 10));
            Map.initCard(new PlantCard("SunFlower", 2));           
        }

        //关卡的开头动画
        public override void beginMovie()
        {
            base.beginMovie();
        }

        public override void CreateZombies()
        {
            //选择卡牌完成后的游戏界面初始化      
            //提示开始
            int i = 1,validNum = Controller.GameTime;
            while (i < 10  && Controller.gameStatus != GameStatus.OVER 
                && validNum == Controller.GameTime)
            {
                if (Controller.gameStatus == GameStatus.START)
                {
                    if (i == 4 || i == 8)
                    {
                        i++;
                    }
                    else
                    {
                        Map.addZombie(new NormalZombie(Street.TENTH, LandY(i % 4)));
                        i++;
                    }
                    Thread.Sleep(15000);
                }
            }
        }
    }
}
