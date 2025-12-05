namespace TeslaExample;

public class RedPaintTeslaDecorator : TeslaDecorator
{
    public RedPaintTeslaDecorator(ITeslaModel3 car) : base(car) { }

    public override decimal GetPrice()
    {
        return base.GetPrice() + 2000;
    }

    public override string GetDescription()
    {
        return $"{base.GetDescription()}, Red Paint";
    }
}