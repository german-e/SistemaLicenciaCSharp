using SiGeIES.Domain.Common;
using SiGeIES.Domain.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SiGeIES.Domain.Entities
{
    public class Docente : Entity
    {
        

        private string nombre;
        private string apellido;
        private Direccion direccion;
        private string telefono;
        private Email email;

        private readonly List<Inasistencia> inasistencias;
        private readonly List<Licencia> licencias;

        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public Direccion Direccion { get => direccion; set => direccion = value; }
        public string Telefono { get => telefono; set => telefono = value; }
        public Email Email { get => email; set => email = value; }

        public Docente() : base() 
        { 
            inasistencias = new List<Inasistencia>();
            licencias = new List<Licencia>();
        }
        
        public void AgregarInasistencia(Inasistencia i)
        {
            inasistencias.Add(i);
        }


        

    }


    
}
