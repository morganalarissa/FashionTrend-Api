using AutoMapper;
using fashionTrend.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fashionTrend.Application.UseCases.DraftContractCases
{
    public class CreateDraftContractMapper : Profile
    {
        public CreateDraftContractMapper()
        {
            CreateMap<CreateDraftContractRequest, DraftContract>();
            CreateMap<DraftContract, CreateDraftContractResponse>();
        }
    }
}
