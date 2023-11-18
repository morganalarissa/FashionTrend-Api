using AutoMapper;
using fashionTrend.Domain.Interfaces;
using fashionTrend.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using fashionTrend.Application.UseCases.SupplierCases.CreateSupplier;

namespace fashionTrend.Application.UseCases.ServiceOrderCases.CreateServiceOrder
{
    public class CreateServiceOrderHandler : IRequestHandler<CreateServiceOrderRequest, CreateServiceOrderResponse>
    {
        // unit of work
        private readonly IUnitOfWork _unitOfWork;
        // repository camada de dados
        private readonly IServiceOrderRepository _serviceOrderRepository;
        // mapper
        private readonly IMapper _mapper;


        public CreateServiceOrderHandler(IUnitOfWork unitOfWork, IServiceOrderRepository serviceOrderRepository,
            IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _serviceOrderRepository = serviceOrderRepository;
            _mapper = mapper;
        }

        public async Task<CreateServiceOrderResponse> Handle(CreateServiceOrderRequest request, CancellationToken cancellationToken)
        {
            // onde de fato vamos mandar as informações para os nossos bds
            var serviceOrder = _mapper.Map<ServiceOrder>(request);

            _serviceOrderRepository.Create(serviceOrder);

            // aqui chama o nosso controle transacional
            await _unitOfWork.Commit(cancellationToken);
            return _mapper.Map<CreateServiceOrderResponse>(serviceOrder);
        }

    }
}
