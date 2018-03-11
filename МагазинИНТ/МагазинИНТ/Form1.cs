using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using МагазинИНТ.Люди;
using System.Data.SqlClient;

namespace МагазинИНТ
{
    public partial class Form1 : Form
    {
        int ID, i;
        string name;
        string products;
        int Sum = 0;

        SqlConnection sqlConnection;
        Properties.Settings settings = Properties.Settings.Default;
        public string StoreConnectionString = @"Data Source = KING\SQLEXPRESS;Initial Catalog = DP_Store; Integrated Security = True";

        public Form1()
        {
            InitializeComponent();
            sqlConnection = new SqlConnection(StoreConnectionString);
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dP_StoreDataSet.SelectBuyer_SP". При необходимости она может быть перемещена или удалена.
            this.selectBuyer_SPTableAdapter.Fill(this.dP_StoreDataSet.SelectBuyer_SP);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dP_StoreDataSet.Buyers". При необходимости она может быть перемещена или удалена.
            this.buyersTableAdapter.Fill(this.dP_StoreDataSet.Buyers);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dP_StoreDataSet.Products". При необходимости она может быть перемещена или удалена.
            this.productsTableAdapter.Fill(this.dP_StoreDataSet.Products);
        }

        private void button1_Click(object sender, EventArgs e)
        {           
            ID = comboBox1.SelectedIndex + 1;
            //name = comboBox1.SelectedValue.ToString();
            //Cashier cashier = new Cashier();
            //cashier.AuthBuyer(ID);
            int Sum;
            string Name;
            sqlConnection.Open();
            using (var MyConnection = new SqlConnection(StoreConnectionString))
            {
                SqlCommand buyerSum = new SqlCommand("Select Sum from [Buyers] where [ID] = '" + ID + "'", MyConnection);
                SqlCommand buyerName = new SqlCommand("Select Name from [Buyers] where [ID] = '" + ID + "'", MyConnection);
                buyerSum.Connection = MyConnection;
                buyerName.Connection = MyConnection;
                MyConnection.Open();

                Sum = Convert.ToInt32(buyerSum.ExecuteScalar());
                Name = buyerName.ExecuteScalar().ToString();
                sqlConnection.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            name = textBox1.Text;

            Cashier cashier = new Cashier();
            int returned = cashier.AddBuyer(name);

            label3.Text = "Индекс покупателя: " + returned + "";

            this.selectBuyer_SPTableAdapter.Fill(this.dP_StoreDataSet.SelectBuyer_SP);
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            Buyer buyer = new Buyer(ID, name, Sum);
            buyer.addProduct();
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            int prodID = comboBox2.SelectedIndex + 1;

            products = products + " " + prodID;
            sqlConnection.Open();
            using (var MyConnection = new SqlConnection(StoreConnectionString))
            {
                SqlCommand productSum = new SqlCommand("Select Cost from [Products] where [ID] = '" + prodID + "'", MyConnection);
                productSum.Connection = MyConnection;
                MyConnection.Open();

                Sum = Sum + Convert.ToInt32(productSum.ExecuteScalar());
                sqlConnection.Close();
            }
        }
    }
}
