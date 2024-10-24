using Umbraco.Blog.Core.Interfaces;
using Umbraco.Blog.Domain.Models.Requests;
using Umbraco.Blog.Domain.ViewModels;
using Umbraco.Cms.Core.Models.PublishedContent;
using Umbraco.Cms.Core.Services;
using Umbraco.Cms.Web.Common.PublishedModels;

namespace Umbraco.Blog.Web.Handlers;
public class HomePageRequestHandler(IVariationContextAccessor variationContextAccessor, ServiceContext context,
    IRequestHandler<BlogListingRequest, BlogListingViewModel> blogListingHandler) 
    : IRequestHandler<HomePage, HomePageViewModel>
{
    public async Task<HomePageViewModel> Handle(HomePage homePage, CancellationToken cancellationToken) 
    {
        var blogFolderId = homePage.BlogFolder?.Id ?? 0;
        var blogListing = new BlogListingViewModel();

        if (blogFolderId > 0)
        {
            blogListing = await blogListingHandler.Handle(new BlogListingRequest(1, blogFolderId), cancellationToken);
        }

        return new HomePageViewModel(homePage, new PublishedValueFallback(context, variationContextAccessor))
        {
            Title = homePage.Title ?? string.Empty,
            BlogListing = blogListing
        };
    }
}
