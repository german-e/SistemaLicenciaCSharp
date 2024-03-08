using SiGeIES.Domain.Entities;
using SiGeIES.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SiGeIES.Domain.Contracts
{
    public interface IInasistenciaService
    {
        List<Inasistencia> TodasInasistencia();
        List<Inasistencia> InasistenciaPorDocente(Docente docente);
        List<Inasistencia> InasistenciaPorEstado(EstadoInasistencia estado);

    }
}
