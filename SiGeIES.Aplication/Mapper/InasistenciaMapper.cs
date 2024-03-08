using SiGeIES.Aplication.DTOs;
using SiGeIES.Aplication.Services;
using SiGeIES.Domain.Contracts;
using SiGeIES.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SiGeIES.Aplication.Mapper
{
    public static class InasistenciaMapper
    {
        
        


        public static  List<InasistenciaDTO> ToDto(IEnumerable<Inasistencia> inasistencias)
        {
            

                       
            var rta = (from x in inasistencias select (InasistenciaDTO)x).ToList();


            return rta;
        }
    }
}
