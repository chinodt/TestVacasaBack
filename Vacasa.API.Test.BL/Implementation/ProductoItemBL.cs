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
    public class ProductoItemBL
    {
        public ProductoItemBE Obtener(string sCodigo)
        {
            ProductoItemDAL itemDAL = new ProductoItemDAL();
            ProductoItemDM prDM = new ProductoItemDM();
            ProductoItemBE prBE = new ProductoItemBE();
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
