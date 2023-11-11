using AutoMapper;
using fashionTrend.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fashionTrend.Application.UseCases.CreateSupplier
{
    public class CreateServiceMapper : Profile
    {
        public CreateServiceMapper() 
        {
            CreateMap<CreateServiceRequest, Service>();
            CreateMap<Service, CreateServiceResponse>();
        }
    }
}
