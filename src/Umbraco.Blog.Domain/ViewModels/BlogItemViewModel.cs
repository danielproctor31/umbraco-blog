using System.Diagnostics.CodeAnalysis;

namespace Umbraco.Blog.Domain.ViewModels;

[ExcludeFromCodeCoverage]
public class BlogItemViewModel
{
    public string Title { get; set; } = string.Empty;
    public DateTime CreateDate { get; set; }
    public string Url { get; set; } = string.Empty;
}
