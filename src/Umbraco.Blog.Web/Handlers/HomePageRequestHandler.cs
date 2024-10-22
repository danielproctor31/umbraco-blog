using NPoco.Expressions;
using Umbraco.Blog.Core.Interfaces;
using Umbraco.Cms.Core.Models.PublishedContent;
using Umbraco.Cms.Core.Services;
using Umbraco.Cms.Web.Common.PublishedModels;

namespace Umbraco.Blog.Web.Handlers;
public class HomePageRequestHandler(IVariationContextAccessor variationContextAccessor, ServiceContext context) 
    : IRequestHandler<HomePage, HomePageViewModel>
{
    public Task<HomePageViewModel> Handle(HomePage homePage, CancellationToken cancellationToken) 
    {
        var blogPages = homePage.Descendants<BlogPage>()?.Where(x => x.IsPublished())
            ?.Select(x => new BlogItemViewModel
                {
                    Title = x.Title ?? string.Empty,
                    Url = x.Url(),
                });

        return Task.FromResult(new HomePageViewModel(homePage, new PublishedValueFallback(context, variationContextAccessor))
        {
            Title = homePage.Title ?? string.Empty,
            BlogPosts = blogPages ?? []
        });
    }
}
