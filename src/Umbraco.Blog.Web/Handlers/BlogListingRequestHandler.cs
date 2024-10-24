using Umbraco.Blog.Core.Exceptions;
using Umbraco.Blog.Core.Interfaces;
using Umbraco.Blog.Domain.Models;
using Umbraco.Blog.Domain.ViewModels;
using Umbraco.Cms.Core.Web;
using Umbraco.Cms.Web.Common.PublishedModels;

namespace Umbraco.Blog.Web.Handlers;
public class BlogListingRequestHandler(IUmbracoContextAccessor umbracoContextAccessor) 
    : IRequestHandler<BlogListingRequest, BlogListingViewModel>
{
    public Task<BlogListingViewModel> Handle(BlogListingRequest request, CancellationToken cancellationToken)
    {
        var hasContext = umbracoContextAccessor.TryGetUmbracoContext(out var context);

        if (!hasContext)
        {
            throw new UmbracoContextNotFoundException();
        }

        var blogFolder = context?.Content?.GetById(request.BlogFolderId);

        if (blogFolder == null)
        {
            throw new ContentNotFoundException($"No blog folder found with id: {request.BlogFolderId}");
        }

        var blogPages = blogFolder.Children<BlogPage>();
        var blogItems = blogPages?.Skip((request.Page * 10) - 10)
            ?.Take(10)
            ?.Select(x => new BlogItemViewModel
                {
                Title = x.Title ?? string.Empty,
                    CreateDate = x.CreateDate,
                    Url = x.Url(),
                });

        return Task.FromResult(new BlogListingViewModel
        {
            Total = blogPages?.Count() ?? 0,
            Items = blogItems ?? [],
        });
    }
}
