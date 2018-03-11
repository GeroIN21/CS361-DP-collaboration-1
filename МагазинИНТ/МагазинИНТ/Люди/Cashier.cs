using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace МагазинИНТ.Люди
{
    class Cashier 
    {
        SqlConnection sqlConnection;
        Properties.Settings settings = Properties.Settings.Default;
        public string StoreConnectionString = @"Data Source = KING\SQLEXPRESS;Initial Catalog = DP_Store; Integrated Security = True";

        public Cashier() 
        {
            sqlConnection = new SqlConnection(StoreConnectionString);
        }

        public int AddBuyer(string name)
        {
            sqlConnection.Open();
            using (var MyConnection = new SqlConnection(StoreConnectionString))
            {               
                SqlCommand addBuyer = new SqlCommand("Insert into [Buyers] (Name) values (@name)", MyConnection);
                addBuyer.Parameters.AddWithValue("@name", name.ToString());
                MyConnection.Open();
                addBuyer.ExecuteNonQuery();

                SqlCommand getID = new SqlCommand("SELECT @@IDENTITY", MyConnection);
                getID.Connection = MyConnection;

                sqlConnection.Close();

                return Convert.ToInt32(getID.ExecuteScalar());                
            }           
        }

        public void AuthBuyer(int ID)
        {
            int Sum;
            string Name;
            sqlConnection.Open();
            using (var MyConnection = new SqlConnection(StoreConnectionString))
            {
                SqlCommand buyerSum = new SqlCommand("Select Sum from [Buyers] where [ID] = '" + ID +"'", MyConnection);
                SqlCommand buyerName = new SqlCommand("Select Name from [Buyers] where [ID] = '" + ID + "'", MyConnection);
                buyerSum.Connection = MyConnection;
                buyerName.Connection = MyConnection;
                MyConnection.Open();

                Sum = Convert.ToInt32(buyerSum.ExecuteScalar());
                Name = buyerName.ExecuteScalar().ToString();
                sqlConnection.Close();
            }
            //Buyer buyer = new Buyer(ID, Name, Sum);
        }

        public void GetCard()
        {

        }
    }
}
