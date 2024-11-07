namespace Umbraco.Blog.Core.Interfaces;

public interface IRequestHandler<in TRequest, TResponse>
{
    public Task<TResponse> Handle(TRequest request, CancellationToken cancellationToken);
}
