﻿using fashionTrend.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fashionTrend.Application.UseCases.SupplierCases.UpdateSupplier
{

    public sealed record UpdateServiceOrderResponse
    {
        public Guid Id { get; set; }
        public Guid SupplierId { get; set; }
        public Guid ServiceId { get; set; }
        public DateTimeOffset EstimatedDate { get; set; }
        public ERequestStatus RequestStatus { get; set; }
    }
}
