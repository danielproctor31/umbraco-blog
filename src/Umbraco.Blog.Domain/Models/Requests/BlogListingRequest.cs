using System.Diagnostics.CodeAnalysis;

namespace Umbraco.Blog.Domain.Models.Requests;

[ExcludeFromCodeCoverage]
public class BlogListingRequest
{
    public BlogListingRequest(int page, int blogListingPageId)
    {
        Page = page;
        BlogListingPageId = blogListingPageId;
    }

    public int Page { get; set; } = 1;
    public int BlogListingPageId { get; set; } = 0;
}
