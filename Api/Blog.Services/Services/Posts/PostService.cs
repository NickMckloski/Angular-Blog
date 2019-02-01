using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Blog.Data.Repositories.Posts;
using Blog.Domain.Models;
using Blog.Services.Factories;
using Blog.Services.ViewModels;

namespace Blog.Services.Services.Posts
{
    public class PostService : IPostService
    {
        private readonly IPostRepository _postRepo;

        public PostService(IPostRepository postRepo)
        {
            _postRepo = postRepo;
        }
        
        public IEnumerable<PostViewModel> GetAll()
        {
            return _postRepo.GetAll().ToList().Select(ViewModelFactory.Create);
        }

        public async Task<PostViewModel> GetByIdAsync(Guid id)
        {
            var post = await _postRepo.GetByIdAsync(id);
            return ViewModelFactory.Create(post);
        }

        public Task<Guid> CreateAsync(PostViewModel postViewModel)
        {
            var post = new Post(postViewModel.Title, postViewModel.Content);
            return _postRepo.CreateAsync(post);
        }

        public Task UpdateAsync(PostViewModel postViewModel)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(Guid id)
        {
            throw new NotImplementedException();
        }
    }
}
