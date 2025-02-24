namespace Example.Console.Tests;
public class FrancTests
{
    [Fact]
    public void TestFrancMultiplication()
    {
        Franc five = new(5);
        Assert.Equal(new Franc(10), five.Times(2));
        Assert.Equal(new Franc(15), five.Times(3));
    }



}
