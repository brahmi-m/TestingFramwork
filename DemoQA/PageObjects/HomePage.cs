using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DemoQA.Environment;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support;
using OpenQA.Selenium.Support.PageObjects;

namespace DemoQA.PageObjects
{
    class HomePage:BaseTest
    {
        public HomePage()
        {
            PageFactory.InitElements(Driver, this);
        }

        public string PageURL()
        {
            return Driver.Url.ToString();
        }


        [FindsBy(How = How.XPath, Using = ".//*[@id='menu-item-374']/a")]
        public IWebElement Registration { get; set; }

        [FindsBy(How = How.XPath, Using = ".//*[@id='menu-item-140']/a")]
        public IWebElement Draggable { get; set; }

        [FindsBy(How = How.XPath, Using = ".//*[@id='menu-item-141']/a")]
        public IWebElement Droppable { get; set; }

        [FindsBy(How = How.XPath, Using = ".//*[@id='menu-item-143']/a")]
        public IWebElement Resizable { get; set; }

        [FindsBy(How = How.XPath, Using = ".//*[@id='menu-item-142']/a")]
        public IWebElement Selectable { get; set; }

        [FindsBy(How = How.XPath, Using = ".//*[@id='menu-item-151']/a")]
        public IWebElement Sortable { get; set; }

        [FindsBy(How = How.XPath, Using = ".//*[@id='menu-item-144']/a")]
        public IWebElement Accordion { get; set; }

        [FindsBy(How = How.XPath, Using = ".//*[@id='menu-item-145']/a")]
        public IWebElement Autocomplete { get; set; }

        [FindsBy(How = How.XPath, Using = ".//*[@id='menu-item-146']/a")]
        public IWebElement DatePicker { get; set; }

        [FindsBy(How = How.XPath, Using = ".//*[@id='menu-item-147']/a")]
        public IWebElement Menu { get; set; }

        [FindsBy(How = How.XPath, Using = ".//*[@id='menu-item-97']/a")]
        public IWebElement Slider { get; set; }

        [FindsBy(How = How.XPath, Using = ".//*[@id='menu-item-98']/a")]
        public IWebElement Tabs { get; set; }

        [FindsBy(How = How.XPath, Using = ".//*[@id='menu-item-99']/a")]
        public IWebElement Tooltips { get; set; }

        [FindsBy(How = How.XPath, Using = ".//*[@id='menu-item-148']/a")]
        public IWebElement FramesAndWindows { get; set; }

        [FindsBy(How = How.XPath, Using = ".//*[@id='post-9']/div/div[1]/div/p[1]/a/img")]
        public IWebElement Img1 { get; set; }

        [FindsBy(How = How.XPath, Using = ".//*[@id='post-9']/div/div[2]/div/p[1]/i/a/img")]
        public IWebElement Img2 { get; set; }

        [FindsBy(How = How.XPath, Using = ".//*[@id='post-9']/div/div[3]/div/i/a/img")]
        public IWebElement Img3 { get; set; }

        [FindsBy(How = How.XPath, Using = ".//*[@id='tab_ul']/li")]
        public IList<IWebElement> TabsJs { get; set; }

        /*
                public void Registration()
                {
                    BaseProperties.SetClick(Registration);
                }
                public void Draggable()
                {
                }
                public void Droppable()
                {
                }
                public void Resizable()
                {
                }
                public void Selectable()
                {
                }
                public void Sortable()
                {
                }
                public void Accordion()
                {
                }
                public void Autocomplete()
                {
                }
                public void Datepicker()
                {

                }
                public void Menu()
                {
                }
                public void Slider()
                {
                }
                public void Tabs()
                {
                }
                public void Tooltip()
                {
                }
                    */


    }
}
