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
    public class ProductoDetalleDAL : IContratoImplementacion<ProductoDetalleDM, int>
    {
        public ProductoDetalleDM Crear(ProductoDetalleDM entidad)
        {
            throw new NotImplementedException();
        }

        public ProductoDetalleDM Eliminar(int id)
        {
            throw new NotImplementedException();
        }

        public ProductoDetalleDM Modificar(ProductoDetalleDM entidad)
        {
            throw new NotImplementedException();
        }

        public ProductoDetalleDM Obtener(string sCodigo)
        {
            var url = @"https://api.mercadolibre.com/items/" + sCodigo + @"/description";
            var respuesta = Utils.InvocaServicioRest<ProductoDetalleDM>(url);
            return respuesta;
        }

        public ProductoDetalleDM Obtener()
        {
            throw new NotImplementedException();
        }

        public ProductoDetalleDM Obtener(int id)
        {
            throw new NotImplementedException();
        }

        public ProductoDetalleDM ObtenerList(int id)
        {
            throw new NotImplementedException();
        }

        public ProductoDetalleDM ObtenerList()
        {
            throw new NotImplementedException();
        }
    }
}
