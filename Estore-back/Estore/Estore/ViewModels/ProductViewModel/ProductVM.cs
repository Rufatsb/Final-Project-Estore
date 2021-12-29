using Estore.Models;
using System.Collections.Generic;

namespace Estore.ViewModels.ProductViewModel
{
    public class ProductVM
    {
        public virtual Subscribe Subscribe { get; set; }
        public virtual IEnumerable<ShopMethod> ShopMethods { get; set; }

    }
}
