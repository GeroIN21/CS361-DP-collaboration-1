using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace МагазинИНТ
{
    class TubeDiscountCard : AbstractCard
    {
        public TubeDiscountCard(int disc, double sum) : base(disc, sum)
        {
        }

        public override void calcDiscount()
        {
            throw new NotImplementedException();
        }
    }
}
