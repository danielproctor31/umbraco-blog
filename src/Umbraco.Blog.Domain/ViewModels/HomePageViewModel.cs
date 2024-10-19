
using System.Diagnostics.CodeAnalysis;
using Umbraco.Cms.Core.Models.PublishedContent;

[ExcludeFromCodeCoverage]
public class HomePageViewModel  : PublishedContentWrapped
{
    public HomePageViewModel(IPublishedContent content, IPublishedValueFallback publishedValueFallback) 
        : base(content, publishedValueFallback)
    {
    }

    public string Title { get; set; } = string.Empty;
    public IEnumerable<BlogItemViewModel> BlogPosts { get; set; } = [];
}

[ExcludeFromCodeCoverage]
public class BlogItemViewModel
{
    public string Title { get; set; } = string.Empty;
    public string Url { get; set; } = string.Empty;
}