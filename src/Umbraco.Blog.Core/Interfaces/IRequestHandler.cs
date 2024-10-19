namespace Umbraco.Blog.Core.Interfaces;

public interface IRequestHandler<TRequest, TResponse>
{
    public Task<TResponse> Handle(TRequest request);
}
