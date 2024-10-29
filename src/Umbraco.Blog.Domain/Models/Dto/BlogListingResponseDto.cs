using System.Diagnostics.CodeAnalysis;

namespace Umbraco.Blog.Domain.ViewModels;

[ExcludeFromCodeCoverage]
public class BlogListingResponseDto
{
    public int Page = 1;
    public int Total { get; set; } = 0;
    public IEnumerable<BlogItemViewModel> Items { get; set; } = [];
}
