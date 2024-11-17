using System.Diagnostics.CodeAnalysis;
using Umbraco.Blog.Domain.ViewModels;

namespace Umbraco.Blog.Domain.Models.Dto;

[ExcludeFromCodeCoverage]
public class BlogListingResponseDto
{
    public IEnumerable<BlogItemViewModel> Items { get; set; } = [];
}
