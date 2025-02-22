
namespace Example.Console;
public class Dollar
{
    private int Amount;

    public Dollar(int amount)
    {
         Amount = amount;
    }

    public Dollar Times(int multiplier)
    {
        return new Dollar(Amount * multiplier);
    }

    public override bool Equals(object? obj)
    {
        Dollar dollar = (Dollar)obj;
        return Amount == dollar.Amount;
    }
}
