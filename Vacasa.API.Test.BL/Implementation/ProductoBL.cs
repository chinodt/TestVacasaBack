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
    public class ProductoBL
    {
        public List<ProductoBE> Obtener(string sProducto)
        {
            ProductoDAL itemDAL = new ProductoDAL();
            List<ProductoDM> prDM = new List<ProductoDM>();
            ProductoBE prBE = new ProductoBE();
            List<ProductoBE> prLstBE = new List<ProductoBE>();
            try
            {
                prDM = itemDAL.ObtenerList(sProducto);
                foreach (ProductoDM pr in prDM)
                {
                    prBE = pr.ToBE();
                    prLstBE.Add(prBE);
                }
            }
            catch (Exception e)
            {
                throw e;
            }
            return prLstBE;
        }
    }
}
