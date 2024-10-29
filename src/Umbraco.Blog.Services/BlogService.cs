using System;
using Umbraco.Blog.Core.Exceptions;
using Umbraco.Blog.Domain.Models.Requests;
using Umbraco.Blog.Domain.ViewModels;
using Umbraco.Blog.Services.Interfaces;
using Umbraco.Cms.Core.Models.PublishedContent;
using Umbraco.Cms.Core.Web;

namespace Umbraco.Blog.Services;

public class BlogService(IUmbracoContextAccessor umbracoContextAccessor) : IBlogService
{
    public Task<BlogListingResponseDto> GetBlogPosts(BlogListingRequest request)
    {
        var hasContext = umbracoContextAccessor.TryGetUmbracoContext(out var context);

        if (!hasContext)
        {
            throw new UmbracoContextNotFoundException();
        }

        var blogFolder = context?.Content?.GetById(request.BlogListingPageId);

        if (blogFolder == null)
        {
            throw new ContentNotFoundException($"No blog listing page found with id: {request.BlogListingPageId}");
        }

        var blogPages = blogFolder.Children<IPublishedContent>()?
                            .Where(x => x.ContentType.Alias.Equals("blogPage"));

        var blogItems = blogPages?.Skip((request.Page * 10) - 10)
            ?.Take(10)
            ?.Select(x => new BlogItemViewModel
                {
                Title = x.Value<string>("title") ?? string.Empty,
                    CreateDate = x.CreateDate,
                    Url = x.Url(),
                });

        return Task.FromResult(new BlogListingResponseDto
        {
            Page = request.Page,
            Total = blogPages?.Count() ?? 0,
            Items = blogItems ?? [],
        });
    }
}
