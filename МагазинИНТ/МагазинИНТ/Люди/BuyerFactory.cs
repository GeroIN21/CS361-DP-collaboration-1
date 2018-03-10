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
        public override AbstractCard setCard()
        {
            throw new NotImplementedException();
        }
    }
}
