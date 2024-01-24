using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopApp.Entities
{
	public class ProductCategory
	{
		[Key]
		public int Id { get; set; }

		[ForeignKey("CategoryId")]
		public int CategoryId { get; set; }

		public Category Category { get; set; }

		[ForeignKey("ProductId")]
		public int ProductId { get; set; }

		public Product Product { get; set; }
	}
}
