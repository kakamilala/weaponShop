﻿using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oruzh
{
    class DB
    {
        public MySqlConnection connection = new MySqlConnection("server=localhost; port=3307; username=root; password=root; database=oruzh");

        public void OpenConnection()
        {
            if (connection.State == System.Data.ConnectionState.Closed)
                connection.Open();


        }

        public void CloseConnection()
        {
            if (connection.State == System.Data.ConnectionState.Open)
                connection.Close();

        }

        public MySqlConnection GetConnection()
        {
            return connection;
        }

    }
}
