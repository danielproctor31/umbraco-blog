using System.Diagnostics.CodeAnalysis;
using Umbraco.Blog.Domain.ViewModels;

namespace Umbraco.Blog.Domain.Models.Dto;

[ExcludeFromCodeCoverage]
public class BlogListingResponseDto
{
    public int Page = 1;
    public int Total { get; set; } = 0;
    public IEnumerable<BlogItemViewModel> Items { get; set; } = [];
}
