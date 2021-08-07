using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Entities.Abstract;

namespace Entities.Concrete
{
	public class Product : IEntity
	{
		public int Id { get; set; }
		public string ProductName { get; set; }
		public decimal Price { get; set; }
		public int Quantity { get; set; }
		public int CategoryId { get; set; }

	}
}

