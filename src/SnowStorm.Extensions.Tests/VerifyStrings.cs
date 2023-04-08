using Shouldly;
using Xunit;

namespace SnowStorm.Extensions.Tests
{
    public class VerifyStrings
    {
        [Theory]
        [InlineData("123", true)]
        [InlineData("123.45", true)]
        [InlineData("123.456", true)]
        [InlineData("1abc2", false)]
        [InlineData("123abc", false)]
        public void VerifyIsNumeric(string value, bool result)
        {
            value.IsNumeric().ShouldBe(result);
        }
    }
}