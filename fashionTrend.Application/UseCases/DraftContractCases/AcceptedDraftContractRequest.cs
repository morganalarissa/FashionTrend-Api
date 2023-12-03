using fashionTrend.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fashionTrend.Application.UseCases.DraftContractCases
{
    public sealed record AcceptedDraftContractRequest(
        Guid Id, DraftContract Draft, bool Accepted
        ) : IRequest<AcceptedDraftContractResponse>;





    /*
     * public TypePolicy TypePolicy { get; set; }
        public UserPerfil UserPerfil { get; set; }
        public bool ApplyDiscount { get; set; }
        public double ValueDiscount { get; set; }
        public double ValueCashback { get; set; }
    **/
}
