using MySql.Data.MySqlClient;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp2
{
    internal class MyConnect
    {
        MySqlConnection conn;
        public MyConnect()
        {
            string host = "194.87.201.94";
            int port = 3306;
            string database = "myDB";
            string username = "admin";
            string password = "123456";

            string connStr = $"server={host};user={username};database={database};password={password};CharSet=utf8;";

            conn = new MySqlConnection(connStr);
            conn.Open();
        }
        public MySqlDataAdapter GetAdapter(string query)
        {

            var adapter = new MySqlDataAdapter(query, conn);

            return adapter;
        }

        public MySqlDataReader GetReader(string query)
        {
            var command = new MySqlCommand(query,conn);

            return command.ExecuteReader();
        }

        public int UpdateTable(MySqlDataAdapter adapter, DataTable dt)
        {
            MySqlCommandBuilder commandBuilder = new MySqlCommandBuilder(adapter);
            return adapter.Update(dt);
        }

        public int Command(string cmd)
        {
            var command = new MySqlCommand(cmd, conn);
            return command.ExecuteNonQuery();
        }
        public void close()
        {
            conn.Close();
        }


    }
}
