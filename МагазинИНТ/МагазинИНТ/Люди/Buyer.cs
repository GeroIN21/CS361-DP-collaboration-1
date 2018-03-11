using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace МагазинИНТ.Люди
{
    class Buyer
    {
        private AbstractCard card;
        //private BuyerFactory name;

        public int ID { get; set; }
        public string Name { get; set; }
        public int Sum { get; set; }

        public Buyer(int id, string name, int sum)
        {
            ID = id;
            Name = name;
            Sum = sum;
        }

        //public void Name()
        //{
        //    name.setName();
        //}

        public void setTubeDiscountCard(HumanFactory factory)
        {           
            card = factory.setTubeDiscountCard();
        }

        public void setTransistorCard(HumanFactory factory)
        {
            card = factory.setTransistorCard();
        }

        public void setIntegratedCard(HumanFactory factory)
        {
            card = factory.setIntegratedCard();
        }
    }
}
