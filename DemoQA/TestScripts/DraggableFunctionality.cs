using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using NUnit.Framework;
using OpenQA.Selenium;
using DemoQA.Environment;
using DemoQA.PageObjects;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Interactions.Internal;
using OpenQA.Selenium.Support.UI;

namespace DemoQA.TestScripts
{
    class DraggableFunctionality : BaseTest
    {

        [Test]
        public void Tab1Functions()
        {
            HomePage Hobj = new HomePage();
            Hobj.Draggable.Click();
            Thread.Sleep(2000);
            DraggablesPage Dobj = new DraggablesPage();

            Actions builder = new Actions(Driver);

            builder.ClickAndHold(Dobj.Tab1DragMe)
                .MoveByOffset(400, 600)
                .Release()
                .Build().Perform();

//            Dobj.Tab1DragMe.

        }
        [Test]
        public void Tab2Functionality()
        {
            HomePage Hobj = new HomePage();
            Hobj.Draggable.Click();
            Thread.Sleep(2000);
            DraggablesPage Dobj = new DraggablesPage();
            Dobj.sideTabs.ElementAt(1).Click();

            Actions builder = new Actions(Driver);

            builder.ClickAndHold(Dobj.Tab2Vertical)
                .MoveByOffset(400, 600)
                .Release()
                .Build().Perform();

            builder.ClickAndHold(Dobj.Tab2Horizontal)
                .MoveByOffset(400, 600)
                .Release()
                .Build().Perform();

            builder.ClickAndHold(Dobj.Tab2InBox)
                .MoveByOffset(400, 600)
                .Release()
                .Build().Perform();

            builder.ClickAndHold(Dobj.Tab2InInBox)
                .MoveByOffset(400, 600)
                .Release()
                .Build().Perform();
        }
    }
}
