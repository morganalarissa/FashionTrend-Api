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
    public sealed class GetAllSupplierHandler : IRequestHandler<GetAllSupplierRequest, List<GetAllSupplierResponse>>
    {
        private readonly ISupplierRepository _supplierRepository;
        private readonly IMapper _mapper;

        public GetAllSupplierHandler(ISupplierRepository supplierRepository, IMapper mapper)
        {
            _supplierRepository = supplierRepository;
            _mapper = mapper;
        }

        public async Task<List<GetAllSupplierResponse>> Handle(GetAllSupplierRequest request, CancellationToken cancellationToken)
        {
            var suppliers = await _supplierRepository.GetAll(cancellationToken);
            return _mapper.Map<List<GetAllSupplierResponse>>(suppliers);
        }
    }
}
