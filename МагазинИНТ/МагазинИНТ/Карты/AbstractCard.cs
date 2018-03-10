using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace МагазинИНТ
{
    abstract class AbstractCard
    {
        protected int Discount { get; set; }
        protected double Sum { get; set; }

        public AbstractCard (int disc, double sum)
        {
            Discount = disc;
            Sum = sum;
        }

        public abstract void calcDiscount();
    }
}
