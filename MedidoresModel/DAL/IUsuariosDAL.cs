using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedidoresModel.DAL
{
    public interface IUsuariosDAL
    {
        List<usuario> ObtenerUsuarios();
        List<usuario> ObtenerUsuarios(string nombre);
        usuario Obtener(int id);
        void AgregarUsuarios(usuario usuarios);
        void EliminarUsuarios(int id);
    }
}
