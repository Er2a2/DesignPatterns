namespace BasicExample.Products
{
    public class ConcreteProductB : IProduct
    {
        public void DoWork()
        {
            Console.WriteLine("ConcreteProductB is doing something else...");
        }
    }
}
