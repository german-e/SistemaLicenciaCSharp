using SiGeIES.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SiGeIES.Domain.ValueObjects
{
    public class Direccion : ValueObject<Direccion>
    {

        private string _value;
        public Direccion(string calle = "S/Especificar", string numeroCalle ="S/N", string localidad = "N/Inf")
        {
            
            Calle = calle;
            NumeroCalle = numeroCalle;
            Localidad = localidad;

            _value = $"{Calle} N° {NumeroCalle} - {Localidad}";
        }

        public string Calle { get; private set; }
        public string NumeroCalle { get; private set; }
        public string Localidad { get; private set; }

        
        protected override IEnumerable<object> GetEqualityComponents()
        {
            yield return new object[] { Calle, NumeroCalle, Localidad };
        }
    }
}
