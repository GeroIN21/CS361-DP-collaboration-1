using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace МагазинИНТ
{
    abstract class AbstractCard
    {
        protected double Disc { get; set; }
        protected double Sum { get; set; }

        public AbstractCard (double disc, double sum)
        {
            Disc = disc;
            Sum = sum;
        }

        public abstract void calcDiscount();
    }
}
