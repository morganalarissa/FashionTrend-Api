using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentValidation;

namespace fashionTrend.Application.UseCases.CreateUser
{
    public sealed class CreateContractValidator : AbstractValidator<CreateContractRequest>
    {
        public CreateContractValidator() 
        {
            //RuleFor(x => x.Email).NotEmpty().MaximumLength(50).EmailAddress();
           // RuleFor(x => x.Name).NotEmpty().MinimumLength(3).MaximumLength(50);
        }

    }
}
