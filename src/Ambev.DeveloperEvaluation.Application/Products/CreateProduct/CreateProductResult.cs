using Ambev.DeveloperEvaluation.Domain.ValueObjects;

namespace Ambev.DeveloperEvaluation.Application.Products.CreateProduct
{
    /// <summary>
    /// Represents the response returned after successfully creating a new product.
    /// </summary>
    /// <remarks>
    /// This response contains the unique identifier of the newly created product,
    /// which can be used for subsequent operations or reference.
    /// </remarks>
    public class CreateProductResult
    {
        /// <summary>
        /// Gets or sets the unique identifier of the newly created product.
        /// </summary>
        /// <value>A GUID that uniquely identifies the created product in the system.</value>
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

        /// <summary>
        /// Gets the product's category name.
        /// </summary>
        public string CategoryName { get; private set; } = default!;
    }
}
