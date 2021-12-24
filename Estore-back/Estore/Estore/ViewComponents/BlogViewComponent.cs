﻿using Estore.DAL;
using Estore.Models;
using Estore.ViewModels.BlogViewModel;
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

            return View(await Task.FromResult(

                new BlogVM
                {
                    Tags = await _context.Tags.ToListAsync(),
                    Categories = await _context.Categories.ToListAsync(),
                    Posts = await _context.Posts.ToListAsync(),
                    InstagramFeeds = await _context.InstagramFeeds.ToListAsync()

                }
                )) ;

        }
    }
}
