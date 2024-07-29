using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OrangeHRM.Reports;

namespace OrangeHRM.Utilities
{
    public class Commondriver
    {
        public IWebDriver driver;

        [SetUp]
        public void LoginSteps()
        {
            ExtentReporting.CreateTest(TestContext.CurrentContext.Test.MethodName);

            driver = new ChromeDriver();

        }
        [TearDown]
        public void Closetestrun()
        {
            driver.Quit();
            ExtentReporting.EndReporting();
        }
    }
}
