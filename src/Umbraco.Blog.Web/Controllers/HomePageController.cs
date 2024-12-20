using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ViewEngines;
using Umbraco.Blog.Core.Interfaces;
using Umbraco.Blog.Domain.ViewModels;
using Umbraco.Cms.Core.Web;
using Umbraco.Cms.Web.Common.Controllers;
using Umbraco.Cms.Web.Common.PublishedModels;

namespace Umbraco.Blog.Web.Controllers;

public class HomePageController(ILogger<HomePageController> logger, IRequestHandler<HomePage, HomePageViewModel> handler,
    ICompositeViewEngine compositeViewEngine, IUmbracoContextAccessor umbracoContextAccessor)
    : RenderController(logger, compositeViewEngine, umbracoContextAccessor)
{
    [NonAction]
    public sealed override IActionResult Index() => throw new NotImplementedException();
    public async Task<IActionResult> Index(CancellationToken cancellationToken)
    {
        try
        {
            return CurrentPage is not HomePage homePage
                ? BadRequest() :
                CurrentTemplate(await handler.Handle(homePage, cancellationToken));
        }
        catch (Exception e)
        {
            logger.LogError(e, $"Error getting {nameof(HomePage)}");
            return StatusCode(500);
        }
    }
}
