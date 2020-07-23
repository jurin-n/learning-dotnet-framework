using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DbAccessSample
{
    public class NonTransactionDbConnectionSample
    {
        public void get(String connectionString, SqlCommand sqlCommand)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                sqlCommand.Connection = con;
                con.Open();
                SqlDataReader dr = sqlCommand.ExecuteReader();
                do
                {
                    while (dr.Read())
                    {
                        Console.WriteLine("SELECT結果");
                        Console.WriteLine(dr[0]);
                    }
                } while (dr.NextResult());
            }
        }
    }
}
