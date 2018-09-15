using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace BDD_Assignment.Framework
{
    [Binding]
    public sealed class Hooks
    {
        [BeforeScenario]
        public void BeforeScenario()
        {
            MyDriver.BrowserSetup();
        }

        [AfterScenario]
        public void AfterScenario()
        {
            MyDriver.Close();

        }
    }
}
