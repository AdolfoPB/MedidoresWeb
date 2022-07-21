using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedidoresModel.DAL
{
    public interface IMedidoresDAL
    {
        List<medidore> ObtenerMedidores();
        List<medidore> ObtenerMedidores(string tipo);
        medidore Obtener(int id);
        void AgregarMedidores(medidore medidores);
        void EliminarMedidores(int id);
    }
}
