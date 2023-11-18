using AutoMapper;
using fashionTrend.Domain.Entities;
using fashionTrend.Domain.Interfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fashionTrend.Application.UseCases.ContractCases.CreateContract
{
    public class CreateContractHandler : IRequestHandler<CreateContractRequest, CreateContractResponse>
    {
        // unit of work
        private readonly IUnitOfWork _unitOfWork;
        // repository camada de dados
        private readonly IContractRepository _contractRepository;
        // mapper
        private readonly IMapper _mapper;


        public CreateContractHandler(IUnitOfWork unitOfWork, IContractRepository contractRepository,
            IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _contractRepository = contractRepository;
            _mapper = mapper;
        }

        public async Task<CreateContractResponse> Handle(CreateContractRequest request, CancellationToken cancellationToken)
        {
            // onde de fato vamos mandar as informações para os nossos bds
            var contract = _mapper.Map<Contract>(request);

            _contractRepository.Create(contract);

            // aqui chama o nosso controle transacional
            await _unitOfWork.Commit(cancellationToken);
            return _mapper.Map<CreateContractResponse>(contract);
        }
    }
}
