﻿namespace Ambev.DeveloperEvaluation.WebApi.Features.Carts.CreateCart
{
    /// <summary>
    /// Represents request the item of cart.
    /// </summary>
    public class CreateCartItemRequest
    {
        /// <summary>
        /// Gets the product identifier.
        /// </summary>
        public Guid ProductId { get; set; }

        /// <summary>
        /// Gets the quantity of products.
        /// </summary>
        public int Quantity { get; set; }
    }
}
