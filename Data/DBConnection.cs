using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace Data
{
    public class DBConnection
    {
        internal SqlConnection SqlConnection { get; }
        //private readonly string _connectionString;

        public DBConnection()
        {
            string _connectionString = "Server = mssql.fhict.local; Database = dbi413117; User Id = dbi413117; Password = Test321!;MultipleActiveResultSets=true;";
            SqlConnection = new SqlConnection(_connectionString);
        }
    }
}
