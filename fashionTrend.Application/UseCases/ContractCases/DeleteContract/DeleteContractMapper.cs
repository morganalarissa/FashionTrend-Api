using AutoMapper;
using fashionTrend.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fashionTrend.Application.UseCases.SupplierCases.DeleteSupplier
{
    public sealed class DeleteContractMapper : Profile
    {
        public DeleteContractMapper()
        {
            CreateMap<DeleteContractRequest, Contract>();
            CreateMap<Contract, DeleteContractResponse>();
        }
    }
}
