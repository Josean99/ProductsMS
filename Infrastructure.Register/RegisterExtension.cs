using EntityService.Model;
using EntityService.Validators;
using FluentValidation;
using FluentValidation.AspNetCore;
using Infrastructure.Exceptions.Policies;
using Infrastructure.Exceptions.Policies.Interfaces;
using IReadBusinessLayer;
using IReadRepositories;
using IReadRepositories.Base;
using IWriteBusinessLayer;
using IWriteRepository.Base;
using Microsoft.Extensions.DependencyInjection;
using ReadBusinessLayer;
using ReadRepositories;
using ReadRepositories.Base;
using WriteBusinessLayer;
using WriteRepository.Base;

namespace Infrastructure
{
    public static class RegisterExtension
    {

        public static IServiceCollection RegisterExceptionPolicies(this IServiceCollection services)
        {
            services.AddSingleton<IExceptionPolicy, SanitizeNotCustomExceptionPolicy>();
            //services.AddScoped<IExceptionPolicy, DoNotSanitizeExceptionPolicy>();
            //services.AddScoped<IExceptionPolicy, SanitizeAllExceptionPolicy>();

            return services;
        }

        public static IServiceCollection RegisterRepositories(this IServiceCollection services)
        {
            services.AddScoped(typeof(IBaseWriteRepository<>), typeof(BaseWriteRepository<>));
            services.AddScoped<IBaseReadRepository, BaseReadRepository>();
            services.AddScoped<ICategoriesReadRepository, CategoriesReadRepository>();

            return services;
        }

        public static IServiceCollection RegisterServices(this IServiceCollection services)
        {
            services.AddScoped<IBrandsWriteService, BrandsWriteService>();
            services.AddScoped<ICategoriesWriteService, CategoriesWriteService>();
            services.AddScoped<IImagesWriteService, ImagesWriteService>();
            services.AddScoped<IProductsWriteService, ProductsWriteService>();
            services.AddScoped<ITextsWriteService, TextsWriteService>();

            services.AddScoped<IBrandsReadService, BrandsReadService>();
            services.AddScoped<ICategoriesReadService, CategoriesReadService>();
            services.AddScoped<IImagesReadService, ImagesReadService>();
            services.AddScoped<IProductsReadService, ProductsReadService>();
            services.AddScoped<ITextsReadService, TextsReadService>();

            return services;
        }

        public static IServiceCollection RegisterValidators(this IServiceCollection services)
        {
            services.AddFluentValidationAutoValidation();
            services.AddFluentValidationClientsideAdapters();

            services.AddScoped<IValidator<Brand>, BrandValidator>();
            services.AddScoped<IValidator<Category>, CategoryValidator>();
            services.AddScoped<IValidator<Image>, ImageValidator>();
            services.AddScoped<IValidator<Product>, ProductValidator>();
            services.AddScoped<IValidator<ProductImage>, ProductImageValidator>();
            services.AddScoped<IValidator<Text>, TextValidator>();

            return services;
        }


    }
}
