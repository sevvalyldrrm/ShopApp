using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using ShopApp.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopApp.DataAccess.Concrete.EfCore
{
	public class SeedData
	{

		public static void Seed(IApplicationBuilder app)
		{
			var context = app.ApplicationServices.CreateScope().ServiceProvider.GetService<ShopContext>();
			if (context != null)
			{

				if (context.Database.GetPendingMigrations().Count() == 0)
				{
					if (context.Categories.Count() == 0)
					{
						context.Categories.AddRange(Categories);
					}

					if (context.Products.Count() == 0)
					{
						context.Products.AddRange(Products);
					}
					context.SaveChanges();
				}

			}
		}
		private static Category[] Categories =
		{
			new Category(){Name="Telefon"},
			new Category(){Name="Bilgisayar"}
			};
		private static Product[] Products =
		{
			new Product(){Name="Samsung s5", Price=2000,ImageUrl="1.jpg"},
			new Product(){Name="Samsung s6", Price=3000,ImageUrl="2.jpg"},
			new Product(){Name="Samsung s7", Price=4000,ImageUrl="3.jpg"},
			new Product(){Name="Samsung s8", Price=5000,ImageUrl="4.jpg"},
			new Product(){Name="Samsung s9", Price=6000,ImageUrl="5.jpg"},
			new Product(){Name="Iphone 6", Price=7000,ImageUrl="6.jpg"},
			new Product(){Name="Iphone 7", Price=8000,ImageUrl="7.jpg"}
		};
	}
}
