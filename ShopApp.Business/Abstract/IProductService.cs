﻿using ShopApp.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopApp.Business.Abstract
{
	public interface IProductService
	{
		Product GetById(int id);
		List<Product> GetAll();
		List<Product> GetPopulerProducts();
		void Create(Product entity);
		void Update(Product entity);
		void Delete(Product entity);
	}
}
