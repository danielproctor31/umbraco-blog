using System;
using Umbraco.Blog.Core.Exceptions;
using Umbraco.Blog.Domain.Models.Dto;
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
        bool hasContext = umbracoContextAccessor.TryGetUmbracoContext(out var context);

        if (!hasContext)
        {
            throw new UmbracoContextNotFoundException();
        }

        var blogPages = request.Page.DescendantsOfType("blogPage")
            .Select(x => new BlogItemViewModel
            {
                Title = x.Value<string>("title") ?? string.Empty,
                CreateDate = x.CreateDate,
                Url = x.Url(),
            });

        return Task.FromResult(new BlogListingResponseDto
        {
            Items = blogPages ?? [],
        });
    }
}
