using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using PlantsVsZombies.MyEnum;
using PlantsVsZombies.API;
using PlantsVsZombies.ExtendRole;

namespace PlantsVsZombies.MyPlant
{
    class SunFlower : Plant
    {
        public SunFlower(Street s, Floor f)
            : base(s, f)
        {
            Hp = 3;
            Dir = Direction.RIGHT;
            Type = "SunFlower";
            RolesStatus = RoleStatus.NORMAL;

            //加载图片数组
            loadImage();
        }

        public SunFlower()
        {
        }

        public override void Instance(Street street, Floor floor)
        {
            base.Instance(street,floor);
            Hp = 3;
            Dir = Direction.RIGHT;
            Type = "SunFlower";
            RolesStatus = RoleStatus.NORMAL;

            //加载图片数组
            loadImage();
        }

        public override void Run()
        {
            Thread t = new Thread(new ThreadStart(RunThread));
            t.Start();
        }

        public override void PlantAction(int time)
        {
            if ((time+1) % 80 == 0)
                collectSun();
        }

        private void collectSun()
        {
            Sun sun = new Sun(this.X + 30, this.Y + 30, this.X + 30, this.Y + 30);
            Map.addSun(sun);
        }

        public override void Attack()
        {
            
        }
    }
}
