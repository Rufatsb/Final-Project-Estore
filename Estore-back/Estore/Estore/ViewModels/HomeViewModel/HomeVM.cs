using Estore.Models;
using System.Collections.Generic;

namespace Estore.ViewModels.HomeViewModel
{
    public class HomeVM
    {
        public virtual IEnumerable<Gallery> Galleries { get; set; }

    }
}
