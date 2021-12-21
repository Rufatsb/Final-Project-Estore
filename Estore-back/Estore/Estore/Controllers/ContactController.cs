using Estore.DAL;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace Estore.Controllers
{
    public class ContactController : Controller
    {
        private readonly AppDbContext _context;

        public ContactController(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            return View();
        }
    }
}
