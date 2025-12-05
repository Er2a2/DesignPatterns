namespace BasicExample;

public class ConcreteDecorator1 : Decorator
{
    public ConcreteDecorator1(Component component) : base(component) { }

    public override void Operation()
    {
        Console.WriteLine("------- Concrete Decorator 1 -------");
        _component.Operation();
        Console.WriteLine("------- Concrete Decorator 1 -------");
    }
}
