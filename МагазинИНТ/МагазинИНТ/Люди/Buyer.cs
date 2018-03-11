using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace МагазинИНТ.Люди
{
    class Buyer : BuyerFactory
    {
        SqlConnection sqlConnection;
        Properties.Settings settings = Properties.Settings.Default;
        public string StoreConnectionString = @"Data Source = KING\SQLEXPRESS;Initial Catalog = DP_Store; Integrated Security = True";

        private AbstractCard card;
        //private BuyerFactory name;

        public int ID { get; set; }
        public string Name { get; set; }
        public int Sum { get; set; }

        public Buyer(int id, string name, int sum)
        {
            sqlConnection = new SqlConnection(StoreConnectionString);
            ID = id;
            Name = name;
            Sum = sum;
        }

        public void addProduct()
        {
            sqlConnection.Open();
            using (var MyConnection = new SqlConnection(StoreConnectionString))
            {
                SqlCommand intoBasket = new SqlCommand("Insert into [Basket] (BuyerID, Cost) values (@BuyerID, @Cost)", MyConnection);
                intoBasket.Parameters.AddWithValue("@BuyerID", ID.ToString());
                intoBasket.Parameters.AddWithValue("@Cost", Sum.ToString());
                MyConnection.Open();
                intoBasket.ExecuteNonQuery();

                sqlConnection.Close();
            }
        }

        //public void setTubeDiscountCard(HumanFactory factory)
        //{           
        //    card = factory.setTubeDiscountCard();
        //}

        //public void setTransistorCard(HumanFactory factory)
        //{
        //    card = factory.setTransistorCard();
        //}

        //public void setIntegratedCard(HumanFactory factory)
        //{
        //    card = factory.setIntegratedCard();
        //}
        //TubeDiscountCard tubeCard = new TubeDiscountCard(5, 5000);
        //TransistorCard transistorCard = new TransistorCard(10, 12500);
        //IntegratedCard integratedCard = new IntegratedCard(15, 25000);

        public override AbstractCard setTubeDiscountCard()
        {
            TubeDiscountCard tubeCard = new TubeDiscountCard(5, Sum);
            throw new NotImplementedException();
        }

        public override AbstractCard setTransistorCard()
        {
            TransistorCard transistorCard = new TransistorCard(10, Sum);
            throw new NotImplementedException();
        }

        public override AbstractCard setIntegratedCard()
        {
            IntegratedCard integratedCard = new IntegratedCard(15, Sum);
            throw new NotImplementedException();
        }
    }
}
