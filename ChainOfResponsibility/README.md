# Chain of Responsibility Pattern

The **Chain of Responsibility** is a behavioral design pattern that lets you pass a request through a sequence of handlers.  
Each handler decides either to process the request or forward it to the next one in the chain.

This folder contains **two implementations** of the pattern:

---

#  1. BasicExample
A minimal and educational implementation of the Chain of Responsibility pattern.

- Shows the core structure of handlers.
- Good for understanding how the chain forwards requests.
- Easy to read and ideal for beginners.

 Includes:
- Abstract `Handler`
- Three concrete handlers (`ConcreteHandler1/2/3`)
- Simple string-based request flow