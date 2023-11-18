using AutoMapper;
using fashionTrend.Domain.Interfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace fashionTrend.Application.UseCases.MessageCases.CreateMessage
{
    public class CreateMessageHandler : IRequestHandler<CreateMessageRequest, CreateMessageResponse>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IKafkaProducer _kafkaRepository;
        private readonly IMapper _mapper;
        public CreateMessageHandler(IUnitOfWork unitOfWork,IKafkaProducer kafkaRepository, IMapper mapper) 
        {         
            _unitOfWork = unitOfWork;
            _kafkaRepository = kafkaRepository;
            _mapper = mapper;
        }
        public async Task<CreateMessageResponse> Handle(CreateMessageRequest request, CancellationToken cancellationToken)
        {
            var message = await _kafkaRepository.ProduceAsync(
                request.topic,
                request.sender,
                request.receiver,
                request.content);

            await _unitOfWork.Commit(cancellationToken);
            return _mapper.Map<CreateMessageResponse>(message);

        }
    }
}
