using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Abstract;
using Business.Concrete;
using DataAccess.Abstract;
using DataAccess.Concrete;
using Ninject.Modules;

namespace Business.DependencyResolvers.Ninject
{
	public class BusinessModule : NinjectModule
	{
		public override void Load()
		{
			Bind<IProductService>().To<ProductManager>().InSingletonScope();

			Bind<IProductDal>().To<EfProductDal>().InSingletonScope();

		}
	}
}
