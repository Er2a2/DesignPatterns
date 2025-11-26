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

#  2. SpamDetectionExample
A more **realistic and practical** example that applies the pattern to a spam detection workflow.

This example demonstrates:
- Keyword-based spam detection  
- Blacklist checking  
- Simple ML-like prediction  
- Real-world `Email` request model  

It shows how the Chain of Responsibility can be used in real applications such as:
- Email filtering  
- Validation pipelines  
- Rule engines  
- Middleware chains  

---

#  When to Use this Pattern?
Use Chain of Responsibility when:
- Multiple handlers may process a request.
- The sender should not know which handler will process it.
- You want to add/remove handlers easily without modifying existing code.

---