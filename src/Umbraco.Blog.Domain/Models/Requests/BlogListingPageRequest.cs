using System.Diagnostics.CodeAnalysis;
using Umbraco.Cms.Core.Models.PublishedContent;

namespace Umbraco.Blog.Domain.Models.Requests;

[ExcludeFromCodeCoverage]
public class BlogListingPageRequest
{
    public BlogListingPageRequest(IPublishedContent currentPage, int pageNumber)
    {
        CurrentPage = currentPage;
        PageNumber = pageNumber;

    }

    public IPublishedContent? CurrentPage { get; set; }
    public int PageNumber { get; set; } = 1;
}
