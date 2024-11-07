using System.Diagnostics.CodeAnalysis;
using Umbraco.Cms.Core.Models.PublishedContent;

namespace Umbraco.Blog.Domain.ViewModels;

[ExcludeFromCodeCoverage]
public class BlogPageViewModel(IPublishedContent content, IPublishedValueFallback publishedValueFallback)
    : PublishedContentWrapped(content, publishedValueFallback)
{
    public string Title { get; set; } = string.Empty;
    public string Body { get; set; } = string.Empty;
}
