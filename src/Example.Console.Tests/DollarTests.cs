namespace Example.Console.Tests;

public class DollarTests
{
    [Fact]
    public void TestMultiplication()
    {
        Dollar five = new(5); 
        Assert.Equal(new Dollar(10), five.Times(2)); 
        Assert.Equal(new Dollar(15), five.Times(3));
    }


    [Fact]
    public void TestEqual()
    {
        Assert.True(new Dollar(5).Equals(new Dollar(5)));
        Assert.False(new Dollar(5).Equals(new Dollar(6)));
    }
}
