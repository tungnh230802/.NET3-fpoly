using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Demo2
{
    class Program
    {
        static void Main(string[] args)
        {
            SqlConnection conn = null;
            SqlDataReader reader = null;

            string inputCity = "london";

            try
            {
                conn = new SqlConnection(@"data source = DESKTOP-2V5F3CA\TUNGNH230802;
                                        database = northwind;
                                        integrated security=SSPI");

                conn.Open();

                SqlCommand cmd = new SqlCommand(
                    "select * from customers where city = @city", conn
                    );

                SqlParameter param = new SqlParameter();
                param.ParameterName = "@city";
                param.Value = inputCity;

                cmd.Parameters.Add(param);

                reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    Console.WriteLine($"{reader["CompanyName"]}," +
                        $"{reader["contactName"]}");
                }
            }
            finally
            {
                if(reader != null)
                {
                    reader.Close();
                }

                if(conn!=null)
                {
                    conn.Close();
                }
            }
        }
    }
}
