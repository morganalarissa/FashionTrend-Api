using AutoMapper;
using fashionTrend.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fashionTrend.Application.UseCases.MessageCases.CreateMessage
{
    public class CreateMessageMapper : Profile
    {
        public CreateMessageMapper() 
        {
            CreateMap<CreateMessageRequest, Message>();
            CreateMap<Message, CreateMessageResponse>();
        }
    }
}
