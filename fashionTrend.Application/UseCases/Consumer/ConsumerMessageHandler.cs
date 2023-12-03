﻿using AutoMapper;
using fashionTrend.Domain.Interfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fashionTrend.Application.UseCases.Consumer
{
    public class ConsumerMessageHandler : IRequestHandler<ConsumerMessageRequest, string>
    {
        // repository camada de dados
        private readonly IKafkaConsumer _kafkaConsumer;
        // mapper
        private readonly IMapper _mapper;


        public ConsumerMessageHandler(IKafkaConsumer kafkaConsumer,
            IMapper mapper)
        {
            _kafkaConsumer = kafkaConsumer;
            _mapper = mapper;
        }

        public async Task<string> Handle(ConsumerMessageRequest request, CancellationToken cancellationToken)
        {
            _kafkaConsumer.Subscribe(request.topic, request.group);
            await _kafkaConsumer.StartConsumingAsync(cancellationToken);

            return _mapper.Map<string>("OK");
        }
    }
}
