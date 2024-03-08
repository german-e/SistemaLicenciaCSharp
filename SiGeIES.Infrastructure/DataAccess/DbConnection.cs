using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data;
using Microsoft.Data.SqlClient;

namespace SiGeIES.Infrastructure.DataAccess
{
    public class DbConnection
    {


        private string _strConn;

        public DbConnection() 
        {
            _strConn = @"Data Source=GERMAN-PC\SQLEXPRESS;Initial Catalog=IESMiguelNemeDB;Integrated Security=True";
        }

        
        public IDbConnection GetConnection()
        {
            var conn = new SqlConnection(_strConn );

            

            return conn;
        }
    }
}
