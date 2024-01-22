using Microsoft.EntityFrameworkCore;
using ShopApp.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ShopApp.DataAccess.Abstract
{
	public interface IGenericRepository<T> where T : class 
	{
		T GetById(int id);
		T GetOne(Expression<Func<T, bool>> filter);
		IEnumerable<T> GetAll(Expression<Func<T, bool>> filter = null);

		void Create(T entity);
		void Update(T entity);
		void Delete(T entity);
	}
}
