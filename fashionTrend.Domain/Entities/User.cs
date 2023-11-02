using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fashionTrend.Domain.Entities
{
    //quero garantir que ela não possa ser herdada
    public sealed class User : BaseEntity
    {
        public string Name { get; set; }
        public string Email { get; set; }
    }
}
