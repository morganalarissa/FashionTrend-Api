using AutoMapper;
using fashionTrend.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fashionTrend.Application.UseCases.SupplierCases.GetAllSupplier
{
    public sealed class GetAllSupplierMapper : Profile
    {
        public GetAllSupplierMapper()
        {
            CreateMap<Supplier, GetAllSupplierResponse>();
        }
    }
}
