using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using Microsoft.Extensions.Configuration;

namespace PolyglotToolVer2.Data
{
    public class classSQL
    {
        private readonly IConfiguration _configuration;

        public classSQL(IConfiguration configuration)
        {
            this._configuration = configuration;
        }

        public string getSqlConnectionString()
        {
            return _configuration.GetConnectionString("sqlConnection");
        }

        public string findField(string query)
        {
            string connectionString = _configuration.GetConnectionString("sqlConnection");
            string result = null;

            SqlConnection con = new SqlConnection(connectionString);
            try
            {
                con.Open();
                SqlDataReader myreader = null;
                SqlCommand sqlcom = new SqlCommand(query, con);

                myreader = sqlcom.ExecuteReader();
                while (myreader.Read())
                {
                    result = myreader[0].ToString();
                }

                myreader.Dispose();
                con.Close();
            }
            catch (Exception e)
            {
                Console.Write(e.ToString());
                result = $"\nΔεν μπορεί να γίνει σύνδεση\nConnectionString = {connectionString}";
            }

            return result;
        }

        public DataTable readTableFromSql(string query)
        {
            string connectionString = _configuration.GetConnectionString("sqlConnection");
            SqlConnection myConnection = new SqlConnection(connectionString);

            try
            {
                myConnection.Open();
            }
            catch (Exception e1)
            {
                Console.Write($"\nΔεν είναι σωστά τα στοιχεία που δώσατε\nconnectionString='{connectionString}' \n" + e1);
                return null;
            }


            DataTable results = new DataTable();

            using (SqlDataAdapter a = new SqlDataAdapter(query, myConnection))
            {
                a.Fill(results);
            }

            myConnection.Close();

            return results;
        }

        public int writeSQL(string query, string db = "Megasoft")
        {
            string connectionString = _configuration.GetConnectionString("sqlConnection");
            if (db != "Megasoft")
            {
                connectionString = connectionString.Replace("Megasoft", db);
            }

            int result = 0;

            SqlConnection myConnection = new SqlConnection(connectionString);

            try
            {
                myConnection.Open();
            }
            catch (Exception e1)
            {
                Console.Write("\nΠρόβλημα σύνδεσης με τον Διακομιστή" + e1);
                return -1;
            }
            SqlCommand cmd = new SqlCommand(query, myConnection);
            result = cmd.ExecuteNonQuery();

            myConnection.Close();

            return result;
        }
    }
}
