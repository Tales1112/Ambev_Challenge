using Ambev.DeveloperEvaluation.Application.Products;
using Ambev.DeveloperEvaluation.Application.Products.GetProduct;
using Ambev.DeveloperEvaluation.Domain.Entities;
using AutoMapper;

namespace Ambev.DeveloperEvaluation.WebApi.Features.Products.GetProduct
{
    /// <summary>
    /// Profile for mapping between Product entity and <see cref="ProductResult"/>.
    /// </summary>
    public class GetProductProfile : Profile
    {
        /// <summary>
        /// Initializes the mappings for GetProduct feature.
        /// </summary>
        public GetProductProfile()
        {
            CreateMap<GetProductRequest, GetProductCommand>();
            CreateMap<Product, ProductResult>();
        }
    }
}
