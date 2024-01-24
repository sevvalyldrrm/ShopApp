using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
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
		public ShopContext(DbContextOptions<ShopContext> options) : base(options) {
		
		}
	

		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			if (!optionsBuilder.IsConfigured)
			{
				optionsBuilder.UseSqlServer("Data Source=DESKTOP-0LP7T25\\SQL2022;Initial Catalog=ShopApp;Persist Security Info=True;User ID=sa;Password=123;Trusted_Connection=True; TrustServerCertificate=Yes");
			}
		}

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
		//	modelBuilder.Entity<ProductCategory>().HasKey(c => new { c.CategoryId, c.ProductId });
		}

		public DbSet<Product> Products { get; set; }	

		public DbSet<Category> Categories { get; set; }

		public DbSet<ProductCategory> ProductCategories { get; set; }	

	}
}
