using Castle.DynamicProxy;
using Core.CrossCuttingConserns.Validation;
using Core.Utilities.Interceptors;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Aspects.Autofac.Validation
{
    // 
    public class ValidationAspect : MethodInterception
    {
        private Type _validatorType;
        public ValidationAspect(Type validatorType)
        {
            // gonderilen validatorType bir IValidator değilse hata versin
            if (!typeof(IValidator).IsAssignableFrom(validatorType))
            {
                throw new System.Exception("bu bir doğrulama sınıfı degil");
            }
            _validatorType = validatorType;
        }

        protected override void OnBefore(IInvocation invocation)
        {
            // reflection -- çalışma anında birşeyleri calıştırmamızı sağlıyor
            var validator = (IValidator)Activator.CreateInstance(_validatorType);

            // validatorun base tipini bul(abstractvalidator), generic argumanlarına bak sıfırıncısını al
            var entityType = _validatorType.BaseType.GetGenericArguments()[0];

            // invocation -- method
            // validatoru attribude olarak kullandıgımız methodun argumanlarının tiplerinin entitiType ile eşleşenleri getir 
            var entities = invocation.Arguments.Where(t => t.GetType() == entityType);
            foreach (var entity in entities)
            {
                ValidationTool.Validate(validator, entity);
            }
        }
    }
}
