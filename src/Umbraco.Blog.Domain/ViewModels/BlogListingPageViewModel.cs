using System.Diagnostics.CodeAnalysis;
using Umbraco.Blog.Domain.Models.Dto;
using Umbraco.Cms.Core.Models.PublishedContent;

namespace Umbraco.Blog.Domain.ViewModels;

[ExcludeFromCodeCoverage]
public class BlogListingPageViewModel(IPublishedContent content, IPublishedValueFallback publishedValueFallback)
    : PublishedContentWrapped(content, publishedValueFallback)
{
    public BlogListingResponseDto Results { get; set; } = new();
}
