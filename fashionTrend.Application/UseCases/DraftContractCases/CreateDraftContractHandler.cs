using AutoMapper;
using fashionTrend.Application.UseCases.Notifications;
using fashionTrend.Domain.Entities;
using fashionTrend.Domain.Interfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fashionTrend.Application.UseCases.DraftContractCases
{
    public class CreateDraftContractHandler : IRequestHandler<CreateDraftContractRequest, CreateDraftContractResponse>
    {
        // unit of work
        private readonly IUnitOfWork _unitOfWork;
        // repository camada de dados
        private readonly IDraftContractRepository _draftRepository;
        // mapper
        private readonly IMapper _mapper;
        private readonly IKafkaProducer _kafkaRepository;


        public CreateDraftContractHandler(IUnitOfWork unitOfWork,
            IDraftContractRepository draftRepository,
            IMapper mapper, IKafkaProducer kafkaRepository)
        {
            _unitOfWork = unitOfWork;
            _draftRepository = draftRepository;
            _mapper = mapper;
            _kafkaRepository = kafkaRepository;
        }

        public async Task<CreateDraftContractResponse> Handle(CreateDraftContractRequest request, CancellationToken cancellationToken)
        {
            var draft = _mapper.Map<DraftContract>(request);

            _draftRepository.Create(draft);

            await _unitOfWork.Commit(cancellationToken);


            var notification = new CreateNotificationHandle("" +
              "AC75571acac49b3f579f84783c6424b30c", "9d878982a53a1ae789e255bfa57e1c3e", "+15136573572");

            notification.SendSms("+5511966306842", "minuta de contrato criada");

            return _mapper.Map<CreateDraftContractResponse>(draft);
        }
    }
}
