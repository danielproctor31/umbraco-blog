using System.Diagnostics.CodeAnalysis;
using Umbraco.Blog.Domain.Models.Dto;
using Umbraco.Cms.Core.Models.PublishedContent;

namespace Umbraco.Blog.Domain.ViewModels;

[ExcludeFromCodeCoverage]
public class HomePageViewModel(IPublishedContent content, IPublishedValueFallback publishedValueFallback)
    : PublishedContentWrapped(content, publishedValueFallback)
{
    public string Title { get; set; } = string.Empty;
    public BlogListingResponseDto BlogListing { get; set; } = new();
}
