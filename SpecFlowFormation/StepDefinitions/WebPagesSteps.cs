using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecFlowFormation.StepDefinitions
{
    [Binding]
    public class WebPagesSteps
    {
        [When(@"the submission page is open")]
        public void WhenTheSubmissionPageIsOpen()
        {
            throw new PendingStepException();
        }


        [Then(@"the title of the page is '([^']*)'")]
        public void ThenTheTitleOfThePageIs(string pageTitle)
        {
            throw new PendingStepException();
        }


    }
}
