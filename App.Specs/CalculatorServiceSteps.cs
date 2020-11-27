using FluentAssertions;
using TechTalk.SpecFlow;

namespace App.Specs
{
    [Binding]
    public class CalculatorServiceSteps
    {
        private readonly CalculatorService _calculatorService;

        public CalculatorServiceSteps()
        {
            _calculatorService = new CalculatorService();
        }

        [Given(@"the first number of (.*) is added")]
        public void GivenTheFirstNumberIs(decimal p0)
        {
            _calculatorService.Add(p0);
        }
        
        [Given(@"the second number of (.*) is added")]
        public void GivenTheSecondNumberIs(decimal p0)
        {
            _calculatorService.Add(p0);
        }

        [Given(@"the third number of (.*) is subtracted")]
        public void GivenTheThirdNumberIs(decimal p0)
        {
            _calculatorService.Subtract(p0);
        }
        
        [When(@"the numbers are calculated")]
        public void WhenTheTwoNumbersAreAdded()
        { 
            _calculatorService.Calculate();
        }

        [Then(@"the result should be (.*)")]
        public void ThenTheResultShouldBe(decimal p0)
        {
            _calculatorService.Total().Should().Be(p0);
        }
    }
}
