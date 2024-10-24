using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace Umbraco.Blog.Domain.Models.Requests;

[ExcludeFromCodeCoverage]
public class BlogListingRequest
{
    public BlogListingRequest(int page, int blogFolderId)
    {
        Page = page;
        BlogFolderId = blogFolderId;
    }

    public int Page { get; set; } = 1;
    public int BlogFolderId { get; set; } = 0;
}
