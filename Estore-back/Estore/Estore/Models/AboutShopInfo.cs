using System.Collections;
using System.Collections.Generic;

namespace Estore.Models
{
    public class AboutShopInfo
    {
        public int Id { get; set;}
        public string Title { get; set;}
        public string Content { get; set;}
       public IEnumerable<AboutShopItem> Items { get; set;}
    }
}
