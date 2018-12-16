using System;
using TechTalk.SpecFlow;
using SateliteDemo.Service;
using Xunit;

namespace SateliteDemo.Tests
{
    [Binding]
    public class SateliteSteps
    {
        private int result;
        Satelite satelite = new Satelite();
        [Given(@"I have entered (.*)")]
        public void GivenIHaveEntered(int hours)
        {
            satelite.Hours = 24;
        }
        
        [When(@"I press Get Data")]
        public void WhenIPressGetData()
        {
            satelite.GetData();
        }
        
        [Then(@"the result should be a (.*) lines of data on the screen")]
        public void ThenTheResultShouldBeALinesOfDataOnTheScreen(int expectedResult)
        {
            Assert.Equal(expectedResult, result);
        }
    }
}
