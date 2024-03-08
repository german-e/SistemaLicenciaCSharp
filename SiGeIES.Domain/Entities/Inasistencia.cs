using SiGeIES.Domain.Common;
using SiGeIES.Domain.Entities.Estados;
using SiGeIES.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SiGeIES.Domain.Entities
{
    public class Inasistencia : Entity
    {
        private IEstado _estadoActual;


        public DateTime Desde { get; set; }
        public DateTime Hasta { get; set; }
        public Docente Docente { get; set; }
        public int HsCatedrasQueInasiste { get; set; }
        public EstadoInasistencia Estado { get; set; }



        public Inasistencia() : base()
        {
            _estadoActual = new InasistenciaIniciadaEstado();

        }


        public void CambiarEstado(IEstado nuevoEstado)
        {
            _estadoActual = nuevoEstado;
        }

        public void Request()
        {
            _estadoActual.Handle(this);
        }
    }
}
