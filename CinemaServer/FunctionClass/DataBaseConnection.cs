using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;

namespace CinemaServer.FunctionClass
{
    internal class DataBaseConnection
    {
        private static string connectionString = @"Data Source=LPK;Initial Catalog=CinemaManagement;Integrated Security=True;Trust Server Certificate=True";
        public static SqlConnection Connect()
        {
            return new SqlConnection(connectionString);
        }
    }
}
