using Microsoft.EntityFrameworkCore;
using Foody.EntityLayer.Concrete;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Foody.DataAccessLayer.Context
{
    public class FoodyContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
           // optionsBuilder.UseSqlServer("Data Source=SAP93-01;Initial Catalog=FoodyTekmerDb;User ID=sa;Password=KD93p.dQmke!");
            optionsBuilder.UseSqlServer("Server=SAP93-01;initial catalog=FoodyTekmerDb;integrated security=true");
     
           
        }
        public DbSet<About> Abouts { get; set; }
        public DbSet<Address> Addresses { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Feature> Features { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Review> Reviews { get; set; }
        public DbSet<Slider> Sliders { get; set; }
        public DbSet<SocialMedia> SocialMedias { get; set; }


    } 
}
