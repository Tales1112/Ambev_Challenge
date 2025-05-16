namespace Ambev.DeveloperEvaluation.Application.Products.ListProduct
{
    /// <summary>
    /// Response model for ListProduct operation.
    /// </summary>
    public class ProductResult
    {
        /// <summary>
        /// The unique identifier of the product.
        /// </summary>
        public Guid Id { get; set; }

        /// <summary>
        /// The product's name.
        /// </summary>
        public string Name { get; set; } = string.Empty;

        /// <summary>
        /// The product's price.
        /// </summary>
        public decimal Price { get; set; }
    }
}
