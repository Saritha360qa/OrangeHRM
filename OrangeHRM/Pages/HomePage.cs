using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace OrangeHRM.Pages
{
    public class Homepage
    {
        public string HomepageActions(IWebDriver driver)
        {
            int count = 2;        
            string OutputFileName = "Output" + Stopwatch.GetTimestamp().ToString() + ".txt"; 
            string filePath = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) + @"..\..\..\..\results\" + OutputFileName;
            for (int i = 1; i < count; i++)
            {
                IWebElement menuContainer = driver.FindElement(By.XPath("//ul[@class='oxd-main-menu']"));
                IList<IWebElement> buttons = menuContainer.FindElements(By.TagName("a"));
                count = buttons.Count;

                // Print the text of each button to the console
                string buttonText = buttons[i].Text;
               
                File.AppendAllText(filePath, buttonText);

                // Click each button
                buttons[i].Click();
                Thread.Sleep(2000);                                         
                IWebElement menuContainer2 = driver.FindElement(By.CssSelector("#app > div.oxd-layout > div.oxd-layout-container > div.oxd-layout-context"));
                IList<IWebElement> paragraphs = menuContainer2.FindElements(By.TagName("p"));

                for (int j = 0; j < paragraphs.Count; j++)
                {
                    string paragraphText = paragraphs[j].Text;

                    // Write the value to the text file
                    File.AppendAllText(filePath, paragraphText);
                }
            }
            return filePath;
        }
    }
}
