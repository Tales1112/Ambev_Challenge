using FluentValidation;

namespace Ambev.DeveloperEvaluation.Application.Products.CreateProduct
{
    /// <summary>
    /// Validator for <see cref="CreateProductCommand"/> that defines validation rules for product creation command.
    /// </summary>
    public class CreateProductValidator : AbstractValidator<CreateProductCommand>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateProductValidator"/> with defined validation rules.
        /// </summary>
        /// <remarks>
        /// Validation rules include:
        /// <listheader>The validation includes checking:</listheader>
        /// <list type="bullet">Name: Required, must be between 3 and 200 characters</list>
        /// <list type="bullet">Price: Must be greater than zero</list>
        /// </remarks>
        public CreateProductValidator()
        {
            RuleFor(product => product.Name).NotEmpty().Length(3, 200);
            RuleFor(product => product.Price).GreaterThan(0);
        }
    }
}
