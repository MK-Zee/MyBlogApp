using Microsoft.AspNetCore.Mvc;
using MyBlogApp.Posts;
using System;
using System.Threading.Tasks;

namespace MyBlogApp.Controllers
{
    [Route("api/posts")]
    public class PostController : MyBlogAppController
    {
        private readonly IPostAppService _postAppService;

        public PostController(IPostAppService postAppService)
        {
            _postAppService = postAppService;
        }

        [HttpGet("with-comments")]
        public async Task<IActionResult> GetAllPostsWithCommentsAsync()
        {
            var posts = await _postAppService.GetAllPostsWithCommentsAsync();
            return Ok(posts);
        }


        [HttpGet("{id}/with-comments")]
        public async Task<IActionResult> GetPostWithCommentsAsync(Guid id)
        {
            var post = await _postAppService.GetAsync(id);
            if (post == null)
            {
                return NotFound();
            }
            return Ok(post);
        }
    }
}
