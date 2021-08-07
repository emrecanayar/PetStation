using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Core.Entities.Abstract;

namespace Core.DataAccess
{
	//Veritabanına erişmek için ve verilerle istediğim gibi işlem yapabilmek için.


	public interface IEntityRepository<T> where T : class, IEntity, new()
	{
		T Get(Expression<Func<T, bool>> filter);

		List<T> GetList(Expression<Func<T, bool>> filter = null);

		void Add(T entity);

		void Update(T entity);

		void Delete(T entity);
	}
}
