namespace BasicExample;

public class ConcreteDecorator2 : Decorator
{
    public ConcreteDecorator2(Component component) : base(component) { }

    public override void Operation()
    {
        Console.WriteLine("------- Concrete Decorator 2 -------");
        _component.Operation();
        Console.WriteLine("------- Concrete Decorator 2 -------");
    }
}
