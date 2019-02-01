using Blog.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Blog.Data.Repositories.Posts
{
    public class PostRepository : GenericRepository<Post>, IPostRepository
    {
        public PostRepository(BlogContext context) : base(context)
        {
        }
    }
}
