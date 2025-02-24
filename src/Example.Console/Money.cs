namespace Example.Console;
public class Money
{
    protected int Amount;

    public override bool Equals(object? obj)
    {
        if (obj is not Money money) return false;
        return Amount == money.Amount && GetType() == money.GetType();
    }
}
