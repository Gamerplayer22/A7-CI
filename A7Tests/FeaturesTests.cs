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
            var r = fun.randomnumber();     // this function only generates...
            Assert.IsTrue(r < 1 && r > 10); // ...numbers (r>=1 && r<=10)!
        }
        [TestMethod()]
        public void randomnumberTest2()
        {
            var fun = new Features();
            var r = fun.randomnumber();
            Assert.IsNotNull(r);
        }
        [TestMethod()]
        public void randomnumberTest3()
        {
            var fun = new Features();
            var r = fun.randomnumber();
            Assert.IsFalse(r > 11);
        }
    }
}
