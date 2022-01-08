using Estore.DAL;
using Estore.Models;
using Estore.ViewModels.BasketViewModel;
using Estore.ViewModels.ProductViewModel;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
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
                      ShopMethods = await _context.ShopMethods.ToListAsync(),
                      Products = await _context.Products.Include(p=>p.Productimages).ToListAsync(),
                      ProductCategories = await _context.ProductCategories.ToListAsync()



                  }
                );
        }

        public async Task<IActionResult> Productdetails(int? Id)
        {
            if (Id == null)
            {
                return NotFound();
            }
            if (await _context.Products.FindAsync(Id) == null)
            {
                return BadRequest();
            }
            Product product = await _context.Products.Include(p=>p.Productimages)
              .FirstOrDefaultAsync(p => p.Id == Id);
           


            ProductVM productVM = new ProductVM
            {
                Product = await _context.Products.Include(p=>p.Productimages).FirstOrDefaultAsync(p=>p.Id==Id),
                Subscribe = await _context.Subscribes.FirstOrDefaultAsync(),
                //BasketVM  = new BasketVM
                //{
                //    Id = (int)Id,
                //    Title = product.Name,
                //    MainImage = product.Productimages.FirstOrDefault().Img,
                //    Price = product.Price,
                //    Count = 1
                //}


                 


        };


            if (!ModelState.IsValid)
            {
                return NotFound();

            }

            return View(productVM);
        }


    }
}
