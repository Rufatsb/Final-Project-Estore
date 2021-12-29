using Estore.DAL;
using Estore.ViewModels.ProductViewModel;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace Estore.Controllers
{
    public class ProductController : Controller
    {
        private readonly AppDbContext _context;

        public ProductController(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            return View(
                  new ProductVM
                  {

                      Subscribe = await _context.Subscribes.FirstOrDefaultAsync(),
                      ShopMethods = await _context.ShopMethods.ToListAsync()



                  }
                );
        }

        public async Task<IActionResult> Productdetails()
        {
            return View();
        }
    }
}
