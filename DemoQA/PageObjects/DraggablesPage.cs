using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using DemoQA.Environment;

namespace DemoQA.PageObjects
{
    class DraggablesPage
    {
        public DraggablesPage()
        {
            PageFactory.InitElements(BaseTest.Driver, this);
        }

        public string PageURL()
        {
            return BaseTest.Driver.Url.ToString();
        }


        [FindsBy(How=How.ClassName,Using = "ui-tabs-anchor")]
        public IList<IWebElement> sideTabs { get; set; }

        [FindsBy(How=How.Id,Using = "draggable")]
        public IWebElement Tab1DragMe { get; set; }

        [FindsBy(How=How.Id,Using = "draggabl")]
        public IWebElement Tab2Vertical { get; set; }

        [FindsBy(How=How.Id,Using = "draggabl2")]
        public IWebElement Tab2Horizontal { get; set; }

        [FindsBy(How=How.Id,Using = "draggabl3")]
        public IWebElement Tab2InBox { get; set; }

        [FindsBy(How=How.Id,Using="draggabl5")]
        public IWebElement Tab2InInBox { get; set; }

        [FindsBy(How = How.Id, Using = "drag")]
        public IWebElement Tab3MouseCenter { get; set; }

        [FindsBy(How = How.Id, Using = "drag2")]
        public IWebElement Tab3MouseLeft { get; set; }
        
        [FindsBy(How = How.Id, Using = "drag3")]
        public IWebElement Tab3MouseBottom { get; set; }

        [FindsBy(How = How.Id, Using = "dragevent")]
        public IWebElement Tab4ChainBox { get; set; }



    }
}
