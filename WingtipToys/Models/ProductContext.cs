using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity; // necessario instalar via gerenciador de pacotes

namespace WingtipToys.Models
{
    // Unica classe responsavel pelo acesso ao banco de dados diretamente. acesso feito com Entity Framework
    public class ProductContext : DbContext
    {
        public ProductContext() : base("WingtipToys")
        {
        }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<CartItem> ShoppingCartItems { get; set; }
    }
}