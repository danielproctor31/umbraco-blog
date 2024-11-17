using System.Diagnostics.CodeAnalysis;
using Umbraco.Cms.Core.Models.PublishedContent;

namespace Umbraco.Blog.Domain.Models.Requests;

[ExcludeFromCodeCoverage]
public class BlogListingRequest(IPublishedContent page)
{
    public IPublishedContent Page { get; set; } = page;
}
