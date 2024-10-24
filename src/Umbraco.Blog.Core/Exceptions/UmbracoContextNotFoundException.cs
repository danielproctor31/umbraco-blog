using System.Diagnostics.CodeAnalysis;

namespace Umbraco.Blog.Core.Exceptions;

[ExcludeFromCodeCoverage]
public class UmbracoContextNotFoundException : Exception
{
    public UmbracoContextNotFoundException()
    {

    }

    public UmbracoContextNotFoundException(string message)
        : base(message)
    {
    }

    public UmbracoContextNotFoundException(string message, Exception inner)
        : base(message, inner)
    {
    }
}
