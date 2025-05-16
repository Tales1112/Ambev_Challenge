using Ambev.DeveloperEvaluation.Domain.Entities;
using Ambev.DeveloperEvaluation.Domain.Enums;
using AutoMapper;

namespace Ambev.DeveloperEvaluation.Application.Carts.CreateCart
{
    /// <summary>
    /// Profile for mapping between <see cref="Cart"/> entity and <see cref="CreateCartResult"/>.
    /// </summary>
    public class CreateCartProfile : Profile
    {
        /// <summary>
        /// Initializes the mappings for CreateProduct operation
        /// </summary>
        public CreateCartProfile()
        {
            CreateMap<Cart, CartResult>()
                .ForMember(_ => _.UserId, mce => mce.MapFrom(_ => _.BoughtById))
                .ForMember(_ => _.Date, mce => mce.MapFrom(_ => _.SoldAt))
                .ForMember(_ => _.Branch, mce => mce.MapFrom(_ => _.StoreName))
                .ForMember(_ => _.IsCancelled, mce => mce.MapFrom((c, r) => c.PurchaseStatus is PurchaseStatus.Cancelled))
                .ForMember(_ => _.Products, mce => mce.MapFrom(_ => _.Items));

            CreateMap<CartItem, CartItemResult>();
        }
    }
}
