using Microsoft.VisualStudio.TestTools.UnitTesting;
using DbAccessSample;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Threading;

namespace DbAccessSample.Tests
{
    [TestClass()]
    public class TransactionScopeSampleTests
    {
        [TestMethod()]
        public void AddTest()
        {
            AppDomain.CurrentDomain.SetData("DataDirectory", System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "App_Data"));
            //String connectionString = "Data Source=localhost; Database = master; Trusted_Connection = True;Min Pool Size=100;Max Pool Size=100;";
            String connectionString = "Data Source=localhost; Database = master;User ID=user01;Password=user01password; Min Pool Size=100;Max Pool Size=1000;";
            String commandText = "INSERT INTO item(ItemId,Name,Description,CreatedOn) Values(@ItemId, @Name, @Description, @CreatedOn);";

            SqlCommand command = new SqlCommand(commandText);
            //command.Parameters.Add("@ItemId", SqlDbType.Int);
            //command.Parameters["@ItemId"].Value = 1;
            command.Parameters.AddWithValue("@ItemId", 1);

            //command.Parameters.Add("@Name", SqlDbType.NVarChar);
            //command.Parameters["@Name"].Value = "あああ";
            command.Parameters.AddWithValue("@Name","あああ");

            //command.Parameters.Add("@Description", SqlDbType.NVarChar);
            //command.Parameters["@Description"].Value = @"説明０１" + Environment.NewLine + "説明０２";
            command.Parameters.AddWithValue("@Description", "説明０１" + Environment.NewLine + "説明０２");

            //command.Parameters.Add("@CreatedOn", SqlDbType.DateTime);
            //command.Parameters["@CreatedOn"].Value = "2020-07-23";
            command.Parameters.AddWithValue("@CreatedOn", "2020-07-23");

            TransactionScopeSample t = new TransactionScopeSample();
            t.Add(connectionString, command);
            //Assert.Fail();


            NonTransactionDbConnectionSample nt = new NonTransactionDbConnectionSample();
            nt.get(connectionString, new SqlCommand("SELECT Description FROM item"));

            //Thread.Sleep(20000); //Connection Poolingされていること確認するためsleep
        }
    }
}