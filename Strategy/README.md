# Strategy Pattern

The **Strategy** is a behavioral design pattern that enables selecting an algorithm's behavior at runtime.  
It helps you define a family of algorithms, encapsulate each one, and make them interchangeable without changing the client code.

---


### 1️. BasicExample
A minimal and educational implementation of the Strategy pattern.

Shows how to:
- Define a common strategy interface
- Implement multiple strategy variations
- Switch strategies at runtime through a `Context`
- Follow **Open/Closed Principle (OCP)**

 Contains:
- `Strategy` interface
- `ConcreteStrategyA/B/C`
- `Context` class responsible for using selected strategy

Use cases:
- Payment method selection (Credit Card / PayPal / Crypto)
- Sorting algorithms (QuickSort / MergeSort / BubbleSort)
- Logging strategies (Console / File / Cloud)
- Promotion or pricing rules in e-commerce

More real-world examples will be added later.

---

##  When to Use Strategy?
Use this pattern when:

- You need multiple algorithms for the same task
- You want to avoid `if/else` or `switch` mess
- You expect algorithm behavior to change at runtime
- You want to extend functionality without modifying existing logic
