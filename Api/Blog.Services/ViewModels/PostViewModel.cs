using System;
using System.Collections.Generic;
using System.Text;

namespace Blog.Services.ViewModels
{
    public class PostViewModel : EntityViewModel
    {
        public string Title { get; set; }
        public string Content { get; set; }
        public DateTime CreationDate { get; set; }
        public DateTime LastUpdate { get; set; }
    }
}
