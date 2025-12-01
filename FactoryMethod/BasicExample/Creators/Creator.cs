using BasicExample.Products;

namespace BasicExample.Creators;

public abstract class Creator
{
    public abstract IProduct CreateProduct();

    public void Run()
    {
        var product = CreateProduct();
        product.DoWork();
    }
}
