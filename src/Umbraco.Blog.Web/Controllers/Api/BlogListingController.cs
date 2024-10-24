using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Umbraco.Blog.Core.Interfaces;
using Umbraco.Blog.Domain.Models;
using Umbraco.Blog.Domain.Models.Requests;
using Umbraco.Blog.Domain.ViewModels;

namespace Umbraco.Blog.Web.Controllers.Api;

[Route("api/[controller]")]
[ApiController]
public class BlogListingController(IRequestHandler<BlogListingRequest, BlogListingViewModel> handler,
    ILogger<BlogListingController> logger) : ControllerBase
{
    [HttpGet]
    public async Task<IActionResult> Index([FromQuery] BlogListingRequestDto request)
    {
        if(!ModelState.IsValid)
        {
            return BadRequest(ModelState);
        }

        try
        {
            return Ok(await handler.Handle(new BlogListingRequest(request.Page, request.BlogFolderId), default));
        }
        catch (Exception e)
        {
            var requestJson = JsonConvert.SerializeObject(request);
            logger.LogError(e, "Error getting blogs for request {requestJson}", requestJson);
            return StatusCode(500);
        }
    }
}
