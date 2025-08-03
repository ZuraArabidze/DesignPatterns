# DesignPatterns

This repository is my personal learning journey through classic design patterns using C#.  
I am studying patterns based on the following resources:

- *Head First Design Patterns* by Freeman & Robson  
- *Design Patterns: Elements of Reusable Object-Oriented Software* by the Gang of Four (GoF)  
- [Refactoring Guru](https://refactoring.guru/design-patterns)

The goal is to build a solid understanding of each pattern by implementing it with:
- Simple C# examples  
- Real-world analogies  
- Practical usage scenarios  

---

## Strategy Pattern

**Intent**:  
Define a family of algorithms, encapsulate each one, and make them interchangeable.  
Strategy lets the algorithm vary independently from the clients that use it.

**Real-world analogy**:  
Think of a navigation app (like Google Maps) where you can choose different travel strategies:
- Drive  
- Walk 
- Bike 

The route changes based on the selected strategy, but the app interface remains the same.

**When to use it**:
- You have multiple ways to perform an operation (e.g. different payment methods, sorting algorithms).
- You want to avoid long `if-else` or `switch` statements.
- You want to follow the **Open/Closed Principle** — adding new strategies without modifying existing code.