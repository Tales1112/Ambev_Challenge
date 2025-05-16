namespace Ambev.DeveloperEvaluation.WebApi.Features.Products.UpdateProduct
{
    /// <summary>
    /// Represents a request to create a new product in the system.
    /// </summary>
    public class UpdateProductRequest
    {
        /// <summary>
        /// The unique identifier of the product to update.
        /// </summary>
        public Guid Id { get; set; }

        /// <summary>
        /// Gets or sets the name. Must be unique and contain only valid characters.
        /// </summary>
        public string Name { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the price
        /// </summary>
        public decimal Price { get; set; }
    }
}
