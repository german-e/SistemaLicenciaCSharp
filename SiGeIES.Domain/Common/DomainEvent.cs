using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SiGeIES.Domain.Common
{
    public abstract class DomainEvent
    {
        DateTime Fecha { get; }
    }
}
