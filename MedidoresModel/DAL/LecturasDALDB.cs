using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedidoresModel.DAL
{
    public class LecturasDALDB : ILecturasDAL
    {
        private MedidoresDBEntities medidoresDB = new MedidoresDBEntities();
        public void AgregarLecturas(lectura lecturas)
        {
            this.medidoresDB.lecturas.Add(lecturas);
            this.medidoresDB.SaveChanges();
        }

        public void EliminarLecturas(int id)
        {
            lectura lecturas = this.medidoresDB.lecturas.Find(id);
            this.medidoresDB.lecturas.Remove(lecturas);
            this.medidoresDB.SaveChanges();
        }

        public lectura Obtener(int id)
        {
            return this.medidoresDB.lecturas.Find(id);
        }

        public List<lectura> ObtenerLecturas()
        {
            return this.medidoresDB.lecturas.ToList();
        }

        public void Actualizar(lectura l)
        {
            lectura lOriginal = this.medidoresDB.lecturas.Find(l.id);
            lOriginal.numeroLec = l.numeroLec;
            lOriginal.fechaLec = l.fechaLec;
            lOriginal.horaLec = l.horaLec;
            lOriginal.minutoLec = l.minutoLec;
            lOriginal.consumoLec = l.consumoLec;
            //todos los atributos
            this.medidoresDB.SaveChanges();
        }

        public List<lectura> ObtenerLecturas(string numeroLec)
        {
            var query = from l in this.medidoresDB.lecturas
                        where l.numeroLec == numeroLec
                        select l;
            return query.ToList();
        }
    }
}
