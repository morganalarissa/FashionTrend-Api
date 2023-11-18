using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fashionTrend.Application.UseCases.SupplierCases.DeleteSupplier
{
    public class DeleteContractValidator :
        AbstractValidator<DeleteContractRequest>
    {
        public DeleteContractValidator()
        {
            RuleFor(x => x.Id).NotEmpty();
        }
    }
}
