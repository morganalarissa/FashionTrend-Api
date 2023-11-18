using AutoMapper;
using fashionTrend.Domain.Interfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fashionTrend.Application.UseCases.SupplierCases.DeleteSupplier
{
    public sealed class DeleteContractHandler : IRequestHandler<DeleteContractRequest, DeleteContractResponse>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IContractRepository _contractRepository;
        private readonly IMapper _mapper;

        public DeleteContractHandler(IUnitOfWork unitOfWork,
                                 IContractRepository contractRepository, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _contractRepository = contractRepository;
            _mapper = mapper;
        }

        public async Task<DeleteContractResponse> Handle(DeleteContractRequest request,
                                                     CancellationToken cancellationToken)
        {

            var contract = await _contractRepository.Get(request.Id, cancellationToken);

            if (contract == null) return default;

            _contractRepository.Delete(contract);
            await _unitOfWork.Commit(cancellationToken);

            return _mapper.Map<DeleteContractResponse>(contract);
        }
    }
}
