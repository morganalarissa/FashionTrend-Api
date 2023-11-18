using AutoMapper;
using fashionTrend.Domain.Entities;
using fashionTrend.Domain.Interfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fashionTrend.Application.UseCases.SupplierCases.UpdateSupplier
{
    public class UpdateContractHandler : IRequestHandler<UpdateContractRequest, UpdateContractResponse>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IContractRepository _contractRepository;
        private readonly IMapper _mapper;

        public UpdateContractHandler(IUnitOfWork unitOfWork,
                                 IContractRepository contractRepository, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _contractRepository = contractRepository;
            _mapper = mapper;
        }
        public async Task<UpdateContractResponse> Handle(UpdateContractRequest command,
                                                     CancellationToken cancellationToken)
        {
            var contract = await _contractRepository.Get(command.Id, cancellationToken);

            if (contract is null) return default;

            contract.OrderId = command.OrderId;
            contract.SupplierId = command.SupplierId;
            contract.StartDate = command.StartDate;
            contract.EndDate = command.EndDate;

            _contractRepository.Update(contract);

            await _unitOfWork.Commit(cancellationToken);

            return _mapper.Map<UpdateContractResponse>(contract);
        }
    }
}
