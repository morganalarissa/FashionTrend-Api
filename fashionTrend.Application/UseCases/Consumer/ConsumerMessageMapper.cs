using AutoMapper;
using fashionTrend.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fashionTrend.Application.UseCases.Consumer
{
    public class ConsumerMessageMapper : Profile
    {
        public ConsumerMessageMapper()
        {
            CreateMap<ConsumerMessageRequest, MessageReceivedEventArgs>();
        }
    }
}
