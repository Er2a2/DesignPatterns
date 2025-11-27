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


---

### 2️. PaymentStrategyExample

A more **real-world** example that applies the Strategy pattern to a payment workflow in a shopping cart.

Demonstrates:

- `IPaymentStrategy` interface as the common contract  
- Multiple payment methods:
  - `CreditCardStrategy`
  - `PayPalStrategy`
  - `BankTransferStrategy`
- `ShoppingCart` as the context that:
  - Accepts a payment strategy via `SetStrategy`
  - Calls `Checkout(amount)` which delegates to `_strategy.Pay(amount)`

Use cases in real applications:

- Choosing payment methods at checkout  
- Switching pricing or discount strategies  
- Selecting shipping cost calculation algorithms  

---

##  When to Use Strategy?
Use this pattern when:

- You need multiple algorithms for the same task
- You want to avoid `if/else` or `switch` mess
- You expect algorithm behavior to change at runtime
- You want to extend functionality without modifying existing logic
