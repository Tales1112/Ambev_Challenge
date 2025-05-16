using Ambev.DeveloperEvaluation.Domain.ValueObjects;

namespace Ambev.DeveloperEvaluation.Application.Products.GetProduct
{
    /// <summary>
    /// Response model for GetProduct operation.
    /// </summary>
    public class GetProductResult
    {
        /// <summary>
        /// The unique identifier of the product.
        /// </summary>
        public Guid Id { get; set; }

        public string Title { get; set; } = default!;

        /// <summary>
        /// Gets the product's description.
        /// </summary>
        public string Description { get; set; } = default!;

        /// <summary>
        /// The product's price.
        /// </summary>
        public decimal Price { get; set; }

        /// <summary>
        /// Gets the product's cover image.
        /// </summary>
        public string Image { get; set; } = default!;

        /// <summary>
        /// Gets the product's rating.
        /// </summary>
        public Rating Rating { get; set; } = default!;
    }
}