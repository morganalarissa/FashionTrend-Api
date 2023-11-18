using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fashionTrend.Application.UseCases.SupplierCases.GetAllSupplier
{
    public class GetAllContractValidator : AbstractValidator<GetAllSupplierRequest>
    {
        public GetAllContractValidator()
        {
            //sem validação    
        }
    }
}
