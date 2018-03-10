using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using МагазинИНТ.Люди;

namespace МагазинИНТ
{
    abstract class BuyerFactory : HumanFactory
    {
        public override AbstractCard setIntegratedCard()
        {
            throw new NotImplementedException();
        }

        public override AbstractCard setTransistorCard()
        {
            throw new NotImplementedException();
        }

        public override AbstractCard setTubeDiscountCard()
        {
            throw new NotImplementedException();
        }
    }
}
