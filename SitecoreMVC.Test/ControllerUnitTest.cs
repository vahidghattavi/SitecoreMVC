using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SitecoreMVC.Test
{
    [TestClass]
    public class ControllerUnitTest
    {
        [TestMethod]
        public void SampleUnitTest()
        {
            var a = 2;
            var b = 3;
            Assert.AreEqual(a + b, 5);
        }
    }
}
