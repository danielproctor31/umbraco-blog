using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace Umbraco.Blog.Domain.Models;

[ExcludeFromCodeCoverage]
public class BlogListingRequestDto
{
    [Required]
    [Range(1, int.MaxValue, ErrorMessage = "Please enter a value greater than 0")]
    public int Page { get; set; } = 1;
}
