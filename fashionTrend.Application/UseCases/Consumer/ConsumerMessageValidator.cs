using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fashionTrend.Application.UseCases.Consumer
{
    public sealed class ConsumerMessageValidator : AbstractValidator<ConsumerMessageRequest>
    {
        public ConsumerMessageValidator()
        {
            RuleFor(x => x.topic).NotEmpty();
            RuleFor(x => x.group).NotEmpty();
        }
    }
}
