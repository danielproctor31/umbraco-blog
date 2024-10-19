
using System.Diagnostics.CodeAnalysis;
using Umbraco.Cms.Core.Models.PublishedContent;

[ExcludeFromCodeCoverage]
public class BlogPageViewModel  : PublishedContentWrapped
{
    public BlogPageViewModel(IPublishedContent content, IPublishedValueFallback publishedValueFallback) 
        : base(content, publishedValueFallback)
    {
    }

    public string Title { get; set; } = string.Empty;
    public string Body { get; set; } = string.Empty;
}