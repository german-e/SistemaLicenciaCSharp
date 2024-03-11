using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SiGeIES.Domain.Common
{
    public interface IDomainEvent
    {
        DateTime Fecha { get; }
    }
}
