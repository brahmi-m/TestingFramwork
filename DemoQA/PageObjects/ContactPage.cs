using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DemoQA.Environment;
using OpenQA.Selenium;
using OpenQA.Selenium.Support;
using OpenQA.Selenium.Support.PageObjects;

namespace DemoQA.PageObjects
{
    class ContactPage : BaseTest
    {
        public ContactPage()
        {
            PageFactory.InitElements(Driver, this);
        }

        [FindsBy(How = How.CssSelector, Using = ".wpcf7-form-control.wpcf7-text.wpcf7-validates-as-required")]
        public IWebElement NameField { get; set; }

        [FindsBy(How = How.CssSelector, Using = ".wpcf7-form-control.wpcf7-text.wpcf7-email.wpcf7-validates-as-required.wpcf7-validates-as-email")]
        public IWebElement EmailField { get; set; }

        [FindsBy(How = How.CssSelector, Using = ".wpcf7-form-control.wpcf7-text")]
        public IWebElement SubjectField { get; set; }

        [FindsBy(How = How.CssSelector, Using = ".wpcf7-form-control.wpcf7-textarea")]
        public IWebElement MsgField { get; set; }
        [FindsBy(How=How.CssSelector,Using =".wpcf7-form-control.wpcf7-submit")]
        public IWebElement SubmitBtn { get; set; }

        public void SendMsg(string name, string email, string subject, string message)
        {
            NameField.SetInput(name);
            EmailField.SetInput(email);
            SubjectField.SetInput(subject);
            MsgField.SendKeys(message);
            SubmitBtn.SetSubmit();
        }
    }
}
