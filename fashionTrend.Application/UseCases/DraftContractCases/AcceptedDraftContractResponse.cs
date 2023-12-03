using fashionTrend.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fashionTrend.Application.UseCases.DraftContractCases
{
    public sealed record AcceptedDraftContractResponse
    {
        public Guid Id { get; set; }
        public DraftContract Draft { get; set; }
        public bool Accepted { get; set; }
    }
}
