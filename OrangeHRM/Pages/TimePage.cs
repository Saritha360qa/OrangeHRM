using Microsoft.AspNetCore.Http;
using OpenQA.Selenium;
using OrangeHRM.Utilities;

namespace OrangeHRM.Pages
{
    public class TimePage
    {
        public bool TimePageActions (IWebDriver driver)
        {
            //Identify the username textbox and enter valid username
            IWebElement TimeMenu = driver.FindElement(By.XPath("//*[@id=\"app\"]/div[1]/div[1]/aside/nav/div[2]/ul/li[2]/a"));
            TimeMenu.Click();
            Thread.Sleep(1000);           
            IWebElement TimeRange = driver.FindElement(By.XPath("//*[@id=\"app\"]/div[1]/div[2]/div[2]/div/form/div[1]/div[2]/div/div/div[2]/div/div/input"));
            string TR = TimeRange.GetAttribute("value");            
            string startDate = TR.Substring(0, 10);
            string EndDate = TR.Substring(14, 10);           
            DateTime parsedStartDate = DateTime.Parse(startDate);
            DateTime parsedEndDate = DateTime.Parse(EndDate);
           
            //Get today's date
            DateTime today = DateTime.Today;
            // Check if today's date is within the specified range
            bool isTodayWithinRange = today >= parsedStartDate && today <= parsedEndDate;
        return isTodayWithinRange;
        }
    }
}

