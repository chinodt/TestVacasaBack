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
    public static class ProductoDetalleMapper
    {
        public static ProductoDetalleBE ToBE(this ProductoDetalleDM prodDM)
        {
            if (prodDM != null)
            {
                try
                {
                    var resp = new ProductoDetalleBE();
                    resp.date_created = prodDM.date_created;
                    resp.last_updated = prodDM.last_updated;
                    resp.plain_text = prodDM.plain_text;
                    resp.snapshot = prodDM.snapshot.ToSnapBE();
                    return resp;
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

        public static SnapshotBE ToSnapBE(this SnapshotDM snapDM)
        {
            if (snapDM != null)
            {
                try
                {
                    return Mapper<SnapshotDM, SnapshotBE>.ToMapper(snapDM);
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

        public static ProductoDetalleDM ToDM(this ProductoDetalleBE prodBE)
        {
            if (prodBE != null)
            {
                try
                {
                    return Mapper<ProductoDetalleBE, ProductoDetalleDM>.ToMapper(prodBE);
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
