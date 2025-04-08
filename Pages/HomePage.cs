using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicformValidate.Pages
{
    public class HomePage
    {
        private IWebDriver driver;

        public HomePage(IWebDriver driver)
        {
            this.driver = driver;
        }

        public IWebElement Username => driver.FindElement(By.XPath("//input[@name='username']"));
        public IWebElement Password => driver.FindElement(By.Name("password"));
        public IWebElement SubmitBtn => driver.FindElement(By.XPath("//input[@type='submit']"));

        public ResultPage FillForm(string username, string password)
        {
            Username.SendKeys(username);
            Password.SendKeys(password);
            SubmitBtn.Click();
            return new ResultPage(driver);
        }
    }

}
