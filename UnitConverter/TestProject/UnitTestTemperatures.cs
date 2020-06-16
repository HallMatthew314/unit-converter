using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestProject
{
    [TestClass]
    public class UnitTestTemperatures
    {
        [TestMethod]
        public void cToF()
        {
            double outValue = UnitConverter.ConversionMethods.cToF(300);
            Assert.AreEqual(outValue, 572);
        }

        [TestMethod]
        public void cToK()
        {
            double outValue = UnitConverter.ConversionMethods.cToK(300);
            Assert.AreEqual(outValue, 573.15);
        }

        [TestMethod]
        public void KToF()
        {
            double outValue = UnitConverter.ConversionMethods.kToF(300);
            Assert.AreEqual(outValue, 80.33);
        }

        [TestMethod]
        public void KToC()
        {
            double outValue = Math.Round(UnitConverter.ConversionMethods.kToC(300),3);
            Assert.AreEqual(outValue, 26.85);
        }

        [TestMethod]
        public void FToK()
        {
            double outValue = Math.Round(UnitConverter.ConversionMethods.fToK(300),3);
            Assert.AreEqual(outValue, 422.039);
        }

        [TestMethod]
        public void FToC()
        {
            double outValue = Math.Round(UnitConverter.ConversionMethods.fToC(300),3);
            Assert.AreEqual(outValue, 148.889);
        }

        [TestMethod]
        public void KToC2()
        {
            double outValue = Math.Round(UnitConverter.ConversionMethods.kToC(-20), 3);
            Assert.AreEqual(outValue, "ERROR");
        }

        [TestMethod]
        public void KToF2()
        {
            double outValue = Math.Round(UnitConverter.ConversionMethods.kToF(-20), 3);
            Assert.AreEqual(outValue, "ERROR");
        }
    }
}
