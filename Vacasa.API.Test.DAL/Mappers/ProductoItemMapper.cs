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
    public static class ProductoItemMapper
    {
        public static ProductoItemBE ToBE(this ProductoItemDM prodDM)
        {
            if (prodDM != null)
            {
                try
                {
                    var resp = new ProductoItemBE();
                    resp.id = prodDM.id;
                    resp.site_id = prodDM.site_id;
                    resp.title = prodDM.title;
                    resp.price = prodDM.price;
                    resp.pictures = prodDM.pictures.ToPicArrBE();
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

        public static PicturesBE[] ToPicArrBE(this PicturesDM[] picDM)
        {
            if (picDM != null)
            {
                try
                {
                    PicturesBE[] picArrBE = new PicturesBE[picDM.Length];
                    //return Mapper<PicturesDM[], PicturesBE[]>.ToMapper(picDM);
                    PicturesBE prBE = new PicturesBE();
                    for (int i=0; i < picDM.Length ;i++)
                    {
                        picArrBE[i] = picDM[i].ToPicBE();
                    }
                    return picArrBE;
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

        public static PicturesBE ToPicBE(this PicturesDM picDM)
        {
            if (picDM != null)
            {
                try
                {
                    return Mapper<PicturesDM, PicturesBE>.ToMapper(picDM);
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
