# Decorator Pattern

The **Decorator** is a structural design pattern that lets you attach additional responsibilities to objects dynamically.  
It provides a flexible alternative to subclassing for extending behavior.

Instead of creating many subclasses for every combination of features,  
you wrap objects inside decorator objects that add behavior before/after delegating to the wrapped object.

---

### 1️. BasicExample

A minimal and educational implementation of the Decorator pattern.

It demonstrates:

- A `Component` interface with a single operation: `Operation()`
- A `ConcreteComponent` that provides the base behavior
- An abstract `Decorator` class that:
  - Implements `Component`
  - Stores a reference to another `Component`
  - Delegates the call to the wrapped component
- Two concrete decorators:
  - `ConcreteDecorator1`
  - `ConcreteDecorator2`
  Each adds behavior **before and after** calling the wrapped component.

Client code (example):

```csharp
Component component = new ConcreteDecorator2(
    new ConcreteDecorator1(
        new ConcreteDecorator1(
            new ConcreteComponent())));

component.Operation();
```

---

### 2. TeslaExample

A real-world application of the Decorator pattern for **configuring a Tesla Model 3**.
This example demonstrates how different optional features can be added to a base car dynamically using decorators.

### Structure

| Role | Class |
|------|------|
| Component Interface | `ITeslaModel3` |
| Base Component | `BasicTeslaModel3` |
| Abstract Decorator | `TeslaDecorator` |
| Concrete Decorators | `RedPaintTeslaDecorator`, `BluePaintTeslaDecorator`, `LongRangeTeslaDecorator` |

Each decorator adds new behavior such as:

- Increasing price
- Updating description
- Improving driving range

### Example usage:

```csharp
ITeslaModel3 car = new LongRangeTeslaDecorator(
    new RedPaintTeslaDecorator(
        new BasicTeslaModel3()));

Console.WriteLine($"Description: {car.GetDescription()}");
Console.WriteLine($"Price: {car.GetPrice()}");
Console.WriteLine($"Range: {car.GetRange()}");
```

---


##  When to Use Decorator?
Use this pattern when:

- You want to add responsibilities to objects dynamically at runtime.
- You want to avoid a large class hierarchy of subclasses for every feature combination.
- You want to follow the Open/Closed Principle:
- Add new behavior via new decorators without modifying existing code.
- You need flexible and composable behavior (e.g., logging, caching, validation).

