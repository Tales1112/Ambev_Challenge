using Ambev.DeveloperEvaluation.Domain.ValueObjects;

namespace Ambev.DeveloperEvaluation.Application.Products.UpdateProduct
{
    /// <summary>
    /// Represents the response returned after successfully updating a new product.
    /// </summary>
    /// <remarks>
    /// This response contains the unique identifier of the newly updated product,
    /// which can be used for subsequent operations or reference.
    /// </remarks>
    public class UpdateProductResult
    {
        /// <summary>
        /// Gets or sets the unique identifier of the newly updated product.
        /// </summary>
        /// <value>A GUID that uniquely identifies the updated product in the system.</value>
        public Guid Id { get; set; }

        /// <summary>
        /// Gets the product's title.
        /// </summary>
        public string Title { get; set; } = default!;

        /// <summary>
        /// Gets the product's full price.
        /// </summary>
        public decimal Price { get; set; }

        /// <summary>
        /// Gets the product's description.
        /// </summary>
        public string Description { get; set; } = default!;

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
