﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace BookBan
{
    class DBAccess
    {
        public static MySqlConnection GetConnection(string host, int port, string database, string username, string password)
        {
            String connString = "Server=" + host + 
                ";Database=" + database + 
                ";port=" + port + 
                ";User Id=" + username + 
                ";password=" + password;

            MySqlConnection conn = new MySqlConnection(connString);

            return conn;
        }

    }
}
