namespace Ambev.DeveloperEvaluation.Domain.Events
{
    /// <summary>
    /// Event to notify when sale was modified.
    /// </summary>
    public class SaleModifiedEvent
    {
        public required Guid CartId { get; init; }
        public required Guid CustomerId { get; init; }
        public required string CustomerName { get; init; }
        public required int TotalProducts { get; init; }
        public required decimal TotalAmount { get; init; }
        public required ICollection<SaleProduct> Products { get; init; }

        public record SaleProduct
        {
            public required Guid ProductId { get; init; }
            public required string Title { get; init; }
            public required decimal Price { get; init; }
            public required decimal DiscountPercent { get; init; }
            public required decimal DiscountAmount { get; init; }
            public required decimal TotalAmount { get; init; }
        };
    }
}
