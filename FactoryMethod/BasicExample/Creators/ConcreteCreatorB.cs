using BasicExample.Products;

namespace BasicExample.Creators;

public class ConcreteCreatorB : Creator
{
    public override IProduct CreateProduct()
    {
        return new ConcreteProductB();
    }
}
