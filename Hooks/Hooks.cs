using BoDi;
using SpecFlowProjectTest.Support;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;

namespace SpecFlowProjectTest.Hooks
{
    [Binding]
    public class Hooks
    {
        private readonly IObjectContainer _objectContainer;

        public Hooks(IObjectContainer objectContainer)
        {
            _objectContainer = objectContainer;
        }

        [BeforeScenario]
        public void BeforeScenario()
        {
            _objectContainer.RegisterInstanceAs(new PageFactory());
        }

        [AfterScenario]
        public void AfterScenario(ScenarioContext context)
        {
            _objectContainer.Resolve<PageFactory>().Driver.Dispose();
        }
    }
}

