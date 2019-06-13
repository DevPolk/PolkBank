using System;
using System.Collections.Generic;
using System.Text;

namespace Infrastructure.Entities
{
    public class News
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public string ImageUrl { get; set; }
    }
}
