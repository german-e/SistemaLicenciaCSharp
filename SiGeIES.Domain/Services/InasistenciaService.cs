using SiGeIES.Domain.Contracts;
using SiGeIES.Domain.Entities;
using SiGeIES.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SiGeIES.Domain.Services
{
    public class InasistenciaService : IInasistenciaService
    {
        private readonly IInasistenciaRepository _repository;

        public InasistenciaService(IInasistenciaRepository repo)
        {
            _repository = repo;
        }
       

        public List<Inasistencia> InasistenciaPorDocente(Docente docente)
        {
            throw new NotImplementedException();
        }

        public List<Inasistencia> InasistenciaPorEstado(EstadoInasistencia estado)
        {
            throw new NotImplementedException();
        }

        public List<Inasistencia> TodasInasistencia()
        {
            return _repository.FindAll().ToList();
        }
    }
}
