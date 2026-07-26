# Week 3 — Exceptions, Async, Design Patterns & SOLID

**Name:** Joshikannan  
**Employee ID:** P574
**Cohort:** Impact .NET Bridge Course  
**Week:** Week 3 — Exceptions, Async, Design Patterns & SOLID

---

# Section A — Learnings

## Module 6 – Exceptions, Async/Await & IDisposable

This module helped me understand how to build reliable and maintainable applications by handling runtime errors effectively. I learned how to create custom exceptions, throw and catch exceptions in the correct order, and use the `finally` block to execute cleanup code regardless of success or failure.

I also learned asynchronous programming using `async` and `await`. By using `Task.Delay()` and `Task.WhenAll()`, I understood the difference between sequential and concurrent execution and how asynchronous programming improves application performance for I/O-bound operations.

Another important concept was resource management using the `IDisposable` interface. I implemented the Dispose pattern using `using`, created a finalizer, and used `GC.SuppressFinalize()` to avoid unnecessary garbage collection work.

---

## Module 7 – Design Patterns

This module introduced several commonly used software design patterns.

I implemented the Singleton pattern using `Lazy<T>` to ensure only one object is created in a thread-safe manner.

I learned both Factory and Factory Method patterns to create objects without exposing object creation logic to the client.

I implemented the Observer pattern using both a custom observer interface and C# events to notify multiple subscribers automatically.

The Strategy pattern helped me understand how application behavior can be changed at runtime without modifying existing code.

Repository and Unit of Work demonstrated how data access can be separated from business logic and coordinated through a single Save() operation.

Finally, I implemented Adapter and Facade patterns to simplify integration between different components and provide a single interface to complex subsystems.

---

## Module 8 – TPL, Reflection & Attributes

This module introduced advanced .NET features.

I compared Thread, Task.Run and Parallel.ForEach to understand different approaches for executing concurrent work.

Using Reflection, I inspected class metadata such as constructors, properties and methods at runtime, created objects dynamically using `Activator.CreateInstance()`, and modified properties through `PropertyInfo`.

I also created a custom attribute and used reflection to validate object properties based on metadata.

---

## Module 9 – Interface vs Abstract, Static vs Instance

I learned when to use interfaces and abstract classes.

Interfaces define contracts without implementation, while abstract classes can contain both implementation and shared state.

I also understood the difference between static and instance members. Static methods are suitable for utility functionality such as mathematical operations, whereas instance methods operate on object-specific data.

---

## Module 11 – IComparable & IComparer

This module focused on sorting collections.

I implemented `IComparable<T>` to define the default sorting behavior based on employee salary.

I implemented `IComparer<T>` to create custom sorting logic based on employee name without modifying the original class.

This demonstrated how C# supports flexible and reusable sorting mechanisms.

---

# Section B — Doables

## Task 3.1 – Custom Exception

Implemented `InsufficientFundsException` with `DeficitAmount` property. Demonstrated withdrawal using `try`, `catch`, and `finally`, and implemented correct exception catch ordering.

**✓ Done:** Custom exception thrown successfully and catch order demonstrated.

---

## Task 3.2 – IDisposable

Implemented `TempFileManager` using the Dispose pattern. Created a temporary file in the constructor and deleted it in `Dispose()`. Used `using`, finalizer and `GC.SuppressFinalize()`.

**✓ Done:** File existed inside the `using` block and was deleted afterwards.

---

## Task 3.3 – Async Programming

Implemented asynchronous user data retrieval using `Task.Delay()` and compared sequential execution with `Task.WhenAll()`.

**✓ Done:** Concurrent execution completed significantly faster than sequential execution.

---

## Task 3.4 – Singleton Pattern

Implemented a thread-safe Logger Singleton using `Lazy<T>`. Accessed the logger from multiple Threads and Tasks.

**✓ Done:** Every execution produced the same instance hash code.

---

## Task 3.5 – Factory Pattern

Implemented `IVehicle`, `Car`, `Bike`, `Truck`, `VehicleFactory`, and Factory Method classes.

**✓ Done:** Objects were created through factories without directly using `new`.

---

## Task 3.6 – Observer Pattern

Implemented Observer using both a custom observer interface and C# events.

**✓ Done:** All investors received notifications when stock prices changed.

---

## Task 3.7 – Strategy Pattern

Implemented runtime payment switching using Credit Card, UPI and Net Banking strategies.

**✓ Done:** Payment behavior changed without modifying ShoppingCart.

---

## Task 3.8 – Repository & Unit of Work

Implemented generic `IRepository<T>`, StudentRepository, CourseRepository and UnitOfWork.

**✓ Done:** Both repositories compiled successfully and Save() coordinated repository operations.

---

## Task 3.9 – Adapter & Facade

Implemented `XmlReportAdapter` and `OrderFacade` coordinating Inventory, Payment and Shipping services.

Also documented Builder, Prototype, Decorator, Command, Template Method, Mediator, Chain of Responsibility and State patterns.

**✓ Done:** Single facade call completed the complete order workflow.

---

## Task 3.10 – Task Parallel Library

Compared Thread, Task.Run and Parallel.ForEach for simulated workloads.

**✓ Done:** Parallel execution performed significantly faster than sequential execution.

---

## Task 3.11 – Reflection

Used reflection to inspect an Invoice class, constructors, methods and properties. Dynamically created objects and modified properties.

**✓ Done:** Object creation and property assignment were completed entirely using reflection.

---

## Task 3.12 – Custom Attribute

Created `MaxLengthNoAttribute` and validated string properties using reflection.

**✓ Done:** Validation warning displayed when the maximum length was exceeded.

---

## Task 3.13 – Interface vs Abstract

Compared interface and abstract class usage and demonstrated static and instance methods using MathHelper and OrderProcessor.

**✓ Done:** Successfully demonstrated both concepts with working examples.

---

## Task 3.14 – IComparable & IComparer

Implemented employee sorting by salary using `IComparable<Employee>` and by name using `IComparer<Employee>`.

**✓ Done:** Default sorting used salary while custom sorting used employee name.

---

## Task 3.15 – PATTERNS.md

Created PATTERNS.md documenting every implemented pattern and where it will be used in future weeks.

**✓ Done:** Repository, Strategy, Observer and Factory were mapped to their future applications.

---

# Evidence

- Completed **Patterns Lab** project containing all Week 3 tasks.
- Created **PATTERNS.md** documenting all design patterns and their future usage.
- Captured screenshots for all task executions.
- Successfully demonstrated:
  - Custom Exceptions
  - Dispose Pattern
  - Async Programming
  - Singleton
  - Factory
  - Observer
  - Strategy
  - Repository & Unit of Work
  - Adapter
  - Facade
  - Reflection
  - Custom Attributes
  - Sorting using IComparable and IComparer

---

# Git Submission

**Repository:**

```
https://github.com/<your-github-username>/impact-dotnet-joshikannan
```

**Branch:**

```
feature/week03-update
```

**Pull Request:**

```
<Add PR URL after creating the PR>
```

---

# Assignments

Completed all Week 3 coding assignments:

- Task 3.1 – Exceptions
- Task 3.2 – IDisposable
- Task 3.3 – Async Programming
- Task 3.4 – Singleton
- Task 3.5 – Factory
- Task 3.6 – Observer
- Task 3.7 – Strategy
- Task 3.8 – Repository & Unit of Work
- Task 3.9 – Adapter & Facade
- Task 3.10 – Task Parallel Library
- Task 3.11 – Reflection
- Task 3.12 – Custom Attribute
- Task 3.13 – Interface vs Abstract
- Task 3.14 – IComparable & IComparer
- Task 3.15 – PATTERNS.md

---

# Lessons Learnt

By the end of Week 3, I can:

- Create and handle custom exceptions effectively.
- Implement the full Dispose pattern for resource cleanup.
- Improve application performance using async/await and Task.WhenAll().
- Apply Singleton, Factory, Factory Method, Observer and Strategy design patterns.
- Build Repository and Unit of Work abstractions for data access.
- Use Adapter and Facade to simplify complex interactions.
- Inspect and manipulate types at runtime using Reflection.
- Create and validate custom Attributes.
- Choose appropriately between Interface and Abstract Class.
- Understand when to use Static and Instance members.
- Sort collections using IComparable and IComparer.
- Relate design patterns to their usage in future ASP.NET Core and enterprise applications.
