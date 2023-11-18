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
    public class UpdateServiceOrderHandler : IRequestHandler<UpdateServiceOrderRequest, UpdateServiceOrderResponse>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IServiceOrderRepository _serviceOrderRepository;
        private readonly IMapper _mapper;

        public UpdateServiceOrderHandler(IUnitOfWork unitOfWork,
                                 IServiceOrderRepository serviceOrderRepository, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _serviceOrderRepository = serviceOrderRepository;
            _mapper = mapper;
        }
        public async Task<UpdateServiceOrderResponse> Handle(UpdateServiceOrderRequest command,
                                                     CancellationToken cancellationToken)
        {
            var serviceOrder = await _serviceOrderRepository.Get(command.Id, cancellationToken);

            if (serviceOrder is null) return default;

            serviceOrder.SupplierId = command.SupplierId;
            serviceOrder.ServiceId = command.ServiceId;
            serviceOrder.EstimatedDate = command.EstimatedDate;
            serviceOrder.RequestStatus = command.RequestStatus;

            _serviceOrderRepository.Update(serviceOrder);

            await _unitOfWork.Commit(cancellationToken);

            return _mapper.Map<UpdateServiceOrderResponse>(serviceOrder);
        }
    }
}
