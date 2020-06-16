using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestProject
{
    [TestClass]
    public class UnitTestWeights
    {
        [TestMethod]
        public void stoneTog()
        {
            double outValue = UnitConverter.ConversionMethods.stoneTog(12);
            Assert.AreEqual(outValue, 76203.48);
        }
        [TestMethod]
        public void gToStone()
        {
            double outValue = Math.Round(UnitConverter.ConversionMethods.gToStone(1000), 5);

            Assert.AreEqual(outValue, 0.15747);
        }
        [TestMethod]
        public void lbToStone()
        {
            double outValue = Math.Round(UnitConverter.ConversionMethods.lbToStone(10),5);
            Assert.AreEqual(outValue, 0.71429);
        }
        [TestMethod]
        public void stoneToLb()
        {
            double outValue = UnitConverter.ConversionMethods.stoneTolb(2);
            Assert.AreEqual(outValue, 28);
        }
        [TestMethod]
        public void lbTog()
        {
            double outValue = Math.Round(UnitConverter.ConversionMethods.lbTog(16), 5);
            Assert.AreEqual(outValue, 7257.472);
        }
        [TestMethod]
        public void gTolb()
        {
            double outValue = Math.Round(UnitConverter.ConversionMethods.gTolb(212),5);
            Assert.AreEqual(outValue, 0.46738);
        }
    }
}
