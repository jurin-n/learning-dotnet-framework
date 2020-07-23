using Microsoft.VisualStudio.TestTools.UnitTesting;
using DbAccessSample;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DbAccessSample.Tests
{
    [TestClass()]
    public class TransactionScopeSampleTests
    {
        [TestMethod()]
        public void AddTest()
        {
            TransactionScopeSample t = new TransactionScopeSample();
            t.Add();
            Assert.Fail();
        }
    }
}