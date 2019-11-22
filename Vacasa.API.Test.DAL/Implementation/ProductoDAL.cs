using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vacasa.API.Test.DAL.Interfaces;
using Vacasa.API.Test.DAL.DataModels;
using Vacasa.API.Test.DAL.Common;

namespace Vacasa.API.Test.DAL.Implementation
{
    public class ProductoDAL : IContratoImplementacion<ProductoDM, int>
    {
        public ProductoDM Crear(ProductoDM entidad)
        {
            throw new NotImplementedException();
        }

        public ProductoDM Eliminar(int id)
        {
            throw new NotImplementedException();
        }

        public ProductoDM Modificar(ProductoDM entidad)
        {
            throw new NotImplementedException();
        }

        public ProductoDM Obtener()
        {
            throw new NotImplementedException();
        }

        public ProductoDM Obtener(int id)
        {
            throw new NotImplementedException();
        }

        public List<ProductoDM> ObtenerList(string sProducto)
        {
            var url = @"https://api.mercadolibre.com/sites/MLA/search?q=" + sProducto;
            var respuesta = Utils.InvocaServicioListRest<ProductoDM>(url, "results");
            return respuesta;
        }

        public ProductoDM ObtenerList()
        {
            throw new NotImplementedException();
        }

        public ProductoDM ObtenerList(int id)
        {
            throw new NotImplementedException();
        }
    }
}
