using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace МагазинИНТ
{
    class Connect
    {
        SqlConnection sqlConnection;
        Properties.Settings settings = Properties.Settings.Default;
        string MusicConnectionString = @"Data Source = KING\SQLEXPRESS;Initial Catalog = DP_Store; Integrated Security = True";
    }
}
