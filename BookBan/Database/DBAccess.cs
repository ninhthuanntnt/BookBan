﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace BookBan
{
    class DBAccess
    {
        public static MySqlConnection GetConnection(string host= "db.wygo.eu", 
                                                            int port=3306, 
                                                            string database="BookBan", 
                                                            string username="web101010", 
                                                            string password="web101010")
        {
            String connString = "Server=" + host + 
                ";Database=" + database + 
                ";port=" + port + 
                ";User Id=" + username + 
                ";password=" + password;

            MySqlConnection conn = new MySqlConnection(connString);

            return conn;
        }

        public static DataSet selectQuery(MySqlConnection connection, string sqlQuery)
        {
            try
            {
                connection.Open();

                DataAdapter dataAdapter = new MySqlDataAdapter(sqlQuery, connection);

                DataSet dataSet = new DataSet();

                dataAdapter.Fill(dataSet);

                connection.Close();

                return dataSet;
            } catch(Exception e)
            {
                Console.WriteLine(e.StackTrace);
                return null;
            }
        }
    }
}
