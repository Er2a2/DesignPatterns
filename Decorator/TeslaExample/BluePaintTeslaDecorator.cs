namespace TeslaExample;

public class BluePaintTeslaDecorator : TeslaDecorator
{
    public BluePaintTeslaDecorator(ITeslaModel3 car) : base(car) { }

    public override decimal GetPrice()
    {
        return base.GetPrice() + 1000;
    }

    public override string GetDescription()
    {
        return $"{base.GetDescription()}, Blue Paint";
    }
}
