using ClassLibrary1;
using FluentAssertions;

namespace SpecFlowProj.StepDefinitions
{
    [Binding]
    public sealed class CalculatorStepDefinitions
    {
        private Calculator ObjCalculator = new Calculator();
        private int result=0;

        [Given("the first number is (.*)")]
        public void GivenTheFirstNumberIs(int number)
        {
            ObjCalculator.Firstnumber = number;
        }

        [Given("the second number is (.*)")]
        public void GivenTheSecondNumberIs(int number)
        {
            ObjCalculator.Secondnumber = number;
        }

        [When("the two numbers are added")]
        public void WhenTheTwoNumbersAreAdded()
        {
            result = ObjCalculator.Add();
        }

        [Then("the result should be (.*)")]
        public void ThenTheResultShouldBe(int expectedresult)
        {
            result.Should().Be(expectedresult);
        }

        [When(@"the two numbers are subtracted")]
        public void WhenTheTwoNumbersAreSubtracted()
        {
            result = ObjCalculator.Subtract();
        }


    }
}
