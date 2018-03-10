using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace МагазинИНТ
{
    public abstract class AbstractPerson
    {
        public string Name { get; set; }

        //public SqlConnection sqlConnection;
        //Properties.Settings settings = Properties.Settings.Default;
        //public string StoreConnectionString = @"Data Source = KING\SQLEXPRESS;Initial Catalog = DP_Store; Integrated Security = True";

        public AbstractPerson (string name)
        {
            Name = name;
        }
    }
}
