using System.Collections.Generic;

namespace Estore.Models
{
    public class BlogWriter
    {
        public int Id { get; set; }
        public string Img { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string About { get; set; }
        public IEnumerable<Post>Posts { get; set; }


    }
}
