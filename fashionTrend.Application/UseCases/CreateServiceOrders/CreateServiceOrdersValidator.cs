using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentValidation;

namespace fashionTrend.Application.UseCases.CreateUser
{
    public sealed class CreateServiceOrdersValidator : AbstractValidator<CreateServiceOrdersRequest>
    {
        public CreateServiceOrdersValidator() 
        {
            //RuleFor(x => x.Email).NotEmpty().MaximumLength(50).EmailAddress();
           // RuleFor(x => x.Name).NotEmpty().MinimumLength(3).MaximumLength(50);
        }

    }
}
