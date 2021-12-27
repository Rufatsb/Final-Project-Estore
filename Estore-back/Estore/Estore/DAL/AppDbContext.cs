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
        public virtual DbSet<Testimonial> Testimonials { get; set; }
        public virtual DbSet<BlogComments> BlogComments { get; set; }
        public virtual DbSet<BlogWriter> BlogWriters { get; set; }
        public virtual DbSet<Category> Categories { get; set; }
        public virtual DbSet<InstagramFeed> InstagramFeeds { get; set; }
        public virtual DbSet<Post> Posts { get; set; }
        public virtual DbSet<PostCategories> PostCategories { get; set; }
        public virtual DbSet<PostTags> PostTags { get; set; }
        public virtual DbSet<Tags> Tags { get; set; }
        public virtual DbSet<BlogSubscribe> BlogSubscribes { get; set; }
        public virtual DbSet<Map> Maps { get; set; }
        public virtual DbSet<ContactInfo> ContactInfos { get; set; }
        public virtual DbSet<Gallery> Galleries { get; set; }
        public virtual DbSet<ShopMethod> ShopMethods { get; set; }


















    }

}