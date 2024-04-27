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
            var g = false;
            Assert.IsTrue(g); 
        }
   /*     [TestMethod()]
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
        }*/
    }
}
