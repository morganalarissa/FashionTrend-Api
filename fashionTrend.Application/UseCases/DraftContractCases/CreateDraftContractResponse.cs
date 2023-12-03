using fashionTrend.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fashionTrend.Application.UseCases.DraftContractCases
{
    public sealed record CreateDraftContractResponse
    {
        public Guid Id { get; set; }
        public string Description { get; set; }

    }
}
