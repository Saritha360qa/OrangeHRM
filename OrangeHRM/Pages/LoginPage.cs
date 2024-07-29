using NUnit.Framework;
using OpenQA.Selenium;
using OrangeHRM.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrangeHRM.Pages
{
    public class Login_Page
    {
        public void LoginActions(IWebDriver driver)
        {
            driver.Manage().Window.Maximize();

            // Lunch WEB_ERP page
            driver.Navigate().GoToUrl("http://hrms.qafactory.com.au/web/auth/login");
            Wait.WaitToBeClickable(driver, "XPath", "//*[@id=\"app\"]/div[1]/div/div[1]/div/div[2]/div[2]/form/div[1]/div/div[2]/input", 10);

            // Identify the username textbox and enter valid username
            IWebElement UsernameTextbox = driver.FindElement(By.XPath("//*[@id=\"app\"]/div[1]/div/div[1]/div/div[2]/div[2]/form/div[1]/div/div[2]/input"));
            UsernameTextbox.SendKeys("traineetest1");

            // Identify the password textbox and enter valid password
            IWebElement PasswordTextbox = driver.FindElement(By.XPath("//*[@id=\"app\"]/div[1]/div/div[1]/div/div[2]/div[2]/form/div[2]/div/div[2]/input"));
            PasswordTextbox.SendKeys("Traineetest@1");          
            Wait.WaitToBeClickable(driver, "XPath", "//*[@id=\"app\"]/div[1]/div/div[1]/div/div[2]/div[2]/form/div[3]/button", 10);

            //Identify the loginbutton and click on it
            IWebElement Loginbutton = driver.FindElement(By.XPath("//*[@id=\"app\"]/div[1]/div/div[1]/div/div[2]/div[2]/form/div[3]/button"));
            Loginbutton.Click();
            Wait.WaitToBeClickable(driver, "XPath", "//*[@id=\"app\"]/div[1]/div[1]/header/div[1]/div[2]/ul/li/span/p", 20);
            IWebElement Newcode = driver.FindElement(By.XPath("//*[@id=\"app\"]/div[1]/div[1]/header/div[1]/div[2]/ul/li/span/p"));

            Assert.That(Newcode.Text == "trainee2 test1", "Cannot find text 'trainee2 test1'");
        }
    }
}
