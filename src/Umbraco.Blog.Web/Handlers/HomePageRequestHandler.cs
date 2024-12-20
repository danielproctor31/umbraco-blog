using Umbraco.Blog.Core.Interfaces;
using Umbraco.Blog.Domain.Models.Dto;
using Umbraco.Blog.Domain.Models.Requests;
using Umbraco.Blog.Domain.ViewModels;
using Umbraco.Blog.Services.Interfaces;
using Umbraco.Cms.Core.Models.PublishedContent;
using Umbraco.Cms.Core.Services;
using Umbraco.Cms.Web.Common.PublishedModels;

namespace Umbraco.Blog.Web.Handlers;
public class HomePageRequestHandler(IVariationContextAccessor variationContextAccessor, ServiceContext context,
    IBlogService blogService)
    : IRequestHandler<HomePage, HomePageViewModel>
{
    public async Task<HomePageViewModel> Handle(HomePage homePage, CancellationToken cancellationToken)
    {
        var blogListing = await blogService.GetBlogPosts(new BlogListingRequest(homePage));

        return new HomePageViewModel(homePage, new PublishedValueFallback(context, variationContextAccessor))
        {
            Title = homePage.Title ?? string.Empty,
            BlogListing = blogListing
        };
    }
}
