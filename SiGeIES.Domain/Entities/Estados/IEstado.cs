using SiGeIES.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SiGeIES.Domain.Entities.Estados
{
    public interface IEstado
    {
        void Handle(Entity context);
    }
}
