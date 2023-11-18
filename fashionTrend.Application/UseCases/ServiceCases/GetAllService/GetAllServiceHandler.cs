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
    public sealed class GetAllServiceHandler : IRequestHandler<GetAllServiceRequest, List<GetAllServiceResponse>>
    {
        private readonly IServiceRepository _serviceRepository;
        private readonly IMapper _mapper;

        public GetAllServiceHandler(IServiceRepository serviceRepository, IMapper mapper)
        {
            _serviceRepository = serviceRepository;
            _mapper = mapper;
        }

        public async Task<List<GetAllServiceResponse>> Handle(GetAllServiceRequest request, CancellationToken cancellationToken)
        {
            var services = await _serviceRepository.GetAll(cancellationToken);
            return _mapper.Map<List<GetAllServiceResponse>>(services);
        }
    }
}
