using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DbAccessSample;

namespace DbAccessSampleTests
{
    [TestClass]
    public class DbHelperTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            Console.WriteLine(DbHelper.getConnectionString());
        }
    }
}
