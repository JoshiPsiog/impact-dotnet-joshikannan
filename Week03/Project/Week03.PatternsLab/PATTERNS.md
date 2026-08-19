# Week 3 Patterns

## Singleton
One object throughout the application.
Used later for logging and configuration.

## Factory
Creates objects without exposing creation logic.
Used later in service creation.

## Factory Method
Each product has its own factory.
Used when object creation becomes complex.

## Observer
One-to-many notification.
Used in events and messaging.

## Strategy
Switch algorithms at runtime.
Used for payment methods, authentication and export.

## Repository
Separates data access from business logic.
Used in Entity Framework repositories.

## Unit Of Work
Coordinates multiple repositories with one Save().
Used with EF Core SaveChanges().

## Adapter
Converts one interface into another.
Used for third-party integrations.

## Facade
Provides one simple interface over multiple subsystems.
Used in order processing and APIs.

## Builder
Constructs complex objects step by step.

## Prototype
Creates objects by cloning.

## Decorator
Adds behavior without modifying the original object.

## Command
Encapsulates a request.

## Template Method
Defines the skeleton of an algorithm.

## Mediator
Objects communicate through a mediator.

## Chain of Responsibility
Passes a request through handlers.

## State
Changes behavior based on current state.