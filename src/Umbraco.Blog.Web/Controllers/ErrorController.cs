using Microsoft.AspNetCore.Mvc;

namespace Umbraco.Blog.Web.Controllers;

public class ErrorController : Controller
{
    [Route("Error")]
    public IActionResult Index()
    {
        return View();
    }
}
