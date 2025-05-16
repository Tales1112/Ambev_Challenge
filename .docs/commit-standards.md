# Commit Standards

This document defines a recommended commit convention for the `abi-gth-omnia-developer-evaluation` project, aligned with industry best practices and the needs of a DDD, CQRS, and .NET 8-based project.

## Convention

We adopt an approach inspired by Karma **Conventional Commits** to ensure clarity, traceability, and automation (e.g., changelog generation).

### General Format
```
<type>: <short description>
```

### Commit Types
- **feat**: New feature (e.g., "feat(api): add sale creation endpoint").
- **fix**: Bug fix (e.g., "fix(domain): fix discount calculation for 10 items").
- **docs**: Documentation changes (e.g., "docs(readme): update execution instructions").
- **test**: Add or modify tests (e.g., "test(unit): add tests for discount rules").
- **refactor**: Code refactoring without behavior changes (e.g., "refactor(application): rename variables in SaleService").
- **chore**: Maintenance tasks (e.g., "chore(deps): update xUnit version").
- **style**: Formatting or style changes (e.g., "style(api): adjust controller indentation").


### Examples

feat: implement domain quantity-based discount rules
Adds logic to apply 10% discount for purchases over 4 items and 20% for 10-20 items.

fix: fix sale total calculation
Resolves bug where total did not correctly account for applied discounts.

docs: add PostgreSQL setup instructions

## Best Practices
1. **Short and Clear Messages**: The short description line should be up to 50 characters.
2. **Context in Long Description**: Explain the "why" of the change if needed.
3. **Atomic Commits**: Each commit should represent a single logical change.
4. **References**: Use issue or task IDs when applicable (e.g., "fix: resolve bug #123").

## Suggested Tools
- **Commitizen**: To standardize commits via CLI.
- **Husky**: To validate commits before pushing to the repository.