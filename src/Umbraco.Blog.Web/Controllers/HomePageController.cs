using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ViewEngines;
using Umbraco.Cms.Core.Models.PublishedContent;
using Umbraco.Cms.Core.Services;
using Umbraco.Cms.Core.Web;
using Umbraco.Cms.Web.Common.Controllers;
using Umbraco.Cms.Web.Common.PublishedModels;

namespace Umbraco.Blog.Web.Controllers;

public class HomePageController(ILogger<HomePageController> logger, ICompositeViewEngine compositeViewEngine, IUmbracoContextAccessor umbracoContextAccessor,
IVariationContextAccessor variationContextAccessor, ServiceContext context) : RenderController(logger, compositeViewEngine, umbracoContextAccessor)
{
    public override IActionResult Index()
    {
        if (CurrentPage is HomePage homePage)
        {
            return CurrentTemplate(new HomePageViewModel(CurrentPage, new PublishedValueFallback(context, variationContextAccessor))
            {
                Title = homePage?.Title ?? string.Empty
            });
        }
        return BadRequest();
    }
}