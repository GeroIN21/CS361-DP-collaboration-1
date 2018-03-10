using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace МагазинИНТ
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
                SqlCommand addBuyer = new SqlCommand("Insert into [Buyers] (name) values (@name)", MyConnection);
                addBuyer.Parameters.AddWithValue("@name", name.ToString());
                MyConnection.Open();
                addBuyer.ExecuteNonQuery();

                SqlCommand getID = new SqlCommand("SELECT @@IDENTITY", MyConnection);
                getID.Connection = MyConnection;

                return Convert.ToInt32(getID.ExecuteScalar());               
            }
        }

        public void AuthBuyer()
        {

        }

        public void GetCard()
        {

        }
    }
}
