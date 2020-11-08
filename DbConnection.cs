using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace Smartphone_API
{
    public class DbConnection
    {
        private readonly string server = "127.0.0.1";
        private readonly string port = "3306";
        private readonly string database = "houseCalcdb";
        private readonly string id = "azure";
        private readonly string password = "";

        string ConnectionString = "";

        public MySqlConnection con = new MySqlConnection();
        public MySqlCommand cmd = new MySqlCommand();

        public DbConnection()
        {
            ConnectionString = $"Server={server}; Port={port}; Database={database}; Uid={id}; Pwd={password}";
            Connection();
        }

        private void Connection()
        {
            try
            {
                con = new MySqlConnection(ConnectionString);
                con.Open();
            }
            catch (Exception e)
            {
                //ログファイル出力(未実装)
            }
        }


    }
}
