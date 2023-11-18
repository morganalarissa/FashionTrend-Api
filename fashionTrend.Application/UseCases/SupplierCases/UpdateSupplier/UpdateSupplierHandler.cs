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
    public class UpdateSupplierHandler : IRequestHandler<UpdateSupplierRequest, UpdateSupplierResponse>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly ISupplierRepository _supplierRepository;
        private readonly IMapper _mapper;

        public UpdateSupplierHandler(IUnitOfWork unitOfWork,
                                 ISupplierRepository supplierRepository, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _supplierRepository = supplierRepository;
            _mapper = mapper;
        }
        public async Task<UpdateSupplierResponse> Handle(UpdateSupplierRequest command,
                                                     CancellationToken cancellationToken)
        {
            var supplier = await _supplierRepository.Get(command.Id, cancellationToken);

            if (supplier is null) return default;

            supplier.Name = command.Name;
            supplier.Email = command.Email;

            _supplierRepository.Update(supplier);

            await _unitOfWork.Commit(cancellationToken);

            return _mapper.Map<UpdateSupplierResponse>(supplier);
        }
    }
}
