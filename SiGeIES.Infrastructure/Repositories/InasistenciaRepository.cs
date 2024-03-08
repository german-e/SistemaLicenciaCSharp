using Dapper;
using SiGeIES.Domain.Contracts;
using SiGeIES.Domain.Entities;
using SiGeIES.Infrastructure.DataAccess;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SiGeIES.Infrastructure.Repositories
{
    public class InasistenciaRepository : IInasistenciaRepository
    {
        private readonly IDbConnection connDB;

        public InasistenciaRepository()
        {
            connDB = new DbConnection().GetConnection() ;
        }

        public void Add(Inasistencia entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(Inasistencia entity)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Inasistencia> FindAll()
        {
            /*
            string query = "Select * from Inasistencias";

            var result = connDB.Query<Inasistencia>(query);

            return result; */


            Inasistencia inasistencia = new Inasistencia();
            inasistencia.Desde = DateTime.Now;
            inasistencia.Hasta = DateTime.Now;
            inasistencia.Docente = new Docente { Apellido = "Espindola", Nombre = "German leoenle", Email = new Domain.ValueObjects.Email("german.espindola@gmail.com"), Telefono = "3731-456711", Direccion = new Domain.ValueObjects.Direccion(calle: "Gualtieri", localidad: "Las Breñas") };
            inasistencia.HsCatedrasQueInasiste = 3;

            Inasistencia in2 = new Inasistencia();
            in2.Desde = new DateTime(2024,3,2);
            in2.Hasta = new DateTime(2024, 3, 2);
            in2.Docente = new Docente { Apellido = "Cepeda", Nombre = "Paola Romina", Email = new Domain.ValueObjects.Email("romina_c=epeda@hotmail.com"), Telefono = "3731-551190", Direccion = new Domain.ValueObjects.Direccion(calle: "Gualtieri", localidad: "Las Breñas") };
            in2.HsCatedrasQueInasiste = 2;

            List<Inasistencia> resp = new List<Inasistencia>();
            resp.Add(inasistencia);
            resp.Add(in2);

            return resp;
        }

        public Inasistencia FindById(int id)
        {
            throw new NotImplementedException();
        }

        public void Updater(Inasistencia entity)
        {
            throw new NotImplementedException();
        }
    }
}
