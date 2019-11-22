using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vacasa.API.Test.DAL.Interfaces
{
    public interface IContratoImplementacion<T, U> where T : class
                                                  where U : struct
    {
        T Crear(T entidad);
        T Obtener();
        T Obtener(int id);
        T ObtenerList();
        T ObtenerList(int id);
        T Modificar(T entidad);
        T Eliminar(U id);
    }
}
