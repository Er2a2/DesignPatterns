using BasicExample;

// client
Context context = new();

context.SetStrategy(new ConcreteStrategyA());
context.ExecuteStrategy();

context.SetStrategy(new ConcreteStrategyB());
context.ExecuteStrategy();

context.SetStrategy(new ConcreteStrategyC());
context.ExecuteStrategy();