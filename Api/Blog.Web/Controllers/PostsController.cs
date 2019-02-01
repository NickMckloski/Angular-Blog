using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Blog.Services.Services.Posts;
using Blog.Services.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace Blog.Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PostsController : ControllerBase
    {
        private readonly IPostService _postService;

        public PostsController(IPostService postService)
        {
            _postService = postService;
        }

        [HttpGet]
        public IEnumerable<PostViewModel> GetAll()
        {
            return _postService.GetAll();
        }

        [HttpGet("{id}")]
        public async Task<PostViewModel> GetByIdAsync(Guid id)
        {
            return await _postService.GetByIdAsync(id);
        }
        
        [HttpPost]
        public async Task<Guid> CreateAsync([FromBody] PostViewModel postViewModel)
        {
            return await _postService.CreateAsync(postViewModel);
        }
        
        [HttpPut("{id}")]
        public void Update([FromBody] PostViewModel postViewModel)
        {
            _postService.UpdateAsync(postViewModel);
        }
        
        [HttpDelete("{id}")]
        public void Delete(Guid id)
        {
            _postService.DeleteAsync(id);
        }
    }
}
