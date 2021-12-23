using System.Collections.Generic;

namespace Estore.Models
{
    public class Tags
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public IEnumerable<PostTags> PostTags{get; set;}
    }
}
