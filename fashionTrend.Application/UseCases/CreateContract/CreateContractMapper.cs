using AutoMapper;
using fashionTrend.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fashionTrend.Application.UseCases.CreateUser
{
    public class CreateContractMapper : Profile
    {
        public CreateContractMapper()
        {
            CreateMap<CreateContractRequest, Contract>();
            CreateMap<Contract, CreateContractResponse>();
        }
    }
}
