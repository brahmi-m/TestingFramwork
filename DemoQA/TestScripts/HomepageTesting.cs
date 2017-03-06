using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using DemoQA.PageObjects;
using DemoQA.Environment;
using System.Threading;
using RelevantCodes.ExtentReports;

namespace DemoQA.TestScripts
{
    class HomepageTesting : BaseTest
    {

        [Test]
        [Parallelizable]
        public void ImageTesting()
        {
            //test = Reports.StartTest("DemoReportPass");
            //test.Log(LogStatus.Pass, "Assert Pass as condition is True");
            Console.WriteLine("Test Method");

            HomePage Hobj = new HomePage();

            Hobj.Img1.Click();
            Thread.Sleep(2500);
            TakeScreenShot("image1");
            Driver.Navigate().Back();

            Hobj.Img2.Click();
            Thread.Sleep(2500);
            TakeScreenShot("image2");
            Driver.Navigate().Back();

            Hobj.Img3.Click();
            Thread.Sleep(2500);
            TakeScreenShot("image3");
            Driver.Navigate().Back();

        }
        [Test]
        [Parallelizable]
        public void TabsTesting()
        {

            //test = Reports.StartTest("DemoReportPass");
            //test.Log(LogStatus.Pass, "Assert Pass as condition is True");

            HomePage Hobj = new HomePage();


            for (int i = 0; i < Hobj.TabsJs.Count; i++)
            {
                Hobj.TabsJs.ElementAt(i).Click();
                 
            }
        }
    }
}
