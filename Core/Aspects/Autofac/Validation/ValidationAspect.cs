using Castle.DynamicProxy;
using Core.CrossCuttingConcerns.Validation;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using static Core.Utilities.Interceptors.Class1;

namespace Core.Aspects.Autofac.Validation
{
    public class ValidationAspect : MethodInterception
    {
        private Type _validatorType;
        public ValidationAspect(Type validatorType)
        {
            //defensive coding
            if (!typeof(IValidator).IsAssignableFrom(validatorType))// validatorType bir IValidator değilse hata verir
            {
                throw new System.Exception("Bu doğrulama sınıfı değil");
            }

            _validatorType = validatorType;
        }
        protected override void OnBefore(IInvocation invocation)
        {
            var validator = (IValidator)Activator.CreateInstance(_validatorType); // productValidator ün bir instanceini oluştur (Reflection)
            var entityType = _validatorType.BaseType.GetGenericArguments()[0];//productVslidstörün çslışms tipini bul (BaseType--> AbstractValidator) (EntityType->product)
            var entities = invocation.Arguments.Where(t => t.GetType() == entityType);//metotun(invocation) parametrelerini bul entityType a denk gelenleri bul
            foreach (var entity in entities)
            {
                ValidationTool.Validate(validator, entity);// her birini tek tek gez ValidationTool ile validate et
            }
        }
    }
}
