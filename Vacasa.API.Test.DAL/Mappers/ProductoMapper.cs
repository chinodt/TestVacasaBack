using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vacasa.API.Test.DAL.Interfaces;
using Vacasa.API.Test.DAL.DataModels;
using Vacasa.API.Test.DAL.Common;
using Vacasa.API.Test.BE.BE;

namespace Vacasa.API.Test.DAL.Mappers
{
    public static class ProductoMapper
    {
        public static ProductoBE ToBE(this ProductoDM prodDM)
        {
            if (prodDM != null)
            {
                try
                {
                    return Mapper<ProductoDM, ProductoBE>.ToMapper(prodDM);
                }
                catch (Exception e)
                {
                    throw e;
                }
            }
            else
            {
                return null;
            }
        }

        public static List<ProductoBE> ToBE(this List<ProductoDM> prodDM)
        {
            if (prodDM != null)
            {
                try
                {
                    return Mapper<List<ProductoDM>, List<ProductoBE>>.ToMapper(prodDM);
                }
                catch (Exception e)
                {
                    throw e;
                }
            }
            else
            {
                return null;
            }
        }

        public static ProductoDM ToDM(this ProductoBE prodBE)
        {
            if (prodBE != null)
            {
                try
                {
                    return Mapper<ProductoBE, ProductoDM>.ToMapper(prodBE);
                }
                catch (Exception e)
                {
                    throw e;
                }
            }
            else
            {
                return null;
            }
        }
    }
}
