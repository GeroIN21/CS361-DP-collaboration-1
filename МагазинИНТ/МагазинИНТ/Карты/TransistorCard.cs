using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace МагазинИНТ
{
    class TransistorCard : AbstractCard
    {
        //double Disc;
        double DiscTotal;
        //double Sum;

        public TransistorCard(double disc, double sum) : base(disc, sum)
        {
            Disc = disc;
            Sum = sum;
            calcDiscount();
        }

        public override void calcDiscount()
        {
            DiscTotal = Sum * Disc / 100;
        }
    }
}
