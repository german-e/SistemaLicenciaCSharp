using SiGeIES.Domain.Contracts;
using SiGeIES.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SiGeIES.Domain.Services
{
    public class InasistenciaService
    {
        private readonly IInasistenciaRepository _repository;

        public InasistenciaService(IInasistenciaRepository repo)
        {
            _repository = repo;
        }


        public Inasistencia GetInasistencia(int id)
        {
            return _repository.FindById(id);
        }
    }
}
