using Umbraco.Blog.Core.Interfaces;
using Umbraco.Cms.Core.Models.PublishedContent;
using Umbraco.Cms.Core.Services;
using Umbraco.Cms.Web.Common.PublishedModels;

namespace Umbraco.Blog.Web.Handlers;
public class HomePageRequestHandler(IVariationContextAccessor variationContextAccessor, ServiceContext context) 
    : IRequestHandler<HomePage, HomePageViewModel>
{
    public Task<HomePageViewModel> Handle(HomePage homePage) 
    {
        var blogPages = homePage?.Children?.Where(x => x is BlogPage && x.IsPublished())
            ?.Cast<BlogPage>()
            ?.Select(x => new BlogItemViewModel
                {
                    Title = x.Title,
                    Url = x.Url(),
                });

        return Task.FromResult(new HomePageViewModel(homePage, new PublishedValueFallback(context, variationContextAccessor))
        {
            Title = homePage.Title,
            BlogPosts = blogPages
        });
    }
}
