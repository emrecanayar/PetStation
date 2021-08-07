using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities.Concrete;

namespace DataAccess.Concrete.EntityFramework
{
	public class PetStationContext : DbContext
	{
		public DbSet<Product> Products { get; set; }
	}
}
