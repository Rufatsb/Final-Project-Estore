using System;

namespace Estore.Models
{
    public class BlogComments
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Text { get; set; }
        public DateTime CreatedAt { get; set; }
        public Post Post { get; set; }
        public int PostId { get; set; }
    }
}
