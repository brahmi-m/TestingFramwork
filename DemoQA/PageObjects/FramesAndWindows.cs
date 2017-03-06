using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DemoQA.Environment;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace DemoQA.PageObjects
{
    class FramesAndWindows:BaseTest
    {
        public FramesAndWindows()
        {
            PageFactory.InitElements(Driver, this);
        }

        [FindsBy(How=How.Id,Using = "ui-id-1")]
        public IWebElement NewWindow { get; set; }

        [FindsBy(How=How.Id,Using = "ui-id-2")]
        public IWebElement SeparateWindow { get; set; }

        [FindsBy(How=How.Id,Using = "ui-id-3")]
        public IWebElement Frameset { get; set; }

        [FindsBy(How = How.XPath, Using = ".inside_contain>p>a")]
        public IWebElement NewBrowserTab { get; set; }

        [FindsBy(How = How.XPath, Using = ".inside_contain>p>a")]
        public IWebElement SeparateWindowTab { get; set; }

        [FindsBy(How = How.XPath, Using = ".inside_contain>p>a")]
        public IWebElement FramesetWindow { get; set; }




    }

}
