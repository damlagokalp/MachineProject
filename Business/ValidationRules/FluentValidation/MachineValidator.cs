using Entities.Concrete;
using FluentValidation;//AbstractValidatör buradan gelir
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.ValidationRules.FluentValidation
{
    public  class MachineValidator :AbstractValidator<Machine>
    {
        //kurallar yazılır
        public MachineValidator() { 
        
            RuleFor(m=>m.MachineName).NotEmpty();
            RuleFor(m => m.MachineName).MinimumLength(2);
            RuleFor(m => m.Description).NotEmpty();
            RuleFor(m => m.MachineId).GreaterThanOrEqualTo(5).When(m => m.BrandId == 2);
            RuleFor(m => m.MachineName).Must(StarWithA).WithMessage("Makineler A ile başlamalı");
        }

        private bool StarWithA(string arg)//olşturulan kural
        {
            return arg.StartsWith("A");// A ile başlarsa true döner
        }
    }
}
