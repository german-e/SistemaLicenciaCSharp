using SiGeIES.Domain.Common;
using SiGeIES.Domain.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SiGeIES.Domain.Entities.Estados
{
    public class InasistenciaIniciadaEstado : IEstado
    {
        private readonly InasistenciaService _service;

        public void Handle(Entity context)
        {
            Inasistencia i = (Inasistencia)context;
            
            i.Estado = Enums.EstadoInasistencia.Iniciado;
            
        }
    }
}
