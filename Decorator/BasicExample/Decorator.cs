namespace BasicExample;

public abstract class Decorator : Component
{
    protected readonly Component _component;

    public Decorator(Component component)
    {
        _component = component;
    }

    public virtual void Operation()
    {
        _component.Operation();
    }
}
