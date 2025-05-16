using FluentValidation;

namespace Ambev.DeveloperEvaluation.WebApi.Features.Products.UpdateProduct
{
    /// <summary>
    /// Validator for <see cref="UpdateProductRequest"/> that defines validation rules for product creation.
    /// </summary>
    public class UpdateProductRequestValidator : AbstractValidator<UpdateProductRequest>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateProductRequestValidator"/> with defined validation rules.
        /// </summary>
        /// <remarks>
        /// <listheader>The validation includes checking:</listheader>
        /// <list type="bullet">Required, must be between 3 and 200 characters</list>
        /// <list type="bullet">Price: Must be greater than zero</list>
        /// </remarks>
        public UpdateProductRequestValidator()
        {
            RuleFor(product => product.Id).NotEmpty();
            RuleFor(product => product.Name).NotEmpty().Length(3, 200);
            RuleFor(product => product.Price).GreaterThan(0);
        }
    }
}
