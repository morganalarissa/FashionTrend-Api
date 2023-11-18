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
    public class UpdateServiceHandler : IRequestHandler<UpdateServiceRequest, UpdateServiceResponse>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IServiceRepository _serviceRepository;
        private readonly IMapper _mapper;

        public UpdateServiceHandler(IUnitOfWork unitOfWork,
                                 IServiceRepository serviceRepository, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _serviceRepository = serviceRepository;
            _mapper = mapper;
        }
        public async Task<UpdateServiceResponse> Handle(UpdateServiceRequest command,
                                                     CancellationToken cancellationToken)
        {
            var service = await _serviceRepository.Get(command.Id, cancellationToken);

            if (service is null) return default;

            service.Description = command.Description;
            service.Delivery = command.Delivery;
            service.RequestType = command.RequestType;
            service.Materials = command.Materials;
            service.SewingMachines = command.SewingMachines;

            _serviceRepository.Update(service);

            await _unitOfWork.Commit(cancellationToken);

            return _mapper.Map<UpdateServiceResponse>(service);
        }
    }
}
