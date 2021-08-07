using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Abstract;
using Business.DependencyResolvers.Ninject;
using Business.ValidationRules.FluentValidation;
using DataAccess.Abstract;
using Entities.Concrete;

namespace Business.Concrete
{
	public class ProductManager : IProductService
	{
		private IProductDal _productDal;

		public ProductManager(IProductDal productDal)
		{
			_productDal = productDal;
		}

		public void Add(Product product)
		{
			ValidationTool.Validate(new ProductValidator(), product);
			_productDal.Add(product);
		}

		public List<Product> GetList()
		{
			return _productDal.GetList();
		}

		public void Delete(Product product)
		{
			_productDal.Delete(product);
		}

		public void Update(Product product)
		{
			ValidationTool.Validate(new ProductValidator(), product);
			_productDal.Update(product);
		}
	}
}
