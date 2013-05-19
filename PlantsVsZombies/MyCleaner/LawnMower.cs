using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PlantsVsZombies.MyEnum;

namespace PlantsVsZombies.MyCleaner
{
    class LawnMower : Cleaner
    {
        public LawnMower(Street street, Floor floor)
            : base(street, floor)
        {
            this.Type = "LawnMower";

            loadImage();
        }

        public override void loadImage()
        {
            base.loadImage();
        }
    }
}
