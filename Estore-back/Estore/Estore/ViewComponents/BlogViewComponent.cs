using Estore.DAL;
using Estore.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;
namespace Estore.ViewComponents
{
    public class BlogViewComponent:ViewComponent
    {
        private readonly AppDbContext _context;

        public BlogViewComponent(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IViewComponentResult> InvokeAsync(string title)
        {
            Banner banner = await _context.Banners.FirstOrDefaultAsync();
            banner.Title = title;
            return View(await Task.FromResult(banner));

        }
    }
}
