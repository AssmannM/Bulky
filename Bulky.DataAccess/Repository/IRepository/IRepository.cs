using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Bulky.DataAccess.Repository.IRepository
{
	public interface IRepository<T> where T : class
	{
		// T - Category
		IEnumerable<T> GetAll();
		T Get(Expression<Func<T, bool>> filter);	//Definition to use LINQ expression 
		void Add(T entity);
		void Renove(T entity);
		void RemoveRange(IEnumerable<T> entity);	
	}
}
