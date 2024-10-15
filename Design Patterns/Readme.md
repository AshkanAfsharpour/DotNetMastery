# Design Patterns To-Do List

## 1. **Creational Design Patterns**

- [ ] **Singleton**
  - [ ] Ensure a class has only one instance.
  - [ ] Thread-safe Singleton.
  - [ ] Lazy initialization.
  - [ ] Double-checked locking.
  
- [ ] **Factory Method**
  - [ ] Define an interface for creating an object.
  - [ ] Subclasses decide which class to instantiate.
  
- [ ] **Abstract Factory**
  - [ ] Provide an interface for creating families of related or dependent objects without specifying their concrete classes.
  
- [ ] **Builder**
  - [ ] Separate the construction of a complex object from its representation.
  - [ ] Fluent Builder pattern.
  
- [ ] **Prototype**
  - [ ] Specify the kinds of objects to create using a prototypical instance.
  - [ ] Implement cloning.
  
- [ ] **Object Pool**
  - [ ] Manage a pool of reusable objects.
  - [ ] Object Pooling for resource management.

---

## 2. **Structural Design Patterns**

- [ ] **Adapter**
  - [ ] Convert the interface of a class into another interface clients expect.
  - [ ] Class Adapter (using inheritance).
  - [ ] Object Adapter (using composition).
  
- [ ] **Bridge**
  - [ ] Separate an abstraction from its implementation so the two can vary independently.
  
- [ ] **Composite**
  - [ ] Compose objects into tree structures to represent part-whole hierarchies.
  - [ ] Treat individual objects and compositions uniformly.

- [ ] **Decorator**
  - [ ] Attach additional responsibilities to an object dynamically.
  - [ ] Flexible alternative to subclassing for extending functionality.
  
- [ ] **Facade**
  - [ ] Provide a unified interface to a set of interfaces in a subsystem.
  - [ ] Simplify interaction with complex systems.
  
- [ ] **Flyweight**
  - [ ] Use sharing to support large numbers of fine-grained objects efficiently.
  
- [ ] **Proxy**
  - [ ] Provide a surrogate or placeholder for another object to control access.
  - [ ] Virtual Proxy.
  - [ ] Remote Proxy.
  - [ ] Protection Proxy.

---

## 3. **Behavioral Design Patterns**

- [ ] **Chain of Responsibility**
  - [ ] Avoid coupling the sender of a request to its receiver by giving more than one object a chance to handle the request.
  - [ ] Pass the request along a chain of potential handlers.

- [ ] **Command**
  - [ ] Encapsulate a request as an object.
  - [ ] Parameterize clients with queues, requests, and operations.

- [ ] **Interpreter**
  - [ ] Define a representation for a language's grammar.
  - [ ] Interpret sentences in the language.

- [ ] **Iterator**
  - [ ] Provide a way to access elements of a collection sequentially without exposing the underlying representation.
  - [ ] Implement custom iterators.

- [ ] **Mediator**
  - [ ] Define an object that encapsulates how a set of objects interact.
  - [ ] Promote loose coupling by keeping objects from referring to each other explicitly.

- [ ] **Memento**
  - [ ] Capture and externalize an object's internal state.
  - [ ] Restore the object to this state without violating encapsulation.

- [ ] **Observer**
  - [ ] Define a one-to-many dependency between objects.
  - [ ] Notify all dependents when one object changes its state.
  - [ ] Event-driven architecture.
  
- [ ] **State**
  - [ ] Allow an object to alter its behavior when its internal state changes.
  - [ ] The object will appear to change its class.

- [ ] **Strategy**
  - [ ] Define a family of algorithms.
  - [ ] Encapsulate each one and make them interchangeable.
  
- [ ] **Template Method**
  - [ ] Define the skeleton of an algorithm in a method.
  - [ ] Allow subclasses to redefine certain steps of the algorithm without changing its structure.

- [ ] **Visitor**
  - [ ] Represent an operation to be performed on elements of an object structure.
  - [ ] Define new operations without changing the classes of the elements on which it operates.

---

## 4. **Concurrency Design Patterns**

- [ ] **Thread Pool**
  - [ ] Manage a pool of reusable threads.
  
- [ ] **Active Object**
  - [ ] Decouple method execution from method invocation for objects that each reside in their own thread of control.

- [ ] **Monitor Object**
  - [ ] Ensure that only one method at a time can execute on an object.
  
- [ ] **Producer-Consumer**
  - [ ] Manage synchronized communication between producers and consumers.

- [ ] **Reactor**
  - [ ] Handle service requests delivered concurrently to an application by one or more inputs.

- [ ] **Future/Promise**
  - [ ] Handle asynchronous results.
  
---

## 5. **Miscellaneous Patterns**

- [ ] **Dependency Injection (DI)**
  - [ ] Invert the control of creating and injecting dependencies.
  
- [ ] **Service Locator**
  - [ ] Centralized registry that provides dependencies.
  
- [ ] **Null Object**
  - [ ] Provide a default behavior in the absence of an object.

- [ ] **Object Mother**
  - [ ] Create sample objects for tests.