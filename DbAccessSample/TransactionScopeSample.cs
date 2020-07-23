using System;
using System.Data.SqlClient;
using System.Transactions;

namespace DbAccessSample
{
    public class TransactionScopeSample
    {
        public void Add(String connectionString, SqlCommand sqlCommand) {
            Console.WriteLine("処理開始");
            int returnValue = 0;
            System.IO.StringWriter writer = new System.IO.StringWriter();

            try
            {

                using (TransactionScope scope = new TransactionScope())
                {
                    using (SqlConnection con = new SqlConnection(connectionString))
                    {
                        con.Open();
                        sqlCommand.Connection = con;
                        returnValue = sqlCommand.ExecuteNonQuery();
                        writer.WriteLine("Rows to be affected by command: {0}", returnValue);
                    }

                    scope.Complete();
                }
            }
            catch (TransactionAbortedException ex)
            {
                writer.WriteLine("TransactionAbortedException Message: {0}", ex.Message);
            }
        }
    }
}
