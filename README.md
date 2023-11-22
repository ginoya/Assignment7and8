# Assignment7 - ASP.NET Core Dependency Injection Lifetimes

## Dependency Injection Lifetimes

### Scoped
- **Lifetime:** New instance per request.
- **When to Use:** Use when you need a new instance of the service for each HTTP request. Scoped services are shared within a single request and are disposed of at the end of the request.

### Transient
- **Lifetime:** New instance every time.
- **When to Use:** Use when you need a new instance of the service every time it's requested. Transient services are created each time they are requested and are not shared.

### Singleton
- **Lifetime:** A single instance for the entire application.
- **When to Use:** Use when you want a single instance of the service shared across the entire application. Singleton services are created the first time they are requested and reused for the duration of the application.
