using Ambev.DeveloperEvaluation.Domain.Entities;

namespace Ambev.DeveloperEvaluation.Domain.Repositories
{
    /// <summary>
    /// Repository interface for <see cref="Category"/> entity operations.
    /// </summary>
    public interface ICategoryRepository
    {
        /// <summary>
        /// Creates a new category in the repository.
        /// </summary>
        /// <param name="category">The category to create</param>
        void Create(Category category);

        /// <summary>
        /// Retrieves a category by their name.
        /// </summary>
        /// <param name="name">The name to search for</param>
        /// <param name="cancellationToken">Cancellation token</param>
        /// <returns>The category if found, null otherwise</returns>
        Task<Category?> GetByNameAsync(string name, CancellationToken cancellationToken = default);
    }
}
