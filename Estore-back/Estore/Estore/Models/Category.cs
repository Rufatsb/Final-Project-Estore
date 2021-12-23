using System.Collections.Generic;

namespace Estore.Models
{
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public IEnumerable<PostCategories> PostCategories { get; set; }

    }
}
