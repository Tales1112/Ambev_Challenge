﻿using FluentValidation;

namespace Ambev.DeveloperEvaluation.Application.Carts.DeleteCart
{
    /// <summary>
    /// Validator for <see cref="DeleteCartCommand"/>.
    /// </summary>
    public class DeleteCartValidator : AbstractValidator<DeleteCartCommand>
    {
        /// <summary>
        /// Initializes validation rules for <see cref="DeleteCartCommand"/>.
        /// </summary>
        public DeleteCartValidator()
        {
            RuleFor(x => x.Id)
                .NotEmpty()
                .WithMessage("Cart ID is required.");
        }
    }
}
