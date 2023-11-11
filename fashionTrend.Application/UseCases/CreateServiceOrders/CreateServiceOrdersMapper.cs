using AutoMapper;
using fashionTrend.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fashionTrend.Application.UseCases.CreateUser
{
    public class CreateServiceOrdersMapper : Profile
    {
        public CreateServiceOrdersMapper()
        {
            CreateMap<CreateServiceOrdersRequest, ServiceOrder>();
            CreateMap<ServiceOrder, CreateServiceOrdersResponse>();
        }
    }
}
