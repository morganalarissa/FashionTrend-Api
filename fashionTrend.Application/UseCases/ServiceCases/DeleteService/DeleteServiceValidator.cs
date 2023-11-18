using fashionTrend.Application.UseCases.SupplierCases.DeleteSupplier;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fashionTrend.Application.UseCases.ServiceCases.DeleteService
{
    public class DeleteServiceValidator :
        AbstractValidator<DeleteServiceRequest>
    {
        public DeleteServiceValidator()
        {
            RuleFor(x => x.Id).NotEmpty();
        }
    }
}
