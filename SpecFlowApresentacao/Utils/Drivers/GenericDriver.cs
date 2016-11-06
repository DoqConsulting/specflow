using Baseclass.Contrib.SpecFlow.Selenium.NUnit.Bindings;
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
        private static WebDriverWait wait;

        public static WebDriverWait Wait
        {
            get
            {
                if (wait == null)
                    wait = new WebDriverWait(Browser.Current, TimeSpan.FromSeconds(20));


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
