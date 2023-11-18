using AutoMapper;
using fashionTrend.Domain.Interfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fashionTrend.Application.UseCases.SupplierCases.GetAllSupplier
{
    public sealed class GetAllContractHandler : IRequestHandler<GetAllContractRequest, List<GetAllContractResponse>>
    {
        private readonly IContractRepository _contractRepository;
        private readonly IMapper _mapper;

        public GetAllContractHandler(IContractRepository contractRepository, IMapper mapper)
        {
            _contractRepository = contractRepository;
            _mapper = mapper;
        }

        public async Task<List<GetAllContractResponse>> Handle(GetAllContractRequest request, CancellationToken cancellationToken)
        {
            var contracts = await _contractRepository.GetAll(cancellationToken);
            return _mapper.Map<List<GetAllContractResponse>>(contracts);
        }
    }
}
