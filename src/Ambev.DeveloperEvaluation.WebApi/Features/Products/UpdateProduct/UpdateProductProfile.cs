using Ambev.DeveloperEvaluation.Application.Products;
using Ambev.DeveloperEvaluation.Application.Products.UpdateProduct;
using Ambev.DeveloperEvaluation.Domain.Entities;
using AutoMapper;

namespace Ambev.DeveloperEvaluation.WebApi.Features.Products.UpdateProduct
{

    /// <summary>
    /// Profile for mapping between Application and API UpdateProduct responses.
    /// </summary>
    public class UpdateProductProfile : Profile
    {
        /// <summary>
        /// Initializes the mappings for UpdateProduct feature.
        /// </summary>
        public UpdateProductProfile()
        {
            CreateMap<UpdateProductRequest, UpdateProductCommand>();
            CreateMap<Product, ProductResult>();
        }
    }
}
