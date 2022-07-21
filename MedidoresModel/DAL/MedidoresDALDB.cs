using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedidoresModel.DAL
{
    public class MedidoresDALDB : IMedidoresDAL
    {
        private MedidoresDBEntities medidoresDB = new MedidoresDBEntities();
        public void AgregarMedidores(medidore medidores)
        {
            this.medidoresDB.medidores.Add(medidores);
            this.medidoresDB.SaveChanges();
        }

        public void EliminarMedidores(int id)
        {
            medidore medidores = this.medidoresDB.medidores.Find(id);
            this.medidoresDB.medidores.Remove(medidores);
            this.medidoresDB.SaveChanges();
        }

        public medidore Obtener(int id)
        {
            return this.medidoresDB.medidores.Find(id);
        }

        public List<medidore> ObtenerMedidores()
        {
            return this.medidoresDB.medidores.ToList();
        }

        public void Actualizar(medidore m)
        {
            medidore mOriginal = this.medidoresDB.medidores.Find(m.id);
            mOriginal.numero = m.numero;
            mOriginal.fecha = m.fecha;
            mOriginal.consumo = m.consumo;
            mOriginal.tipo = m.tipo;
            //todos los atributos
            this.medidoresDB.SaveChanges();
        }

        public List<medidore> ObtenerMedidores(string tipo)
        {
            var query = from m in this.medidoresDB.medidores
                        where m.tipo == tipo
                        select m;
            return query.ToList();
        }
    }
}
