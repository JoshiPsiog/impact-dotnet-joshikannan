# Week 4 — Console Application Development Using the MVC Pattern

**Name:** Joshikannan  
**Employee ID:** P574  
**Cohort:** Impact .NET Bridge Course  
**Week:** Week 4 — Console Application Development Using the MVC Pattern

---

# Section A — Learnings

## Module 10 – MVC, Layered Architecture & Separation of Concerns

This module helped me understand how to structure an application by separating responsibilities into different layers. I learned how Model, View, Controller, Service and Repository layers work together while keeping each layer focused on a specific responsibility.

The **Model** represents application data and contains basic property validation. The **View** is responsible only for console input, output and presentation. The **Controller** handles application flow and coordinates between the View and Service. The **Service** contains the application's business rules, while the **Repository** handles data storage.

I also learned why the View should not contain business logic. Keeping business rules inside the Service makes the application easier to test, maintain and reuse.

---

## In-Memory Repository

I learned how to implement CRUD operations without using a database by storing entities in an in-memory `List<T>`.

I created a generic `IRepository<T>` interface containing:

- `Add`
- `GetAll`
- `GetById`
- `Update`
- `Delete`

and implemented it using `InMemoryRepository<T>`.

This helped me understand how the Repository abstraction separates storage from the rest of the application and allows the storage implementation to be replaced without changing the Service or Controller.

---

## Service Layer & Business Rules

I learned that the Service layer is the primary location for application business rules.

For the Student Management application, I implemented rules such as:

- Name cannot be empty.
- Age must be between 5 and 100.
- Roll numbers cannot be duplicated.
- Updating a missing student should fail cleanly.
- Deleting a missing student should fail cleanly.

I also used clear success/failure signals such as `bool` for mutation operations.

---

## Dependency Injection

I learned how dependencies can first be created manually and then managed using Microsoft's Dependency Injection container.

Initially, dependencies were wired manually:

```text
Repository → Service → Controller
```

I then replaced manual wiring with:

```text
ServiceCollection
        ↓
BuildServiceProvider()
        ↓
GetRequiredService()
```

I also learned about service lifetimes and used **Singleton** for the console application's in-memory repository so that the same repository instance remains available throughout the application execution.

---

## Transaction Logging

I implemented a transaction log inside the Service layer to record successful mutating operations.

The log records:

- `ADD`
- `UPDATE`
- `DELETE`

in execution order.

This helped me understand encapsulation because the transaction history is maintained internally by the Service and exposed through a controlled method.

---

## xUnit & Moq Testing

I learned how to unit-test the Service layer independently from the actual repository implementation.

Using **xUnit**, I created tests for:

- Valid student addition
- Duplicate roll number rejection
- Empty name rejection
- Invalid age validation
- Missing student update
- Missing student deletion
- Transaction log recording

I also introduced **Moq** to create a mock `IRepository<Student>`.

This demonstrated how dependencies can be mocked so that the Service can be tested independently.

---

# Section B — Doables

## Task 4.1 – Models & Data

Implemented `Student` with:

- `Id`
- `Name`
- `Age`
- `RollNumber`
- `Email`

and `Teacher` with:

- `Id`
- `Name`
- `Email`
- `Designation`

Added Student age validation so that values outside the range of **5–100** are rejected.

**✓ Done:** Invalid age was rejected successfully, and the models contain no console or list-management code.

---

## Task 4.2 – In-Memory Repository

Implemented:

```text
IRepository<T>
InMemoryRepository<T>
```

with the five CRUD operations:

- `Add`
- `GetAll`
- `GetById`
- `Update`
- `Delete`

Seeded three students and verified all repository operations.

**✓ Done:** All five repository operations worked successfully using the in-memory `List<T>` store.

---

## Task 4.3 – Student Service

Implemented:

```text
IStudentService
StudentService
```

with:

- `AddStudent`
- `GetAll`
- `GetById`
- `UpdateStudent`
- `DeleteStudent`

Added business rules for:

- Duplicate roll numbers
- Invalid age
- Empty student name

**✓ Done:** Duplicate roll numbers were rejected by the Service layer.

---

## Task 4.4 – Success / Failure Signals

Used `bool` as the success/failure signal for mutation operations.

```text
true  → operation succeeded
false → operation failed
```

Used nullable and collection return types for retrieval operations.

**✓ Done:** A caller can clearly distinguish successful and failed operations.

---

## Task 4.5 – Student View

Implemented `StudentView` with:

- `ShowMenu()`
- `PrintStudents(...)`
- `PromptForStudent()`
- `PromptForId()`
- `ShowMessage(...)`
- `PrintTransactionLog(...)`

Created clean console table formatting for displaying students.

**✓ Done:** The View contains presentation logic only and does not contain business rules.

---

## Task 4.6 – Student Controller

Implemented `StudentController` to manage the application menu loop.

The Controller:

```text
Reads menu choice
      ↓
Calls Service
      ↓
Passes result to View
```

It does not directly access the repository or format console tables.

**✓ Done:** Controller orchestration was separated from business logic and presentation.

---

## Task 4.7 – Manual Dependency Injection

Implemented manual dependency wiring in `Program.cs`.

The application was initially constructed using:

```text
Repository
    ↓
Service
    ↓
Controller
```

A second repository implementation was also created to demonstrate that the repository can be swapped without changing the Service or Controller.

**✓ Done:** Changing the repository implementation required changing only the repository wiring.

---

## Task 4.8 – Microsoft DI Container

Refactored the application to use:

```text
Microsoft.Extensions.DependencyInjection
```

Registered:

- `IRepository<Student>`
- `IStudentService`
- `StudentController`
- `StudentView`

and resolved the Controller using:

```csharp
BuildServiceProvider()
GetRequiredService<StudentController>()
```

Used Singleton lifetime for the in-memory application dependencies.

**✓ Done:** The container-resolved application behaved identically to the manually wired application.

---

## Task 4.9 – Transaction Log

Added a private transaction history to `StudentService`.

Successful operations are recorded in order:

```text
ADD
UPDATE
DELETE
```

Added a menu option to display the transaction history.

**✓ Done:** The transaction log displayed every successful mutating operation in the correct order.

---

## Task 4.10 – Teacher End-to-End Slice

Implemented the Teacher functionality across the complete architecture:

```text
Teacher Model
    ↓
Teacher Repository
    ↓
Teacher Service
    ↓
Teacher View
    ↓
Teacher Controller
```

Added Teacher CRUD operations and registered the Teacher dependencies through the Microsoft DI container.

**✓ Done:** Both Student and Teacher functionality were available through the same DI-wired console application.

---

# Section C — Testing

Created a separate xUnit test project:

```text
Week04_MVC_Pattern.Tests
```

Introduced Moq for repository mocking.

### Service Tests

Implemented tests for:

- Valid student add succeeds
- Duplicate roll number is rejected
- Empty name is rejected
- Invalid age is rejected
- Update of missing ID fails cleanly
- Delete of missing ID fails cleanly
- Transaction log records mutations

The repository was mocked using:

```csharp
Mock<IRepository<Student>>
```

### Test Execution

```bash
dotnet test
```

**✓ Done:** Service tests executed successfully with all implemented tests passing.

---

# Evidence

- Completed **Student Management Console Application** using MVC and layered architecture.
- Implemented Student and Teacher models.
- Implemented generic in-memory repository.
- Implemented Student and Teacher service layers.
- Implemented console Views and Controllers.
- Implemented manual Dependency Injection.
- Refactored the application to Microsoft DI.
- Implemented transaction logging.
- Created xUnit Service tests.
- Introduced Moq for repository mocking.
- Captured screenshots for application execution and testing.

Successfully demonstrated:

- Model validation
- Repository CRUD
- Service business rules
- MVC separation
- Manual DI
- Microsoft DI container
- Transaction logging
- Student CRUD
- Teacher CRUD
- xUnit testing
- Moq repository mocking

---

# Required Reflection

## Why does the View not contain business logic?

The View should not contain business logic because its responsibility is to interact with the user and present information. Business rules belong in the Service layer so that they are independent of the user interface and can be tested separately.

In my application, the View only collects input and displays results. The Service validates and processes the business rules, while the Controller coordinates the flow between the View and Service. This separation makes the application easier to maintain, test and extend.

---

# Layer Responsibility README Excerpt

```text
Model      – Represents application data and basic validation.
View       – Handles console input, output and presentation.
Controller – Orchestrates application flow between View and Service.
Service    – Contains business rules and application operations.
Repository – Handles data storage behind an abstraction.
```

---

# Git Submission

**Repository:**

```text
https://github.com/<your-github-username>/impact-dotnet-joshikannan
```

**Branch:**

```text
feature/week04-mvc-console
```

**Pull Request:**

```text
<Add PR URL after creating the PR>
```

---

# Assignments

Completed all Week 4 coding assignments:

- Task 4.1 – Models & Data
- Task 4.2 – In-Memory Repository
- Task 4.3 – Student Service
- Task 4.4 – Success / Failure Signals
- Task 4.5 – Student View
- Task 4.6 – Student Controller
- Task 4.7 – Manual Dependency Injection
- Task 4.8 – Microsoft DI Container
- Task 4.9 – Transaction Log
- Task 4.10 – Teacher End-to-End Slice
- xUnit + Moq Service Tests
- Layer Responsibility README

---

# Lessons Learnt

By the end of Week 4, I can:

- Structure a console application using Model, View, Controller, Service and Repository layers.
- Keep business logic inside the Service layer.
- Keep rendering and user interaction inside the View.
- Use Controllers only for application orchestration.
- Implement full CRUD using an in-memory `List<T>` repository.
- Hide data storage behind repository interfaces.
- Validate business rules in the Service layer.
- Use clear success and failure signals.
- Implement manual Dependency Injection.
- Use Microsoft's Dependency Injection container.
- Understand and select appropriate DI service lifetimes.
- Implement transaction logging using encapsulation.
- Build a complete feature across multiple application layers.
- Unit-test business logic using xUnit.
- Mock repository dependencies using Moq.
- Understand why the View should not contain business logic.
- Understand why the Controller should not directly access storage.
- Apply separation of concerns before moving to ASP.NET Core web development.

**Shipped:** The layered Student Management Console Application with Student and Teacher CRUD, in-memory Repository, Service-layer business rules, MVC separation, Microsoft DI, transaction logging, and xUnit/Moq service tests.
