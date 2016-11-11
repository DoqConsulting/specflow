using Baseclass.Contrib.SpecFlow.Selenium.NUnit.Bindings;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace SpecFlowApresentacao.Utils.Starts
{
    [Binding]
    public class GenericDriver
    {
        private IWebDriver _instance;
        public IWebDriver Instance
        {
            get
            {
                Wait.Until(t => { _instance = t; return t; });
                return _instance;
            }
        }

        private WebDriverWait wait;

        public WebDriverWait Wait
        {
            get
            {
                if (wait == null)
                    wait = new WebDriverWait(Browser.Current, TimeSpan.FromSeconds(2));

                return wait;
            }
        }
        public static void Dispose()
        {
            Browser.Current.Close();
            Browser.Current.Dispose();
            Browser.Current.Quit();

        }

    }
}
