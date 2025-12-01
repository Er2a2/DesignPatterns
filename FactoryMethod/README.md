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

### 2. GameLevelExample

A more **real-world style** example that applies the Factory Method pattern to a game level system.

It demonstrates:

- `IEnemy` as the product interface  
- Concrete enemies:
  - `Goblin`
  - `Ghost`
- Abstract `Level` class as the **Creator**:
  - Declares the factory method: `CreateEnemy()`
  - Implements `EncounterEnemy()` which:
    - Calls `CreateEnemy()`
    - Uses the returned `IEnemy` by calling `Scream()` and `Attack()`
- Concrete levels:
  - `CaveLevel` → creates `Goblin`
  - `HauntedHouseLevel` → creates `Ghost`
- A simple `LevelFactory` that decides which `Level` to create based on a level number

Client example:

```csharp
Level level1 = LevelFactory.CreateLevel(levelNumber: 1);
level1.EncounterEnemy();

Level level2 = new HauntedHouseLevel();
level2.EncounterEnemy();
```


---


### 🧩 Simple Factory vs Factory Method in this example

This example demonstrates **two** ways of deciding which enemy to create:

| Code | Who decides enemy type? | Pattern |
|------|-----------------------|--------|
| `LevelFactory.CreateLevel(1)` | External factory | Simple Factory |
| `new HauntedHouseLevel()` | The subclass (`CreateEnemy()`) | Factory Method |

The key idea:

> Factory Method shifts the decision of *what to create* into subclasses,  
> improving flexibility and following **Open/Closed Principle (OCP)**.


##  When to Use FactoryMethod?
Use this pattern when:

- A class cannot anticipate the specific class of objects it must create
- You want to delegate the responsibility of deciding which product to create
- You want to follow the Open/Closed Principle, adding products without modifying client code
- You want classes to depend on abstractions (DIP)