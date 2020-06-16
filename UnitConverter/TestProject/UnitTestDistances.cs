using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using UnitConverter;

namespace TestProject
{
    [TestClass]
    public class UnitTestDistances
    {
        [TestMethod]
        public void mmToCmTest()
        {
            double outValue = UnitConverter.ConversionMethods.mmToCm(1.0);
            Assert.AreEqual(outValue, 0.1);
        }
        [TestMethod]
        public void cmTommTest()
        {
            double outValue = UnitConverter.ConversionMethods.cmTomm(1.0);
            Assert.AreEqual(outValue, 10);
        }
        [TestMethod]
        public void mToCmTest()
        {
            double outValue = UnitConverter.ConversionMethods.mToCm(1.0);
            Assert.AreEqual(outValue, 100);
        }
        [TestMethod]
        public void cmTomTest()
        {
            double outValue = UnitConverter.ConversionMethods.cmTom(100);
            Assert.AreEqual(outValue, 1);
        }
        [TestMethod]
        public void mmToMTest()
        {
            double outValue = UnitConverter.ConversionMethods.mmTom(1000);
            Assert.AreEqual(outValue, 1);
        }
        [TestMethod]
        public void mTommTest()
        {
            double outValue = UnitConverter.ConversionMethods.mTomm(1.0);
            Assert.AreEqual(outValue, 1000);
        }
        
        [TestMethod]
        public void inchToCmTest()
        {
            double outValue = UnitConverter.ConversionMethods.inchTocm(1.0);
            Assert.AreEqual(outValue, 2.54);
        }
        [TestMethod]
        public void inchTommTest()
        {
            double outValue = UnitConverter.ConversionMethods.inchTomm(1.0);
            Assert.AreEqual(outValue, 25.4);
        }
        [TestMethod]
        public void inchTomTest()
        {
            double outValue = UnitConverter.ConversionMethods.inchTom(1.0);
            Assert.AreEqual(outValue, 0.0254);
        }



        [TestMethod]
        public void mmToInchTest()
        {
            double outValue = Math.Round(UnitConverter.ConversionMethods.mmToInch(1.0),5);
            Assert.AreEqual(outValue, 0.03937);
        }
        [TestMethod]
        public void cmToInchTest()
        {
            double outValue = Math.Round(UnitConverter.ConversionMethods.cmToInch(1.0), 5);
            Assert.AreEqual(outValue, 0.3937);
        }
        [TestMethod]
        public void mToInchTest()
        {
            double outValue = Math.Round(UnitConverter.ConversionMethods.mToInch(1.0), 5);
            Assert.AreEqual(outValue, 39.37008);
        }



    }
}
