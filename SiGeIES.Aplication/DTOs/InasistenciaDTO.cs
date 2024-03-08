using SiGeIES.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SiGeIES.Aplication.DTOs
{
    public class InasistenciaDTO
    {
        public string Apellido { get; set; }
        public string Nombre { get; set; }
        public string Email { get; set; }
        public string Desde { get; set; }
        public string Hasta { get; set; }        
        public int HsCatedras { get; set; }
        public string Estado { get; set; }




        public static explicit operator InasistenciaDTO (Inasistencia inasistencia)
        {
            return new InasistenciaDTO
            {
                Apellido = inasistencia.Docente.Apellido,
                Nombre = inasistencia.Docente.Nombre,
                Email = inasistencia.Docente.Email.Valor,
                Desde = inasistencia.Desde.ToShortDateString(),
                Hasta = inasistencia.Hasta.ToShortDateString(),
                HsCatedras = inasistencia.HsCatedrasQueInasiste,
                Estado = inasistencia.Estado.ToString()
            };
        }
    }
}
