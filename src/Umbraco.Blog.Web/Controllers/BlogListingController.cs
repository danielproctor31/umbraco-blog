using Microsoft.AspNetCore.Mvc;
using Umbraco.Blog.Core.Interfaces;
using Umbraco.Blog.Domain.Models;
using Umbraco.Blog.Domain.ViewModels;

namespace Umbraco.Blog.Web.Controllers;

[Route("api/[controller]")]
[ApiController]
public class BlogListingController(IRequestHandler<BlogListingRequest, BlogListingViewModel> handler,
    ILogger<BlogListingController> logger) : ControllerBase
{
    [HttpGet]
    public async Task<IActionResult> Index([FromQuery] BlogListingRequest request)
    {
        if(!ModelState.IsValid)
        {
            return BadRequest(ModelState);
        }

        try
        {
            return Ok(await handler.Handle(request, default));
        }
        catch (Exception e)
        {
            logger.LogError(e, $"Error getting blogs");
            return StatusCode(500);
        }
    }
}
