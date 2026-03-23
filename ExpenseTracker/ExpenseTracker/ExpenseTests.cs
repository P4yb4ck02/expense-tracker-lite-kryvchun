using Xunit;
using ExpenseTrackerLite;

namespace ExpenseTrackerLite.Tests
{
    public class ExpenseServiceTests
    {
        [Fact]
        public void GetTotal_WhenMultipleExpensesAdded_ShouldReturnCorrectSum()
        {
            // Arrange
            var service = new ExpenseService();
            decimal expense1 = 100.50m;
            decimal expense2 = 200.25m;
            decimal expectedTotal = 300.75m;

            // Act 
            service.AddExpense(expense1);
            service.AddExpense(expense2);
            decimal actualTotal = service.GetTotal();

            // Assert 
            Assert.Equal(expectedTotal, actualTotal);
        }

        [Theory]
        [InlineData(10, true)]
        [InlineData(0, false)]
        [InlineData(-5, false)]
        public void IsValidAmount_ShouldValidateCorrectly(decimal amount, bool expected)
        {
 
            bool result = Validator.IsValidAmount(amount);

            Assert.Equal(expected, result);
        }
    }
}