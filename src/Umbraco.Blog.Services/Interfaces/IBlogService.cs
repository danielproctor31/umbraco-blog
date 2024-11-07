using Umbraco.Blog.Domain.Models.Dto;
using Umbraco.Blog.Domain.Models.Requests;
using Umbraco.Blog.Domain.ViewModels;

namespace Umbraco.Blog.Services.Interfaces;

public interface IBlogService
{
    public Task<BlogListingResponseDto> GetBlogPosts(BlogListingRequest request);
}
