using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Firefox;

namespace BasicformValidate.Driver
{
   
        public static class Driverclass
        {
            private static IWebDriver driver;

            public static IWebDriver GetDriver()
            {
                if (driver == null)
                {
                    driver = new FirefoxDriver();
                    driver.Manage().Window.Maximize();
                }
                return driver;
            }

            public static void CloseDriver()
            {
                driver.Quit();
                driver = null;
            }
        }

    
}
