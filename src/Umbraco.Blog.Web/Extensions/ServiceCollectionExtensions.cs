using System.Diagnostics.CodeAnalysis;
using Umbraco.Blog.Core.Interfaces;
using Umbraco.Blog.Domain.Models;
using Umbraco.Blog.Domain.ViewModels;
using Umbraco.Blog.Web.Handlers;
using Umbraco.Cms.Web.Common.PublishedModels;

namespace Umbraco.Blog.Web.Extensions;

[ExcludeFromCodeCoverage]
public static class ServiceCollectionExtensions
{
    public static void AddRequestHandlers(this IServiceCollection services)
    {
        services.AddTransient<IRequestHandler<HomePage, HomePageViewModel>, HomePageRequestHandler>();
        services.AddTransient<IRequestHandler<BlogPage, BlogPageViewModel>, BlogPageRequestHandler>();
        services.AddTransient<IRequestHandler<BlogListingRequest, BlogListingViewModel>, BlogListingRequestHandler>();
    }
}
