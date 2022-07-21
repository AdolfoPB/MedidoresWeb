using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedidoresModel.DAL
{
    public class UsuariosDALDB : IUsuariosDAL
    {
        private MedidoresDBEntities medidoresDB = new MedidoresDBEntities();
        public void AgregarUsuarios(usuario usuarios)
        {
            this.medidoresDB.usuarios.Add(usuarios);
            this.medidoresDB.SaveChanges();
        }

        public void EliminarUsuarios(int id)
        {
            usuario usuarios = this.medidoresDB.usuarios.Find(id);
            this.medidoresDB.usuarios.Remove(usuarios);
            this.medidoresDB.SaveChanges();
        }

        public usuario Obtener(int id)
        {
            return this.medidoresDB.usuarios.Find(id);
        }

        public List<usuario> ObtenerUsuarios()
        {
            return this.medidoresDB.usuarios.ToList();
        }

        public void Actualizar(usuario u)
        {
            usuario uOriginal = this.medidoresDB.usuarios.Find(u.id);
            uOriginal.rut = u.rut;
            uOriginal.nombre = u.nombre;
            uOriginal.contrasena = u.contrasena;
            uOriginal.email = u.email;
            //todos los atributos
            this.medidoresDB.SaveChanges();
        }

        public List<usuario> ObtenerUsuarios(string nombre)
        {
            var query = from u in this.medidoresDB.usuarios
                        where u.nombre == nombre
                        select u;
            return query.ToList();
        }
    }
}
