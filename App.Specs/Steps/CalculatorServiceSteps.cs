using App.Models;
using FluentAssertions;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;

namespace App.Specs.Steps
{
    [Binding]
    public class CalculatorServiceSteps
    {
        private readonly CalculatorService _calculatorService;

        public CalculatorServiceSteps()
        {
            _calculatorService = new CalculatorService();
        }

        [Given(@"the number of (.*) is added")]
        [When(@"the number of (.*) is added")]
        public void GivenTheNumberIsAdded(decimal p0)
        {
            _calculatorService.Add(p0);
        }

        [Given(@"the operation is sent:")]
        public void GivenTheNumberIsAdded(Table table)
        {
            var action = table.CreateInstance<MathOperation>();

            _calculatorService.Send(action);
        }

        [Given(@"the number of (.*) is subtracted")]
        [When(@"the number of (.*) is subtracted")]
        public void GivenTheNumberIsSubtracted(decimal p0)
        {
            _calculatorService.Subtract(p0);
        }

        [When(@"the numbers are calculated")]
        public void WhenTheNumbersAreCalculated()
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
