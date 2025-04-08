using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicformValidate.Pages
{
    public class ResultPage
    {

        private IWebDriver driver;

        public ResultPage()
        {
        }

        public ResultPage(IWebDriver driver)
        {
            this.driver = driver;
        }

        public IWebElement GUsername => driver.FindElement(By.XPath("//li[@id='_valueusername']"));
        public IWebElement Password => driver.FindElement(By.Id("_valuepassword"));
        public IWebElement SubmitBtn => driver.FindElement(By.XPath("//input[@type='submit']"));

        public string GetUsername()
        {
            string name= GUsername.Text;
            return name;
        }
        public string GetPassword()
        {
            string password=Password.Text;
            return password;
        }

    }
}
