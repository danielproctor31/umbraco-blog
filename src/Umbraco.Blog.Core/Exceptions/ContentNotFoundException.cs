using System.Diagnostics.CodeAnalysis;

namespace Umbraco.Blog.Core.Exceptions;

[ExcludeFromCodeCoverage]
public class ContentNotFoundException : Exception
{
    public ContentNotFoundException()
    {

    }

    public ContentNotFoundException(string message)
        : base(message)
    {
    }

    public ContentNotFoundException(string message, Exception inner)
        : base(message, inner)
    {
    }
}
