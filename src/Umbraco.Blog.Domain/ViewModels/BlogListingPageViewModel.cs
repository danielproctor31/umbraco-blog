
using System.Diagnostics.CodeAnalysis;
using Umbraco.Blog.Domain.ViewModels;
using Umbraco.Cms.Core.Models.PublishedContent;

[ExcludeFromCodeCoverage]
public class BlogListingPageViewModel  : PublishedContentWrapped
{
    public BlogListingPageViewModel(IPublishedContent content, IPublishedValueFallback publishedValueFallback) 
        : base(content, publishedValueFallback)
    {
    }

    public BlogListingResponseDto Results { get; set; } = new();
}