using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace МагазинИНТ.Люди
{
    abstract class HumanFactory
    {
        //public abstract HumanFactory setName();
        public abstract AbstractCard setTubeDiscountCard();
        public abstract AbstractCard setTransistorCard();
        public abstract AbstractCard setIntegratedCard();
    }
}
