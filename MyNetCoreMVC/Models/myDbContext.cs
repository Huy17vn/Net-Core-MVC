using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyNetCoreMVC.Models
{
    public class myDbContext: DbContext
    {
        public myDbContext(DbContextOptions<myDbContext> options)
            :base(options)
        {

        }
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
    }
    public class Category
    {
        public long id { get; set; }
        public string name { get; set; }
        public string price { get; set; }
    }
    public class Product
    {
        public long id { get; set; }
        public string name { get; set; }
        public int price { get; set; }
    }
}
