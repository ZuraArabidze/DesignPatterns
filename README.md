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

## Observer Pattern

**Intent**:
Define a one-to-many dependency between objects so that when one object (the subject) changes state, 
all its dependents (observers) are notified and updated automatically.

**Real-world analogy**:  
Think of a YouTube channel:
-You (the subscriber) subscribe to a channel (the subject).
-When the channel uploads a new video, you get notified.
-The channel doesn’t care who you are; it just broadcasts updates.

**When to use it**:
-When changes in one object need to automatically trigger updates in other objects.
-To implement event systems, notifications, or data binding.
-To decouple the object that produces data (subject) from those that consume it (observers).

## Decorator Pattern

**Intent**:
Attach additional responsibilities to an object dynamically.
Decorators provide a flexible alternative to subclassing for extending functionality.

**Real-world analogy**:  
Think of a coffee shop where you start with a base coffee and then add toppings:

Espresso → + Milk → + Caramel
Each topping wraps the original drink, adding new behavior (like price or ingredients).

**When to use it**:
-You want to add responsibilities to individual objects, not an entire class.
-You want to follow the Open/Closed Principle — extend behavior without modifying the existing code.
-Subclassing would lead to an explosion of subclasses for every combination.

## Factory Method Pattern

**Intent**:
Define an interface for creating an object, but let subclasses alter the type of objects that will be created.

**Real-world analogy**:
Imagine a logistics company with different transport modes:

-Truck for road logistics
-Ship for sea logistics
-Each subclass decides which product (transport) to instantiate.

**When to use it**:
-You want to delegate the responsibility of instantiating objects to subclasses.
-The exact type of object isn't known until runtime.
-You want to follow the Single Responsibility Principle by separating object creation from its usage.

## Abstract Factory Pattern

**Intent**:
Provide an interface for creating families of related or dependent objects without specifying their concrete classes.

**Real-world analogy**:
Think of a UI toolkit that can switch between Light and Dark themes. Each theme provides:

-Buttons
-Textboxes
-Scrollbars

All components must match the theme (family of products).

**When to use it**:
-You need to ensure that related products are used together.
-You want to isolate the creation of families of objects.
-You want to follow the Dependency Inversion Principle — depend on abstractions, not concrete classes

## Singleton Pattern

**Intent**:
Ensure a class has only one instance and provide a global point of access to it.

**Real-world analogy**:
Think of a president of a country — at any given time, there should only be one.
No matter how many people refer to “the president,” it always points to the same individual.

**When to use it**:
-You need exactly one instance of a class, shared across the system (e.g. configuration manager, logging, caching).
-You want controlled access to the instance.