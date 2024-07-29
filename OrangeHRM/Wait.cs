using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace OrangeHRM.Utilities
{
    public class Wait
    {
        public static void WaitToBeClickable(IWebDriver Driver, string locatortype, string locatorvalue, int seconds)
        {
            var Wait = new WebDriverWait(Driver, new TimeSpan(0, 0, seconds));

            if (locatortype == "XPath")
            {
                Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.XPath(locatorvalue)));
            }
            if (locatortype == "Id")
            {
                Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.Id(locatorvalue)));
            }
            if (locatortype == "Cssselector")
            {
                Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.CssSelector(locatorvalue)));
            }
        }

    }
}

