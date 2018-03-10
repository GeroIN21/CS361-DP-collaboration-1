using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace МагазинИНТ
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dP_StoreDataSet.Buyers". При необходимости она может быть перемещена или удалена.
            this.buyersTableAdapter.Fill(this.dP_StoreDataSet.Buyers);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dP_StoreDataSet.Products". При необходимости она может быть перемещена или удалена.
            this.productsTableAdapter.Fill(this.dP_StoreDataSet.Products);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int ID;
            ID = comboBox1.SelectedIndex + 1;

            Cashier cashier = new Cashier();
            cashier.AuthBuyer();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string name;
            name = textBox1.Text;

            Cashier cashier = new Cashier();
            int returned = cashier.AddBuyer(name);

            label3.Text = "Индекс покупателя: " + returned + "";
        }
    }
}
