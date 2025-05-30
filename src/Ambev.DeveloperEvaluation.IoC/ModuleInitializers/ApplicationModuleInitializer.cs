﻿using Ambev.DeveloperEvaluation.Common.Security;
using Ambev.DeveloperEvaluation.Domain.Services;
using Ambev.DeveloperEvaluation.Domain.Specifications;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;

namespace Ambev.DeveloperEvaluation.IoC.ModuleInitializers;

public class ApplicationModuleInitializer : IModuleInitializer
{
    public void Initialize(WebApplicationBuilder builder)
    {
        builder.Services.AddSingleton<IPasswordHasher, BCryptPasswordHasher>();
        builder.Services.AddScoped<EnsureCategoryService>();
        builder.Services.AddTransient<SaleDiscountService>();
        builder.Services.AddTransient<SaleRandomNumberGeneratorService>();
        builder.Services.AddTransient<SaleLimitReachedSpecification>();
    }
}