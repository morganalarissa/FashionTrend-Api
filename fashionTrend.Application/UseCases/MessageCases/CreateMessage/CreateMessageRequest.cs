using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fashionTrend.Application.UseCases.MessageCases.CreateMessage
{
    public sealed record CreateMessageRequest(
        string topic, string sender, string receiver, string content) : IRequest<CreateMessageResponse>;

}
