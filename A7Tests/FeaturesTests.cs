using Microsoft.VisualStudio.TestTools.UnitTesting;
using A7;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A7.Tests
{
    [TestClass()]
    public class FeaturesTests
    {
        [TestMethod()]
        public void randomnumberTest()
        {
            var fun = new Features();
            var r = fun.randomnumber();
            Assert.IsTrue(r >= 1 && r <= 10);
            Assert.IsNotNull(r);
            Assert.IsFalse(r > 11);
        }
    }
}