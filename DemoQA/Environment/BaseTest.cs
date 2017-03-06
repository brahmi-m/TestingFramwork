using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support;
using System.Threading;
using System.Drawing.Imaging;
using RelevantCodes.ExtentReports;
using NUnit.Framework.Interfaces;

namespace DemoQA.Environment
{
    [TestFixture]
    class BaseTest
    {
        public static IWebDriver Driver { get; set; }
        public static ExtentReports Reports { get; set; }

        public static ExtentTest test;

        [SetUp]
        public void Start()
        {
            Console.WriteLine("Test Has Started");
            Driver = new ChromeDriver();
            Driver.Manage().Window.Maximize();
            Driver.Navigate().GoToUrl("http://demoqa.com/");

  //          GetReport("myOwnReport");
        }

        [TearDown]
        public void Terminate()
        {
 //           EndReport();
            Console.WriteLine("Test Has Ended");
            Thread.Sleep(5000);
            Driver.Quit();
        }

        public static string ProjectPath()
        {
            string path = System.Reflection.Assembly.GetCallingAssembly().CodeBase;
            string actualPath = path.Substring(0, path.LastIndexOf("bin"));
            string projectPath = new Uri(actualPath).LocalPath;

            return projectPath;
        }
        public static void TakeScreenShot(string filename)
        {
            string screenshotPath = ProjectPath() + "ScreenShots\\" + filename + ".png";
            ITakesScreenshot screenshotDriver = Driver as ITakesScreenshot;
            Screenshot screenshot = screenshotDriver.GetScreenshot();
            screenshot.SaveAsFile(screenshotPath, ImageFormat.Jpeg);

            /*       - Or -        */

            //ITakesScreenshot ss = (ITakesScreenshot)Driver;
            //ss.GetScreenshot().SaveAsFile(@"C:\Users\brahm\Documents\Visual Studio 2015\Projects\QATesting\DemoQA\Reports\" + filename + ".jpeg", ImageFormat.Jpeg);
        }

        public static void GetReport(string filename)
        {

            string reportPath = ProjectPath() + "Reports\\" + filename + ".html";

            Reports = new ExtentReports(@"C:\Users\brahm\Documents\Visual Studio 2015\Projects\QATesting\DemoQA\Reports\" + filename + ".html",true);

            Reports.AddSystemInfo("Host Name", "B K M")
                   .AddSystemInfo("Environment", "QATesting");

            Reports.LoadConfig(ProjectPath() + "extent-config.xml");

            var status = TestContext.CurrentContext.Result.Outcome.Status;
            var stackTrace = "&lt;pre&gt;" + TestContext.CurrentContext.Result.StackTrace + "&lt;/pre&gt;";
            var errorMessage = TestContext.CurrentContext.Result.Message;

            if (status == TestStatus.Failed)
            {
                test.Log(LogStatus.Fail, stackTrace + errorMessage);
            }
        }
        public static void EndReport()
        {
            Reports.EndTest(test);
            Reports.Flush();
            Reports.Close();

        }

    }
}
