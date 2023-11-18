using fashionTrend.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fashionTrend.Domain.Interfaces
{
    public interface IKafkaProducer
    {
        Task<Message> ProduceAsync(
            string topic, string sender, string receiver, string content);
    }
}
