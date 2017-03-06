using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace DemoQA.Environment
{
    static class BaseProperties
    {
        public static void SetClick(this IWebElement element)
        {
            element.Click();
        }
        public static void SetInput(this IWebElement element, string value)
        {
            element.SendKeys(value);
        }
        public static void SetSubmit(this IWebElement element)
        {
            element.Submit();
        }
        public static void SetDLL(this IWebElement element, string value)
        {
            new SelectElement(element).SelectByValue(value);
        }
    }
}
