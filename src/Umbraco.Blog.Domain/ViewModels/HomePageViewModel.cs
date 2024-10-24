
using System.Diagnostics.CodeAnalysis;
using Umbraco.Blog.Domain.ViewModels;
using Umbraco.Cms.Core.Models.PublishedContent;

[ExcludeFromCodeCoverage]
public class HomePageViewModel  : PublishedContentWrapped
{
    public HomePageViewModel(IPublishedContent content, IPublishedValueFallback publishedValueFallback) 
        : base(content, publishedValueFallback)
    {
    }

    public string Title { get; set; } = string.Empty;
    public BlogListingViewModel BlogListing { get; set; } = new BlogListingViewModel();
}