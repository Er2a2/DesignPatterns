namespace TeslaExample;

public class TeslaDecorator : ITeslaModel3
{
    protected readonly ITeslaModel3 _car;

    public TeslaDecorator(ITeslaModel3 car)
    {
        _car = car;
    }

    public virtual string GetDescription()
    {
        return _car.GetDescription();
    }

    public virtual decimal GetPrice()
    {
        return _car.GetPrice();
    }

    public virtual int GetRange()
    {
        return _car.GetRange();
    }
}
