using Estore.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
namespace Estore.DAL
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

                
    }
        public virtual DbSet<Banner> Banners { get; set; }
        public virtual DbSet<AboutText> AboutTexts { get; set; }
        public virtual DbSet<AboutVideo> AboutVideos { get; set; }
        public virtual DbSet<AboutShopInfo> AboutShopInfos { get; set; }
        public virtual DbSet<AboutShopItem> AboutShopItems { get; set; }
        public virtual DbSet<Subscribe> Subscribes { get; set; }















    }

}