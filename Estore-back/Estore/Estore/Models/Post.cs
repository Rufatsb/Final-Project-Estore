using System;
using System.Collections.Generic;

namespace Estore.Models
{
    public class Post
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Img { get; set; }
        public string Description { get; set; }
        public DateTime CreatedAt { get; set; }
        public IEnumerable<PostTags> PostTags { get; set; }
        public IEnumerable<PostCategories> PostCategories { get; set; }
        public IEnumerable<BlogComments> BlogComments { get; set; }
        public BlogWriter BlogWriter  { get; set; }
        public int BlogWriterId { get; set; }



    }
}
