using System.Collections.Generic;

namespace Estore.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public string Description { get; set; }
        public ProductCategory ProductCategory { get; set; }
        public int ProductCategoryId { get; set; }
        public IEnumerable<Productimages> Productimages { get;}
        public int Count { get; set; }
    }
}
