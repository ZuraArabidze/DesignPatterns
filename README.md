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
- You (the subscriber) subscribe to a channel (the subject).
- When the channel uploads a new video, you get notified.
- The channel doesn’t care who you are; it just broadcasts updates.

**When to use it**:
- When changes in one object need to automatically trigger updates in other objects.
- To implement event systems, notifications, or data binding.
- To decouple the object that produces data (subject) from those that consume it (observers).

## Decorator Pattern

**Intent**:
Attach additional responsibilities to an object dynamically.
Decorators provide a flexible alternative to subclassing for extending functionality.

**Real-world analogy**:  
Think of a coffee shop where you start with a base coffee and then add toppings:

Espresso → + Milk → + Caramel
Each topping wraps the original drink, adding new behavior (like price or ingredients).

**When to use it**:
- You want to add responsibilities to individual objects, not an entire class.
- You want to follow the Open/Closed Principle — extend behavior without modifying the existing code.
- Subclassing would lead to an explosion of subclasses for every combination.

## Factory Method Pattern

**Intent**:
Define an interface for creating an object, but let subclasses alter the type of objects that will be created.

**Real-world analogy**:
Imagine a logistics company with different transport modes:

- Truck for road logistics
- Ship for sea logistics
- Each subclass decides which product (transport) to instantiate.

**When to use it**:
- You want to delegate the responsibility of instantiating objects to subclasses.
- The exact type of object isn't known until runtime.
- You want to follow the Single Responsibility Principle by separating object creation from its usage.

## Abstract Factory Pattern

**Intent**:
Provide an interface for creating families of related or dependent objects without specifying their concrete classes.

**Real-world analogy**:
Think of a UI toolkit that can switch between Light and Dark themes. Each theme provides:

- Buttons
- Textboxes
- Scrollbars

All components must match the theme (family of products).

**When to use it**:
- You need to ensure that related products are used together.
- You want to isolate the creation of families of objects.
- You want to follow the Dependency Inversion Principle — depend on abstractions, not concrete classes

## Singleton Pattern

**Intent**:
Ensure a class has only one instance and provide a global point of access to it.

**Real-world analogy**:
Think of a president of a country — at any given time, there should only be one.
No matter how many people refer to “the president,” it always points to the same individual.

**When to use it**:
- You need exactly one instance of a class, shared across the system (e.g. configuration manager, logging, caching).
- You want controlled access to the instance.

## Command Pattern

**Intent**:
Encapsulate a request as an object, thereby letting you parameterize clients with different requests, 
queue or log requests, and support undoable operations.

**Real-world analogy**:
Think of a remote control. Each button on the remote is programmed to perform a specific action on a device (like turning on the TV, changing volume). 
The button doesn't care how the action is performed — it just "commands" the device.

**When to use it**:
- You want to parameterize objects with operations.
- You need to queue or schedule requests.
- You want to support undo/redo operations.
- You want to decouple the sender of a request from its receiver.


## Adapter Pattern

**Intent**:
Convert the interface of a class into another interface clients expect.
Adapter lets classes work together that couldn’t otherwise due to incompatible interfaces.

**Real-world analogy**:
Think of a power socket adapter.
You have a European plug, but you're in the US. You use an adapter so the plug fits the US socket — without changing the plug or the socket.

**When to use it**:
- You want to reuse existing classes, but their interfaces are incompatible with the rest of your code.
- You want to bridge between legacy code and new implementations.
- You’re working with third-party libraries that can’t be modified.

## Facade Pattern

**Intent**:
provides a unified interface to a set of interfaces in a subsystem. 
Facade defines a higherlevel interface that makes the subsystem easier to use.

**Real-world analogy**:
Think of a universal remote control.
Instead of manually controlling your TV, DVD player, and sound system separately, the remote offers a simplified interface to manage them all.

**When to use it**:
- You have a complex system with many subsystems and want to provide a simple entry point.
- You want to decouple clients from the internal complexity of a library or framework.
- You want to layer your subsystems and reduce coupling between layers.

## Proxy Pattern

**Intent**:
Provide a surrogate or placeholder for another object to control access to it.

**Real-world analogy**:
Think of a credit card as a proxy for a bank account. When you use your card, it doesn’t directly access your money. 
Instead, it acts as a middleman, checking permissions and then performing the transaction on your behalf.

**When to use it**:
- You want to add a layer of control over access to an object (e.g. lazy loading, access control, logging, etc.).
- You need to defer the creation and initialization of an expensive object until it's actually needed.
- You want to add functionality to existing classes without modifying their code (e.g. caching, logging).

## Bridge Pattern

**Intent**:
Decouple an abstraction from its implementation so that the two can vary independently.

**Real-world analogy**:
A TV remote and the TV. The remote is the abstraction, and the TV is the implementation. 
You can have different remotes for the same TV or different TVs for the same remote — they evolve independently.

**When to use it**:
- You want to avoid a class explosion from combining multiple dimensions of variation.
- You want to be able to change both abstraction and implementation independently.
- You want to follow the Open/Closed Principle — add new variants without modifying existing code.

## Template Method Pattern

**Intent**:
Define the skeleton of an algorithm in an operation, deferring some steps tosubclass es.Template Method lets subclass es redefine certain ste ps of an algorithm
without changing the algorithm's structure.

**Real-world analogy**:
Think of preparing coffee or tea:

1.Boil water
2.Brew coffee/tea
3.Pour into cup
4.Add condiments (sugar, milk, etc.)

The overall process is fixed, but the brewing and condiments steps differ depending on the beverage.

**When to use it**:
- You want to enforce a specific sequence of steps in an algorithm.
- You want subclasses to provide implementation for only some steps, not the whole algorithm.
- You want to promote code reuse by keeping common algorithm logic in a single place.

## Composite Pattern

**Intent**:
The Composite Pattern lets you treat individual objects and compositions of objects uniformly.
It’s used to represent part-whole hierarchies where a single object (leaf) or a collection of objects (composite) should be handled the same way.

**Real-world analogy**:
Imagine a company hierarchy:
- A Manager can have employees reporting to them (other managers or regular workers).
- An Employee might not have subordinates.
- You want to calculate total salary or print all employee names without caring whether it’s a manager or a worker — you call the same method!

This is what Composite makes easy:
- Leaf nodes = Simple elements (employees without subordinates).
- Composite nodes = Containers of other nodes (managers).

**When to use it**:
- You have hierarchical tree structures (files & folders, GUI widgets, org charts).
- You want to treat single objects and groups of objects in the same way.
- You want to avoid writing conditional logic like if (isLeaf) ... else ... everywhere.
- You want polymorphism to simplify client code.

## Iterator Pattern

**Intent**:
The Iterator Pattern provides a way to access the elements of an aggregate object sequentially without exposing its underlying representation.

**Real-world analogy**:
Imagine you have a remote control for your TV.

- The TV channels are like elements in a collection.
- The remote control’s channel buttons (next/previous) are like an iterator.
- You don’t need to know how the TV stores the channels internally; you just press next to go to the next channel or previous to go back.
- The Iterator Pattern hides the internal structure of the collection while letting you step through elements one at a time.

**When to use it**:
- When you want to decouple collection classes from traversal logic.
- When you need multiple ways to traverse a collection (forward, backward, etc.).
- When you need a uniform interface to iterate over different collections.

## State Pattern

**Intent**:
The State Pattern allows an object to alter its behavior when its internal state changes. The object will appear to change its class.

**Real-world analogy**:
Think of a vending machine.

- If it’s Out of Stock, pressing buttons won’t dispense anything.
- If it’s Waiting for Money, it won’t give items until you insert money.
- Once Money Inserted, it will let you pick your item.

The vending machine’s behavior changes depending on its state.

**When to use it**:
- When an object’s behavior depends on its state.
- To avoid massive if-else or switch statements for different states.
- To encapsulate logic for each state separately.

## Null Object Pattern

**Intent**:
Provide an object as a surrogate for the absence of a real object.
Instead of returning null and forcing client code to do null checks, we return a neutral "do-nothing" object that implements the same interface.

**Real-world analogy**:
Imagine you’re watching Netflix.

- When you log in, Netflix shows your personalized homepage.
- If you haven’t created a profile yet, instead of crashing or showing an error, Netflix shows a “Guest” profile.
- You can still browse content, but recommendations are generic, and some features might not work.

**When to use it**:
- When you have lots of conditional null checks scattered in your code.
- When you want to simplify client code and follow polymorphism principles.

## Builder Pattern

**Intent:**  
Separate the construction of a complex object from its representation so that the same construction process can create different representations.

**Real-World Analogy:**  
Think of building a house. The **architect (Director)** creates a standard plan.  
Different **contractors (Builders)** follow the same plan but build different types of houses  
(luxury villa vs. small house).  
The **house (Product)** is always built step by step—foundation, walls, roof.

**When to Use:**  
- When objects are complex with multiple optional parameters.  
- When you want to reuse the construction process for different representations.  
- When you want to hide the complexity of object creation from the client.
