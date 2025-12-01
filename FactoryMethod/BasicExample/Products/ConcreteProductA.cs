namespace BasicExample.Products;

public class ConcreteProductA : IProduct
{
    public void DoWork()
    {
        Console.WriteLine("ConcreteProductA is doing its work...");
    }
}
