using FluentValidation;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ValidationException = FluentValidation.ValidationException;

namespace Core.CrossCuttingConcerns.Validation
{
    public class ValidationTool
    {
        //bu tip araçlar static oluşturlur 
        public static void Validate(IValidator validator, object entity)
        {
            var context = new ValidationContext<object>(entity); //product için doğrulama yapılacak
            var result = validator.Validate(context);//context yani product
            if (!result.IsValid)
            {
                throw new ValidationException(result.Errors);//geçersizse hata fırlatır
            }
        }
    }
}
