using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities.Concrete;
using FluentValidation;

namespace Business.ValidationRules.FluentValidation
{
	public class ProductValidator : AbstractValidator<Product>
	{
		public ProductValidator()
		{
			RuleFor(p => p.ProductName).NotEmpty().WithMessage("Ürün adı boş geçilemez.");
			RuleFor(p => p.Price).NotEmpty().WithMessage("Fiyat boş geçilemez.");
			RuleFor(p => p.Price).GreaterThan(0).WithMessage("Fiyat 0 dan büyük olmalıdır.");
			
		}
	}
}
