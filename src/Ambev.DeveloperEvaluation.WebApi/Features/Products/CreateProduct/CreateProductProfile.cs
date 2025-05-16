using Ambev.DeveloperEvaluation.Application.Products;
using Ambev.DeveloperEvaluation.Application.Products.CreateProduct;
using Ambev.DeveloperEvaluation.Domain.Entities;
using AutoMapper;

namespace Ambev.DeveloperEvaluation.WebApi.Features.Products.CreateProduct
{
    /// <summary>
    /// Profile for mapping between Application and API CreateProduct responses.
    /// </summary>
    public class CreateProductProfile : Profile
    {
        /// <summary>
        /// Initializes the mappings for CreateProduct feature.
        /// </summary>
        public CreateProductProfile()
        {
            CreateMap<CreateProductRequest, CreateProductCommand>();
            CreateMap<Product, ProductResult>();
        }
    }
}
