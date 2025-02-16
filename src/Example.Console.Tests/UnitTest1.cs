namespace Example.Console.Tests;

public class UnitTest1
{
    [Fact]
    public void TestMultiplication()
    {
        Dollar five = new(5);
        five.Times(2);
        Assert.Equal(10, five.Amount);
    }



}
