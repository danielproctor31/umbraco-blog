using Umbraco.Blog.Core.Interfaces;
using Umbraco.Blog.Domain.Models.Requests;
using Umbraco.Blog.Domain.ViewModels;
using Umbraco.Blog.Services.Interfaces;
using Umbraco.Cms.Core.Models.PublishedContent;
using Umbraco.Cms.Core.Services;

namespace Umbraco.Blog.Web.Handlers;
public class BlogListingPageRequestHandler(IBlogService blogService,
    IVariationContextAccessor variationContextAccessor, ServiceContext context)
    : IRequestHandler<BlogListingPageRequest, BlogListingPageViewModel>
{
    public async Task<BlogListingPageViewModel> Handle(BlogListingPageRequest request, CancellationToken cancellationToken)
    {
        var results = await blogService.GetBlogPosts(new BlogListingRequest(request.PageNumber, request.CurrentPage?.Id ?? 0));

        return new BlogListingPageViewModel(request.CurrentPage, new PublishedValueFallback(context, variationContextAccessor))
        {
            Results = results
        };
    }
}
