using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedidoresModel.DAL
{
    public interface ILecturasDAL
    {
        List<lectura> ObtenerLecturas();
        List<lectura> ObtenerLecturas(string numeroLec);
        lectura Obtener(int id);
        void AgregarLecturas(lectura lecturas);
        void EliminarLecturas(int id);
    }
}
