﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fashionTrend.Application.UseCases.MessageCases.CreateMessage
{
    public class CreateMessageResponse
    {
        public Guid Id { get; set; }
        public string Sender { get; set; } /// quem está enviando a mensagem
        public string Receiver { get; set; } // quem vai receber essa mensagem
        public string Content { get; set; } // conteúdo da mensagem que o receiver irá consumir
        public DateTime Timestamp { get; set; }
        public string Status { get; set; } //controle de estado para o retorno dessa mensagem
    }
}
