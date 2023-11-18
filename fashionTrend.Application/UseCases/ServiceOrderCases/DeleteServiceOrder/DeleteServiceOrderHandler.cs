using AutoMapper;
using fashionTrend.Domain.Entities;
using fashionTrend.Domain.Interfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fashionTrend.Application.UseCases.SupplierCases.DeleteSupplier
{
    public sealed class DeleteServiceOrderHandler : IRequestHandler<DeleteServiceOrderRequest, DeleteServiceOrderResponse>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IServiceOrderRepository _serviceOrderRepository;
        private readonly IMapper _mapper;

        public DeleteServiceOrderHandler(IUnitOfWork unitOfWork,
                                 IServiceOrderRepository serviceOrderRepository, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _serviceOrderRepository = serviceOrderRepository;
            _mapper = mapper;
        }

        public async Task<DeleteServiceOrderResponse> Handle(DeleteServiceOrderRequest request,
                                                     CancellationToken cancellationToken)
        {

            var serviceOrder = await _serviceOrderRepository.Get(request.Id, cancellationToken);

            if (serviceOrder == null) return default;

            _serviceOrderRepository.Delete(serviceOrder);
            await _unitOfWork.Commit(cancellationToken);

            return _mapper.Map<DeleteServiceOrderResponse>(serviceOrder);
        }
    }
}
