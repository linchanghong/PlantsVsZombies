using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PlantsVsZombies.MyZombie;
using PlantsVsZombies.MyEnum;

namespace PlantsVsZombies.MyZombie
{
    class NormalZombie : Zombie
    {
        public NormalZombie(Street street, Floor floor)
            : base(street, floor)
        {
            Power = 1;
            Hp = 3;
            Speed = 5;
            Dir = Direction.LEFT;
            Type = "Zombie";

            loadImage();
        }


        public NormalZombie(int x, int y)
        {
            X = x;
            Y = y;
            Hp = 3;
            Speed = 5;
            Dir = Direction.LEFT;
            Type = "Zombie";

            loadImage();
        }
    }
}
