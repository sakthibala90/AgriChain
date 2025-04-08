using BasicformValidate.Driver;
using BasicformValidate.Pages;
using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace BasicformValidate.Tests
{
    [TestFixture]
    public class HtmlFormTests
    {
        private IWebDriver driver;
        private HomePage HomePage;

        

        [SetUp]
        public void SetUp()
        {

            driver = Driverclass.GetDriver();
            driver.Navigate().GoToUrl("https://testpages.eviltester.com/styled/basic-html-form-test.html");
            HomePage = new HomePage(driver);
        }

        [Test]
        public void TestFormSubmission()
        {
            ResultPage resultpage=HomePage.FillForm("Sakthi", "123456");
            resultpage.GetUsername();
            resultpage.GetPassword();
            


        }

        [TearDown]
        public void TearDown()
        {
            Driverclass.CloseDriver();
        }
    }

}
