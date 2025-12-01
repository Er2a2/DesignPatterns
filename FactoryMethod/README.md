# Factory Method Pattern

The **Factory Method** is a creational design pattern that defines an interface for creating objects,  
but lets subclasses decide which concrete class to instantiate.

Instead of instantiating products directly using `new`,  
you delegate the creation logic to a dedicated "creator" class.

---

### 1️. BasicExample

A minimal and educational implementation of the Factory Method pattern.

It demonstrates:

- A common `IProduct` interface
- Two concrete products:
  - `ConcreteProductA`
  - `ConcreteProductB`
- An abstract `Creator` class that:
  - Declares the factory method: `CreateProduct()`
  - Defines a `Run()` method that:
    - Calls `CreateProduct()`
    - Uses the returned product (`product.DoWork()`)

Concrete creators:

- `ConcreteCreatorA` → creates `ConcreteProductA`
- `ConcreteCreatorB` → creates `ConcreteProductB`

Client code:

```csharp
Creator creatorA = new ConcreteCreatorA();
creatorA.Run();

Creator creatorB = new ConcreteCreatorB();
creatorB.Run();
```

---

##  When to Use FactoryMethod?
Use this pattern when:

- A class cannot anticipate the specific class of objects it must create
- You want to delegate the responsibility of deciding which product to create
- You want to follow the Open/Closed Principle, adding products without modifying client code
- You want classes to depend on abstractions (DIP)