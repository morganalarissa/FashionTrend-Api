﻿using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fashionTrend.Application.UseCases.SupplierCases.GetAllSupplier
{
    public sealed record GetAllServiceOrderRequest : IRequest<List<GetAllServiceOrderResponse>>;
}
