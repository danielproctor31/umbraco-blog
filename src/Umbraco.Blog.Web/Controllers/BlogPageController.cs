using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ViewEngines;
using Umbraco.Blog.Core.Interfaces;
using Umbraco.Cms.Core.Web;
using Umbraco.Cms.Web.Common.Controllers;
using Umbraco.Cms.Web.Common.PublishedModels;

namespace Umbraco.Blog.Web.Controllers;

public class BlogPageController(ILogger<BlogPageController> logger, IRequestHandler<BlogPage, BlogPageViewModel> handler,
ICompositeViewEngine compositeViewEngine, IUmbracoContextAccessor umbracoContextAccessor) : RenderController(logger, compositeViewEngine, umbracoContextAccessor)
{
    [NonAction]
    public sealed override IActionResult Index() => throw new NotImplementedException();
    public async Task<IActionResult> Index(CancellationToken cancellationToken)
    {
        if (CurrentPage is not BlogPage blogPage)
        {
            return NotFound();
        }
        
        return CurrentTemplate(await handler.Handle(blogPage, cancellationToken));        
    }
}