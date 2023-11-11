using AutoMapper;
using fashionTrend.Domain.Entities;
using fashionTrend.Domain.Interfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fashionTrend.Application.UseCases.CreateUser
{
    public class CreateServiceOrdersHandler : IRequestHandler<CreateServiceOrdersRequest, CreateServiceOrdersResponse>
    {
        // unit of work
        private readonly IUnitOfWork _unitOfWork;
        // repository camada de dados
        private readonly IServiceOrderRepository _serviceOrdersRepository;
        // mapper
        private readonly IMapper _mapper;


        public CreateServiceOrdersHandler(IUnitOfWork unitOfWork, IServiceOrderRepository serviceOrdersRepository,
            IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _serviceOrdersRepository = serviceOrdersRepository;
            _mapper = mapper;
        }

        public async Task<CreateServiceOrdersResponse> Handle(CreateServiceOrdersRequest request, CancellationToken cancellationToken)
        {
            // onde de fato vamos mandar as informações para os nossos bds
            var serviceOrders = _mapper.Map<ServiceOrder>(request);

            _serviceOrdersRepository.Create(serviceOrders);

            // aqui chama o nosso controle transacional
            await _unitOfWork.Commit(cancellationToken);
            return _mapper.Map<CreateServiceOrdersResponse>(serviceOrders);
        }
    }
}
