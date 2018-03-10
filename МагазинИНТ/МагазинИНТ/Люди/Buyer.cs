using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace МагазинИНТ.Люди
{
    class Buyer
    {
        private BuyerFactory card;
        //private BuyerFactory name;

        public Buyer(BuyerFactory factory)
        {
        }

        //public void Name()
        //{
        //    name.setName();
        //}

        public void Card()
        {
            card.setCard();
        }
    }
}
