using Microsoft.EntityFrameworkCore;
using ShopApp.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopApp.DataAccess.Concrete.EfCore
{
	public class ShopContext:DbContext
	{
		public ShopContext() { }
		public ShopContext(DbContextOptions<ShopContext> options) : base(options) { }


		public DbSet<Product> Products { get; set; }	

		public DbSet<Category> Categories { get; set; }

		public DbSet<Order>	Orders { get; set; }

		public DbSet<OrderLine> OrderLines { get; set; }
	}
}
