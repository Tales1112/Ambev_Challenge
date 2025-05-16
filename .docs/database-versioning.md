[Back to README](../README.md)

# Database Versioning with Entity Framework

Entity Framework (EF) provides a robust mechanism for database versioning, ensuring that your database schema stays consistent with your application models. Here's how to manage database versioning using EF.

## 1. Understanding Migrations
Migrations in EF allow you to incrementally update the database schema to keep it in sync with the application's data models.

### Key Concepts:
- **Add Migration:** Creates a migration script based on model changes.
- **Update Database:** Applies pending migrations to the database.
- **Remove Migration:** Reverts the last migration if it hasn't been applied.

## 2. Setting Up Migrations
To start using migrations, ensure EF Core is installed in your project.

```bash
dotnet add package Microsoft.EntityFrameworkCore.Design
```

Then, enable migrations by running:

```bash
dotnet ef migrations add InitialCreate --project Ambev.DeveloperEvaluation.ORM --startup-project Ambev.DeveloperEvaluation.WebApi
```

This creates a migration file that represents the initial state of the database.

Execute all commands in `src` folder.

## 3. Applying Migrations
To apply the latest migrations to your database, run:

```bash
dotnet ef database update --project Ambev.DeveloperEvaluation.ORM --startup-project Ambev.DeveloperEvaluation.WebApi
```

This command updates the database to the latest migration state.

## 4. Managing Migrations
- **Add New Migration:**

```bash
dotnet ef migrations add <migration_name> --project Ambev.DeveloperEvaluation.ORM --startup-project Ambev.DeveloperEvaluation.WebApi
```

- **Remove Last Migration (if not applied):**

```bash
dotnet ef migrations remove --project Ambev.DeveloperEvaluation.ORM --startup-project Ambev.DeveloperEvaluation.WebApi
```

- **List Available Migrations:**

```bash
dotnet ef migrations list --project Ambev.DeveloperEvaluation.ORM --startup-project Ambev.DeveloperEvaluation.WebApi
```

## 5. Best Practices
- **Commit Migrations:** Always commit your migration files to version control.
- **Test Migrations:** Test migrations in a development or staging environment before applying them in production.
- **Keep Migrations Clean:** Regularly review and clean up unnecessary or redundant migrations.
- **Backup Data:** Always backup your database before applying migrations, especially in production environments.

## 6. Handling Production Databases
When deploying migrations to production, ensure:
- Database backups are in place.
- Downtime is minimized by scheduling updates during off-peak hours.
- Comprehensive testing has been conducted to avoid unexpected failures.

## 7. Troubleshooting Common Issues
- **Migration Conflicts:** If multiple developers add migrations simultaneously, resolve conflicts by reapplying migrations.
- **Model Mismatches:** Ensure models are correctly updated to reflect database changes.
- **Missing Migrations:** Use `dotnet ef migrations list` to verify available migrations.

## Conclusion
Entity Framework's migration system simplifies database versioning by automating schema changes and maintaining consistency. By following best practices and leveraging EF's commands, you can ensure a stable and versioned database throughout the development lifecycle.

For more detailed information, refer to the [official EF Core documentation](https://docs.microsoft.com/en-us/ef/core/).

