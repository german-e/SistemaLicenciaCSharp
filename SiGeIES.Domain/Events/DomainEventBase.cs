using SiGeIES.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SiGeIES.Domain.Events
{
    public abstract class DomainEventBase : IDomainEvent
    {
        public DateTime Fecha => DateTime.Now;
    }
}
