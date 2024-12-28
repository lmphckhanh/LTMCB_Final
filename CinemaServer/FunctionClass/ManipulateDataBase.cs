using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;

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

        public string ToQuery(string query) //Query data in database (7th letter = Q)
        {
            string rs = "";
            //query = query.Substring(1);

            using (SqlConnection sqlConnection = DataBaseConnection.Connect())
            {
                sqlConnection.Open();

                cmd = new SqlCommand(query, sqlConnection);
                try
                {
                    dataReader = cmd.ExecuteReader();
                }
                catch(SqlException ex)
                {
                    return ex.Message;
                }
                while (dataReader.Read()) //Adding data into DataList
                {
                    object[] arr = new object[dataReader.FieldCount];
                    dataReader.GetValues(arr);
                    JObject json = new JObject();

                    for (int i = 0; i < dataReader.FieldCount; i++)
                    {
                        json.Add(dataReader.GetName(i), JToken.FromObject(arr[i]));
                    }
                    rs += json.ToString() + "<*>";
                    rs = rs.Replace("\r", "");
                    rs = rs.Replace("\n", "");
                }
                if (rs == "") rs = "NoData";

                sqlConnection.Close();
                return rs;
            }
        }

        //public void Command(string query) //Execute command
        //{

        //    query = query.Substring(1);
        //    using (SqlConnection sqlConnection = DataBaseConnection.Connect())
        //    {
        //        sqlConnection.Open();

        //        cmd = new SqlCommand(query, sqlConnection);
        //        cmd.ExecuteNonQuery();
        //        sqlConnection.Close();
        //    }
        //}

        public int Execute(string query) //Execute command
        {

            //query = query.Substring(1);
            using (SqlConnection sqlConnection = DataBaseConnection.Connect())
            {
                int rs = 0;
                sqlConnection.Open();

                cmd = new SqlCommand(query, sqlConnection);
                try
                {
                    rs = cmd.ExecuteNonQuery();
                }
                catch
                {
                    rs = 0;
                }
                sqlConnection.Close();
                return rs;
            }
        }

        public string GetObject(string query) //Get info
        {
            //query = query.Substring(1);
            using (SqlConnection sqlConnection = DataBaseConnection.Connect())
            {
                string rs = "";
                string syntax = query.Substring(0, 6);
               

                sqlConnection.Open();

                cmd = new SqlCommand(query, sqlConnection);
                try
                {
                    dataReader = cmd.ExecuteReader();
                }
                catch (SqlException ex)
                {
                    return ex.Message;
                }
                if (dataReader.Read())
                {
                    object[] arr = new object[dataReader.FieldCount];
                    dataReader.GetValues(arr);
                    JObject json = new JObject();

                    for (int i = 0; i < dataReader.FieldCount; i++)
                    {
                        json.Add(dataReader.GetName(i), JToken.FromObject(arr[i]));
                    }
                    rs = json.ToString();
                    rs = rs.Replace("\r", "");
                    rs = rs.Replace("\n", "");
                }
                if (rs == "") rs = "NoData";

                sqlConnection.Close();
                return rs;
            }
        }
    }
}
