using Umbraco.Blog.Core.Interfaces;
using Umbraco.Cms.Core.Models.PublishedContent;
using Umbraco.Cms.Core.Services;
using Umbraco.Cms.Web.Common.PublishedModels;

namespace Umbraco.Blog.Web.Handlers;
public class BlogPageRequestHandler(IVariationContextAccessor variationContextAccessor, ServiceContext context) 
    : IRequestHandler<BlogPage, BlogPageViewModel>
{
    public Task<BlogPageViewModel> Handle(BlogPage blogPage, CancellationToken cancellationToken)
    {
        return Task.FromResult(new BlogPageViewModel(blogPage, new PublishedValueFallback(context, variationContextAccessor))
        {
            Title = blogPage.Title,
            Body = blogPage.Body?.ToHtmlString() ?? string.Empty,
        });
    }
}
