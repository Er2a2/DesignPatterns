using BasicExample.Products;

namespace BasicExample.Creators;

public class ConcreteCreatorA : Creator
{
    public override IProduct CreateProduct()
    {
        return new ConcreteProductA();
    }
}
