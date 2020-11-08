using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;
using System.Text;

namespace Smartphone_API
{
    public class DB_houseCalc
    {
        DbConnection dbConnection = new DbConnection();
        MySqlCommand cmd = new MySqlCommand();

        StringBuilder query = new StringBuilder();

        public void InsResultCalc()
        {
            cmd.Connection = dbConnection.con;

            query.AppendLine("INSERT INTO resultCalc(");
            query.AppendLine("month,");
            query.AppendLine("eatcost,");
            query.AppendLine("dailycost)VALUES(");
            query.AppendLine("'" + DateTime.Now.ToString("yyyy/MM/dd") + "',");
            query.AppendLine(100 + ",");
            query.AppendLine(200 + ");");

            cmd.CommandText = query.ToString();

            cmd.ExecuteNonQuery();

        }
    }
}
