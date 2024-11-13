# Architecture

Application was built using a Layered(3-tier) Monolithic Architecture.

## The Layered (3-tier) Architecture

Layered Architecture is a software design that separates an application into 3 distinct layers each responsible for specific tasks.

This structure helps to organize code, improve maintainability and make it easier to scale or test individual parts.

Inside this layer,

**•** All database interactions like querying, saving, updating, and deleting will be handled by the Data-access layer (Repositories),

**•**  All core logic like Validation, deciding how to process requests, and calculations in the application will be handled by the Service layer (Business Logic),

**•**  All user inputs such as HTTP requests from a web browser or API client will be handled by the Presentation Layer (Controllers). And thus enforcing separation of concern.

## Why a Monolithic Architecture was used?

J-SHOES Store Inc. only owns a small to medium sized retail store, simplicity should be a key factor and the Monolithic approach should be sufficient for the business needs. Also, having a Monolithic architecture means all server logic would be in one codebase, and since Client has less than 50,000 Customers it’s a good idea to stick with this Monolithic approach.