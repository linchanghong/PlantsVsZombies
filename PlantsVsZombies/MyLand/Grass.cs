using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PlantsVsZombies.MyPlant;
using PlantsVsZombies.MyEnum;

namespace PlantsVsZombies.MyLand
{
    class Grass : Land
    {
        public Grass(Street s, Floor f)
            : base(s, f)
        {

        }

        public override Plant GrowPlant(string type)
        {
            Plant p = base.GrowPlant(type);

            return p;
        }
    }
}
