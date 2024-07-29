using NUnit.Framework;
using OrangeHRM.Pages;
using OrangeHRM.Reports;
using OrangeHRM.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;


namespace OrangeHRM.Tests
{
    [TestFixture]
    public class OrangeHRMtests : Commondriver
    {
        Login_Page LoginPageobj = new Login_Page();
        Homepage Homepageobj = new Homepage();
        TimePage Timepageobj = new TimePage();
        MyInfopage MyInfopageobj = new MyInfopage();

        [Test, Order(1), Description("check if user is able to enter valid data in login page")]
        public void LoginpageTest()
        {
            try
            {
                ExtentReporting.CreateTest("LoginpageTest");
                ExtentReporting.LogInfo("Log on to Home page");

                // LoginPage object initialization and definition
                LoginPageobj.LoginActions(driver);

                ExtentReporting.LogPass("LoginpageTest passed successfully.");
            }
            catch (Exception ex)
            {
                ExtentReporting.LogFail($"LoginpageTest failed: {ex.Message}");
                ExtentReporting.LogFail(ex.StackTrace);
                throw; // Rethrow the exception to ensure the test is marked as failed in the test runner
            }
            finally
            {
                ExtentReporting.EndReporting(); // Ensure the report is flushed
            }
        }

        [Test, Order(2), Description("check if user is able to view the Home page")]
        public void HomepageTest()
        {
            string ExpectedFilepath = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) + @"..\..\..\..\results\ExpectedFile.txt";
            bool CompareFiles(string filePath1, string filePath2)
            {
             //Read all bytes from both files
             byte[] file1Bytes = File.ReadAllBytes(filePath1);
             byte[] file2Bytes = File.ReadAllBytes(filePath2);

             //Compare the byte arrays
            return file1Bytes.Length == file2Bytes.Length && file1Bytes.SequenceEqual(file2Bytes);
            }
            try
            {
                ExtentReporting.CreateTest("HomepageTest");
                ExtentReporting.LogInfo("Log on to Home page");

                //HomePage object initialization and definition
                LoginPageobj.LoginActions(driver);
                string ResultFilePath = Homepageobj.HomepageActions(driver).ToString();
                bool areFilesEqual = CompareFiles(ResultFilePath, ExpectedFilepath);
                if (areFilesEqual)
                {
                   ExtentReporting.LogPass("HomepageTest passed successfully.");
                }
                else
                {
                    ExtentReporting.LogFail("File are not matching - Menu list not matched.");
                 }

            }
            catch (Exception ex)
            {
                ExtentReporting.LogFail($"HomepageTest failed: {ex.Message}");
                ExtentReporting.LogFail(ex.StackTrace);
                throw; // Rethrow the exception to ensure the test is marked as failed in the test runner
            }
            finally
            {
                ExtentReporting.EndReporting(); // Ensure the report is flushed
            }
        }
        [Test, Order(3), Description("check the date range in timesheet tab")]

        public void TimepageTests()
        {
            try
            {
                ExtentReporting.CreateTest("TimepageTests");
                ExtentReporting.LogInfo("Log on to Home page");

                // LoginPage object initialization and definition
                LoginPageobj.LoginActions(driver);
                bool result = Timepageobj.TimePageActions(driver);
                if (result)
                    ExtentReporting.LogPass("Week range displayed correctly");
                else
                    ExtentReporting.LogFail("Week displayed is Wrong.");

                ExtentReporting.LogPass("TimepageTests passed successfully.");
            }
            catch (Exception ex)
            {
                ExtentReporting.LogFail($"TimepageTests failed: {ex.Message}");
                ExtentReporting.LogFail(ex.StackTrace);
                throw; // Rethrow the exception to ensure the test is marked as failed in the test runner
            }
            finally
            {
                ExtentReporting.EndReporting(); // Ensure the report is flushed
            }           
        }
        [Test, Order(4), Description("check if user is able to enter valid data in login page")]
        public void MyInfopageTest()
        {
            try
            {
                ExtentReporting.CreateTest("MyInfopageTest");
                ExtentReporting.LogInfo("Log on to Home page");

                // LoginPage object initialization and definition
                LoginPageobj.LoginActions(driver);
                MyInfopageobj.MyInfoActions(driver);

                ExtentReporting.LogPass("MyInfopageTest passed successfully.");
            }
            catch (Exception ex)
            {
                ExtentReporting.LogFail($"MyInfopageTest failed: {ex.Message}");
                ExtentReporting.LogFail(ex.StackTrace);
                throw; // Rethrow the exception to ensure the test is marked as failed in the test runner
            }
            finally
            {
                ExtentReporting.EndReporting(); // Ensure the report is flushed
            }
        }

    }
}



