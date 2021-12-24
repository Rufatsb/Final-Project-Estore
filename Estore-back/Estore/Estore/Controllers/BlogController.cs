using Estore.DAL;
using Estore.ViewModels.BlogViewModel;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
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
            return View(
                   new BlogVM
                   {
                       InstagramFeeds = await _context.InstagramFeeds.ToListAsync(),
                       Posts = await _context.Posts.Include(p => p.PostCategories).ThenInclude(c => c.Category).ToListAsync(),
                     


                   }
                ) ;
        }

      

        public async Task<IActionResult> Blogdetails(int? Id)
        {
            if (Id == null)
            {
                return NotFound();
            }
           BlogVM blogVM = new BlogVM
            {
                Tags = await _context.Tags.ToListAsync(),
                Categories = await _context.Categories.ToListAsync(),
                Posts = await _context.Posts.ToListAsync(),
                InstagramFeeds = await _context.InstagramFeeds.ToListAsync()

            };
            if (!ModelState.IsValid)
            {
                return NotFound();

            }

            return View(blogVM);
        }
    }
}
