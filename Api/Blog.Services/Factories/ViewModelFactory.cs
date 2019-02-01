using Blog.Domain.Models;
using Blog.Services.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace Blog.Services.Factories
{
    public class ViewModelFactory
    {
        public static PostViewModel Create(Post post)
        {
            return new PostViewModel
            {
                Id = post.Id,
                Title = post.Title,
                Content = post.Content,
                CreationDate = post.CreationDate,
                LastUpdate = post.LastUpdate
            };
        }
    }
}
