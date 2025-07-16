🧩 Apex.Core
Apex.Core is the foundational shared library for the ApexHR Microservices System. It encapsulates reusable, cross-cutting concerns such as domain primitives, exceptions, MediatR behaviors, repository abstractions, and middleware used across all services.

📦 Layers & Contents
Domain

Custom exceptions

Value objects and base entities

Shared domain logic

Application

CQRS abstractions (ICommand, IQuery, IHandler<T>)

MediatR pipeline behaviors (validation, logging, etc.)

Infrastructure

Generic repository pattern

Unit of work abstraction

Presentation

Global exception handler middleware (optional reuse across services)

Generate the NuGet .nupkg file:
dotnet pack -c Release

🎯 Purpose
Apex.Core enforces Clean Architecture principles and ensures all ApexHR services (Security, Auth, Workflow, Attendance) remain consistent, loosely coupled, and easy to maintain by centralizing shared logic in one place.
