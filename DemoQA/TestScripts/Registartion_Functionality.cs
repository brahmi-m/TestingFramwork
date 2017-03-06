using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DemoQA.Environment;
using DemoQA.PageObjects;
using DemoQA.TestScripts;
using NUnit.Framework;
using OpenQA.Selenium;
using RelevantCodes.ExtentReports;

namespace DemoQA.TestScripts
{
    [TestFixture]
    class Registartion_Functionality : BaseTest
    {
        [Test]
        [Parallelizable]
        public void Registartion()
        {
            //test = Reports.StartTest("DemoReportPass");
            //test.Log(LogStatus.Pass, "Assert Pass as condition is True");


           //HomePage objHome = new HomePage();

            Driver.FindElement(By.XPath(".//*[@id='menu-item-374']/a")).Click();

            
            List<string> hobbies = new List<string>() { "dance", "cricket" };
            RegistrationPage objReg = new RegistrationPage();

            objReg.Register("Ganesh", "Vinayaka", "Married", hobbies, "India", "7", "25", "1992", "1234567890", "ganesh34", "ganesh34@gmail.com", "I am jack of all trades, masters in Computer Science", "vinayaka", "vinayaka");

            
            try
            {
                Assert.IsTrue(Driver.FindElement(By.XPath("//*[@id=\"post - 49\"]/div/p")).Text.Equals("Thank you for your registration"));
            }
            catch (Exception ex)
            {
                Console.WriteLine("Registration Not Scuessful");
                Console.WriteLine(ex.Message);
            }
        }
    }
}
