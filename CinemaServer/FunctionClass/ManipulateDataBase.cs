using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace CinemaServer.FunctionClass
{
    internal class ManipulateDataBase
    {
        public ManipulateDataBase()
        {

        }

        private SqlCommand cmd; //Contain command
        private SqlDataReader dataReader; //Read data from database

        public static string Encryption(string input) //Encrypting password
        {
            HashAlgorithm alg = SHA256.Create(); //use SHA256 Encryption
            byte[] inputBytes = Encoding.UTF8.GetBytes(input); //Turning input into byte array
            byte[] hashBytes = alg.ComputeHash(inputBytes); //Hash byte array
            string HashPassword = BitConverter.ToString(hashBytes); //Turn byte array into string
            return HashPassword;
        }

        public List<object> ToQuery(string query) //Query data in database
        {
            List<object> DataList = new List<object>(); //Contain users which meet the conditions
            using (SqlConnection sqlConnection = DataBaseConnection.Connect())
            {
                sqlConnection.Open();

                cmd = new SqlCommand(query, sqlConnection);
                dataReader = cmd.ExecuteReader();
                while (dataReader.Read()) //Adding data into DataList
                {
                    //DataList.Add(/**/);
                }//                             UserId                 Username                 Password(Encypted)         Email                    Fullname                Birthday       

                sqlConnection.Close();
                return DataList;
            }
        }

        public void Command(string query) //Execute command
        {
            using (SqlConnection sqlConnection = DataBaseConnection.Connect())
            {
                sqlConnection.Open();

                cmd = new SqlCommand(query, sqlConnection);
                cmd.ExecuteNonQuery();
                sqlConnection.Close();
            }
        }

        public object GetObject(string query) //Get info
        {
            using (SqlConnection sqlConnection = DataBaseConnection.Connect())
            {
                string content = "";
                sqlConnection.Open();

                cmd = new SqlCommand(query, sqlConnection);
                dataReader = cmd.ExecuteReader();
                if (dataReader.Read())
                {
                    
                }

                sqlConnection.Close();
                return content;
            }
        }
    }
}
