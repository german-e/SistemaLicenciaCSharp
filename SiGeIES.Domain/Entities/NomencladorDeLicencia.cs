using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SiGeIES.Domain.Entities
{
    public class NomencladorDeLicencia
    {
        public Guid Id { get; set; }

        public string Articulo { get; set; }
        public string Descripcion { get; set; }
        public int DiasPermitidos { get; set; }
        public bool SeInformaEnIL01 { get; set; }


        
    }
}
