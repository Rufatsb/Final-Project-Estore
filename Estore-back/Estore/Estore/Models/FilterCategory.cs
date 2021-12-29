using System.Collections.Generic;

namespace Estore.Models
{
    public class FilterCategory
    {
        public int Id { get; set; }
        public string Category { get; set; }
        public IEnumerable <FilterItems>FilterItems { get; set; }
    }
}
