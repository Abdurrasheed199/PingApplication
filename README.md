Clean Architecture Example with ASP.NET Core

This project demonstrates a basic implementation of clean architecture principles using ASP.NET Core.

The project is organized into the following layers:

Domain:
    * Contains core business rules, entities, and interfaces. This layer is independent of any framework or infrastructure.
    * Entities:Represents core business objects (e.g., Ping in this example).
    * Interfaces: Defines contracts for interacting with the domain (e.g., IPingUseCase).

Application:
    * Contains use cases that orchestrate the domain logic. 
    * Use Cases: Implement the interfaces defined in the domain layer and interact with the infrastructure layer
    
* *Infrastructure:*
    * Contains concrete implementations of infrastructure components, such as:
        * *Persistence:* Repositories for interacting with data sources (e.g., databases).

* *Controllers:*
    * ASP.NET Core controllers that handle incoming requests and interact with the application layer.


* Separation of Concerns: Each layer has a distinct responsibility, promoting maintainability and testability.
