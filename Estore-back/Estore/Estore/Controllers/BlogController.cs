using Estore.DAL;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace Estore.Controllers
{
    public class BlogController : Controller
    {
        private readonly AppDbContext _context;

        public BlogController(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            return View();
        }

        public async Task<IActionResult> Blogdetails()
        {
            return View();
        }
    }
}
