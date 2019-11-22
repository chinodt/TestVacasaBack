using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vacasa.API.Test.DAL.DataModels;
using Vacasa.API.Test.DAL.Implementation;
using Vacasa.API.Test.DAL.Common;
using Vacasa.API.Test.DAL.Mappers;
using Vacasa.API.Test.BE.BE;

namespace Vacasa.API.Test.BL.Implementation
{
    public class ProductoDetalleBL
    {
        public ProductoDetalleBE Obtener(string sCodigo)
        {
            ProductoDetalleDAL itemDAL = new ProductoDetalleDAL();
            ProductoDetalleDM prDM = new ProductoDetalleDM();
            ProductoDetalleBE prBE = new ProductoDetalleBE();
            try
            {
                prDM = itemDAL.Obtener(sCodigo);
                prBE = prDM.ToBE();
            }
            catch (Exception e)
            {
                throw e;
            }
            return prBE;
        }
    }
}
