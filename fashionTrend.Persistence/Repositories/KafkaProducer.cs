using Confluent.Kafka;
using fashionTrend.Domain.Entities;
using fashionTrend.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace fashionTrend.Persistence.Repositories
{
    public class KafkaProducer : IKafkaProducer
    {
        private readonly IProducer<string, string> _producer;
        public KafkaProducer()
        {
            //configuração do servidor local do cluster do kafka
            var config = new ProducerConfig
            {
                BootstrapServers = "localhost: 9092", // Endereço do servidor do kafka
            };
            // adicionando ao produtor o servidor do kafka
            _producer = new ProducerBuilder<string, string>(config).Build();
        }
        public async Task<Message> ProduceAsync(string topic, string sender, string receiver, string content)
        {
            var message = new Message
            {
                Id = Guid.NewGuid(),
                Sender = sender,
                Receiver = receiver,
                Content = content,
                Timestamp = DateTime.UtcNow,
                Status = "em processamento"
            };

            // Serializar a mensagem
            string serielizedMessage = JsonSerializer.Serialize(message);

            // Chamar o metodo que produz a mensagem do confluent kafka
            var deliveryReport = await _producer.ProduceAsync(topic, new Message<string, string>
            {
                Value = serielizedMessage
            });
            
            // Verifica se a mensagem foi entregue com sucesso
            if(deliveryReport.Status == PersistenceStatus.NotPersisted) 
            {
                message.Status = " com erro";
                return message;
            }
            else
            {
                message.Status = " com sucesso";
                return message;
            }
        }
    }
}
