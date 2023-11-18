using AutoMapper;
using fashionTrend.Application.UseCases.SupplierCases.DeleteSupplier;
using fashionTrend.Domain.Interfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fashionTrend.Application.UseCases.ServiceCases.DeleteService
{
    public sealed class DeleteServiceHandler : IRequestHandler<DeleteServiceRequest, DeleteServiceResponse>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IServiceRepository _serviceRepository;
        private readonly IMapper _mapper;

        public DeleteServiceHandler(IUnitOfWork unitOfWork,
                                 IServiceRepository serviceRepository, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _serviceRepository = serviceRepository;
            _mapper = mapper;
        }

        public async Task<DeleteServiceResponse> Handle(DeleteServiceRequest request,
                                                     CancellationToken cancellationToken)
        {

            var service = await _serviceRepository.Get(request.Id, cancellationToken);

            if (service == null) return default;

            _serviceRepository.Delete(service);
            await _unitOfWork.Commit(cancellationToken);

            return _mapper.Map<DeleteServiceResponse>(service);
        }
    }
}
