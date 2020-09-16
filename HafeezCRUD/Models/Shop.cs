using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace HafeezCRUD.Models
{
    public class Shop
    {
        public int Shopid { get; set; }
        public string Name { get; set; }
        public string ItemName { get; set; }
        public int Itemquantity { get; set; }
        public decimal Price { get; set; }
    }
    public class ShopDBContext : DbContext
    {
        public DbSet<Shop> Shops { get; set; }
    }
}