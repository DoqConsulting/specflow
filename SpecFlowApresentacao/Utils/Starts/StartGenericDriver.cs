using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace SpecFlowApresentacao.Utils.Starts
{
    [TestFixture]
    public class StartGenericDriver : GenericDriver
    {
        [TearDown]
        public void TearDown()

        {
            Dispose();

        }

        [BeforeScenario]
        public void Setup()
        {
            //navegar para url base
        }

        [AfterScenario("after")]
        public void after()

        {
            Dispose();

        }
    }
}