using NUnit.Framework;
using OpenQA.Selenium;
using OrangeHRM.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace OrangeHRM.Pages
{
    public class MyInfopage
    {
        public void MyInfoActions(IWebDriver driver)
        {
            //Identify the username textbox and enter valid username
            IWebElement MyInfoTextbox = driver.FindElement(By.XPath("//*[@id=\"app\"]/div[1]/div[1]/aside/nav/div[2]/ul/li[3]/a"));
            MyInfoTextbox.Click();           
            Wait.WaitToBeClickable(driver, "XPath", "//input[@class='oxd-input oxd-input--active orangehrm-firstname']", 10);

            //Identify the username textbox and enter valid username
            IWebElement EmployeeFullnameTextbox = driver.FindElement(By.XPath("//input[@class='oxd-input oxd-input--active orangehrm-firstname']"));
            EmployeeFullnameTextbox.Click();            
            EmployeeFullnameTextbox.SendKeys(Keys.Delete);
            EmployeeFullnameTextbox.SendKeys(Keys.Control +"a");
            Thread.Sleep(2000);            
            EmployeeFullnameTextbox.SendKeys("trainee2");           
            Wait.WaitToBeClickable(driver, "XPath", "//*[@id=\"app\"]/div[1]/div[2]/div[2]/div/div/div/div[2]/div[1]/form/div[2]/div[2]/div[2]/div/div[2]/div/div/input", 10);


            //Identify the username textbox and enter valid username
            IWebElement LicenseExpiryDateTextbox = driver.FindElement(By.XPath("//*[@id=\"app\"]/div[1]/div[2]/div[2]/div/div/div/div[2]/div[1]/form/div[2]/div[2]/div[2]/div/div[2]/div/div/input"));
            LicenseExpiryDateTextbox.Click();
            LicenseExpiryDateTextbox.SendKeys(Keys.Delete);
            LicenseExpiryDateTextbox.SendKeys(Keys.Control + "a");            
            Thread.Sleep(2000);
            LicenseExpiryDateTextbox.SendKeys("2024-05-13");           
            Wait.WaitToBeClickable(driver, "XPath", "//*[@id=\"app\"]/div[1]/div[2]/div[2]/div/div/div/div[2]/div[1]/form/div[4]/button", 10);


            //Identify the username textbox and enter valid username
            IWebElement SaveButton = driver.FindElement(By.XPath("//*[@id=\"app\"]/div[1]/div[2]/div[2]/div/div/div/div[2]/div[1]/form/div[4]/button"));
            SaveButton.Click();
            Thread.Sleep(1000);           
        }
    }
}
