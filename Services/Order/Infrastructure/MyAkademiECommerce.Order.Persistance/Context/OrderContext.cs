using Microsoft.EntityFrameworkCore;
using MyAkademiECommerce.Order.Domain.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace MyAkademiECommerce.Order.Persistance.Context
{
    public class OrderContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=ABDULLAH,1450;database=ECommerceOrderDb;user=sa;password=123456aA*");
        }
        public DbSet<Ordering> Orderings { get; set; }
        public DbSet<Adress> Adresses { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }
    }
}
