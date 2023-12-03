using AutoMapper;
using fashionTrend.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fashionTrend.Application.UseCases.DraftContractCases
{
    public class AcceptedDraftContractMapper : Profile
    {
        public AcceptedDraftContractMapper()
        {
            CreateMap<AcceptedDraftContractRequest, DraftContract>();
            CreateMap<DraftContract, AcceptedDraftContractResponse>();
        }
    }
}
