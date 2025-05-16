using MediatR;

namespace Ambev.DeveloperEvaluation.Application.Products.ListAllCategoriesOfProducts
{
    /// <summary>
    /// Command for retrieving all categories of product.
    /// </summary>
    public class ListAllCategoriesOfProductsCommand : IRequest<ListAllCategoriesOfProductsResult>
    {
    }
}
