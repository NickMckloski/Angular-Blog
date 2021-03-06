﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Blog.Domain.Models
{
    public class Post : Entity
    {

        public Post(string title, string content)
        {
            Title = title;
            Content = content;
            CreationDate = DateTime.UtcNow;
        }

        public string Title { get; set; }
        public string Content { get; set; }
        public DateTime CreationDate { get; set; }
        public DateTime LastUpdate { get; set; }
    }
}
