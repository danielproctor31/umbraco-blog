using System.Diagnostics.CodeAnalysis;
using Microsoft.Extensions.DependencyInjection;
using Umbraco.Blog.Services.Interfaces;

namespace Umbraco.Blog.Services;

[ExcludeFromCodeCoverage]
public static class ServiceCollectionExtensions
{
    public static IServiceCollection AddBlogServices(this IServiceCollection services)
    {
        return services.AddTransient<IBlogService, BlogService>();
    }
}
