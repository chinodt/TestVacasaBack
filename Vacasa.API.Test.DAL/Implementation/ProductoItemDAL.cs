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
    public class ProductoItemDAL : IContratoImplementacion<ProductoItemDM, int>
    {
        public ProductoItemDM Crear(ProductoItemDM entidad)
        {
            throw new NotImplementedException();
        }

        public ProductoItemDM Eliminar(int id)
        {
            throw new NotImplementedException();
        }

        public ProductoItemDM Modificar(ProductoItemDM entidad)
        {
            throw new NotImplementedException();
        }

        public ProductoItemDM Obtener(string sCodigo)
        {
            var url = @"https://api.mercadolibre.com/items/" + sCodigo;
            var respuesta = Utils.InvocaServicioRest<ProductoItemDM>(url);
            return respuesta;
        }

        public ProductoItemDM Obtener()
        {
            throw new NotImplementedException();
        }

        public ProductoItemDM Obtener(int id)
        {
            throw new NotImplementedException();
        }

        public ProductoItemDM ObtenerList()
        {
            throw new NotImplementedException();
        }

        public ProductoItemDM ObtenerList(int id)
        {
            throw new NotImplementedException();
        }
    }
}
