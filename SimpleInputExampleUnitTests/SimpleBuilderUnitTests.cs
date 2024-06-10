using Builders;
namespace SimpleInputExampleUnitTests;

public class SimpleBuilderUnitTests
{
    [Fact]
    public void Method_Should_ReturnSuccess_WhenInputIsDivisibleByTwo()
    {
        SimpleBuilder builder = new SimpleBuilder();

        Assert.True(builder.IsInputDivisibleByTwo(2));

        Assert.True(builder.IsInputDivisibleByTwo(6));
    }
}