using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace Umbraco.Blog.Domain.Models;

[ExcludeFromCodeCoverage]
public class BlogListingRequest
{
    public BlogListingRequest()
    {

    }

    public BlogListingRequest(int page, int blogFolderId)
    {
        Page = page;
        BlogFolderId = blogFolderId;
    }

    [Required]
    [Range(1, int.MaxValue, ErrorMessage = "Please enter a value greater than 0")]
    public int Page { get; set; } = 1;
    
    [Required]
    [Range(1, int.MaxValue, ErrorMessage = "Please enter a value greater than 0")]
    public int BlogFolderId { get; set; } = 0;
}
