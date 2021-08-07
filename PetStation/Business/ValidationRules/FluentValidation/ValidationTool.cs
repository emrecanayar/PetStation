using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentValidation;

namespace Business.ValidationRules.FluentValidation
{
	public class ValidationTool
	{

		public static void Validate(IValidator validator, object entity)
		{
			ProductValidator productValidator = new ProductValidator();
			var context = new ValidationContext<object>(entity);
			var result = validator.Validate(context);
			if (result.Errors.Count > 0)
			{
				throw new ValidationException(result.Errors);
			}

		}


	}
}
