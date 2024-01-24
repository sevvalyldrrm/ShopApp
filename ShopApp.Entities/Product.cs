using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopApp.Entities
{
	public class Product
	{
		public int ProductId { get; set; }	

		public string Name { get; set; }

		public string ImageUrl { get; set; }

		public decimal Price { get; set; }

		public virtual ICollection<ProductCategory> ProductCategories { get; set; }
	}
}
