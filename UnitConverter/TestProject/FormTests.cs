using System;
using System.Diagnostics;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Windows;

namespace TestProject
{
    [TestClass]
    public class FormTests
    {
        private const string BTN_CONVERT = "button_Convert";
        private const string BTN_DISTANCE = "button_DistanceMode";
        private const string BTN_WEIGHT = "button_WeightMode";
        private const string BTN_TEMP = "button_TemperatureMode";
        private const string TXT_INPUT = "textBox_Input";
        private const string TXT_OUTPUT = "textBox_Output";
        private const string CMB_BASE = "comboBox_BaseUnit";
        private const string CMB_TARGET = "comboBox_TargetUnit";
        private const string LBL_MODE = "label_Mode";

        private const string APP_PATH = @"UnitConverter.exe";

        private AppiumOptions options;
        private WindowsDriver<WindowsElement> form;
        private Process p;

        public FormTests()
        {
            options = new AppiumOptions();
            options.AddAdditionalCapability("app", APP_PATH);
        }

        [TestInitialize]
        public void TestInit()
        {
            p = Process.Start(@"C:\Program Files (x86)\Windows Application Driver\WinAppDriver.exe");
            form = new WindowsDriver<WindowsElement>(new Uri("http://127.0.0.1:4723"), options);
        }

        [TestMethod]
        public void TestGeneralUse()
        {
            // Test Distance Mode
            clickElement(BTN_DISTANCE);

            Assert.AreEqual("Distance Mode", getText(LBL_MODE));

            getElement(TXT_INPUT).Clear();
            inputKeys("1");

            selectInComboBox(CMB_BASE, "Metres");
            selectInComboBox(CMB_TARGET, "Millimetres");

            clickElement(BTN_CONVERT);

            Assert.AreEqual("1000", getText(TXT_OUTPUT));

            // Test Weight Mode
            clickElement(BTN_WEIGHT);

            Assert.AreEqual("Weight Mode", getText(LBL_MODE));

            getElement(TXT_INPUT).Clear();
            inputKeys("1");//453.592

            selectInComboBox(CMB_BASE, "Pounds");
            selectInComboBox(CMB_TARGET, "Grams");

            clickElement(BTN_CONVERT);

            Assert.AreEqual("453.592", getText(TXT_OUTPUT));

            // Test Temperature Mode
            clickElement(BTN_TEMP);

            Assert.AreEqual("Temperature Mode", getText(LBL_MODE));

            getElement(TXT_INPUT).Clear();
            inputKeys("0");

            selectInComboBox(CMB_BASE, "Celsius");
            selectInComboBox(CMB_TARGET, "Fahrenheit");

            clickElement(BTN_CONVERT);

            Assert.AreEqual("32", getText(TXT_OUTPUT));
        }

        [TestCleanup]
        public void TestCleanup()
        {
            form.CloseApp();
            p.Close();

            form = null;
            p = null;
        }

        private WindowsElement getElement(string _id)
        {
            return form.FindElementByAccessibilityId(_id);
        }

        private void clickElement(string _id)
        {
            form.FindElementByAccessibilityId(_id).Click();
        }

        private void selectInComboBox(string _boxID, string _item)
        {
            getElement(_boxID).FindElementByName("Open").Click();
            getElement(_boxID).FindElementByClassName("ComboLBox").FindElementByName(_item).Click();
        }

        private string getText(string _id)
        {
            return form.FindElementByAccessibilityId(_id).Text;
        }

        private void inputKeys(string _text)
        {
            form.FindElementByAccessibilityId(TXT_INPUT).SendKeys(_text);
        }
    }
}
