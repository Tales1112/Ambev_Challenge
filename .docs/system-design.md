# System Design

This document outlines the high-level design of the `abi-gth-omnia-developer-evaluation` project, a CRUD API for managing sales, built with DDD, CQRS, .NET 8, and PostgreSQL.

## Overview
The system is a RESTful API that manages sale records, applying specific business rules (e.g., quantity-based discounts) and supporting events for operations like sale creation, modification, and cancellation. It uses a Domain-Driven Design (DDD) architecture with Command Query Responsibility Segregation (CQRS).

## Main Components
1. **API Layer**: 
   - RESTful endpoints for CRUD operations on sales.
   - Technologies: ASP.NET Core 8, controllers.
2. **Application Layer**: 
   - Orchestrates commands (write) and queries (read).
   - Implements CQRS, likely with MediatR (suggested for .NET 8).
3. **Domain Layer**: 
   - Contains entities (e.g., `Sale`, `SaleItem`) and business logic (e.g., discount rules).
   - Uses the `External Identities` pattern for referencing external entities.
4. **Infrastructure Layer**: 
   - Persistence with PostgreSQL via Entity Framework Core.
   - Logging for event tracking (e.g., `SaleCreated`).
5. **Event System**: 
   - Generates events like `SaleCreated`, `SaleModified`, etc., logged locally (no Message Broker).

## Data Flow
1. **Sale Creation**:
   - POST request hits the `/sales` endpoint.
   - `CreateSaleCommand` is dispatched.
   - `Sale` entity validates business rules (e.g., max 20 items).
   - Persisted in PostgreSQL.
   - `SaleCreated` event is logged.
2. **Sale Retrieval**:
   - GET request to `/sales/{id}`.
   - `GetSaleQuery` returns denormalized data.
3. **Sale Cancellation**:
   - PATCH request to `/sales/{id}/cancel`.
   - `CancelSaleCommand` updates status and logs `SaleCancelled`.

## Scalability
- **CQRS**: Enables separate scaling of read and write operations.
- **Events**: Facilitates future integration with Message Brokers (e.g., RabbitMQ).
- **Denormalization**: Optimizes queries with `External Identities`.

## Limitations
- No Message Broker implemented (events only logged).
- Single database (PostgreSQL) for both reads and writes, no physical separation.