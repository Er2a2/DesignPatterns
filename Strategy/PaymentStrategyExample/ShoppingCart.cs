namespace PaymentStrategyExample;

public class ShoppingCart
{
    private IPaymentStrategy? _strategy;

    public void SetStrategy(IPaymentStrategy? strategy)
    {
        _strategy = strategy;
    }

    public void Checkout(decimal amount)
    {
        if (_strategy is null)
        {
            Console.WriteLine("No payment strategy selected.");
            return;
        }
        _strategy?.Pay(amount);
    }
}
