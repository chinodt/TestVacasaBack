using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Vacasa.API.Test.BE.BE;
using Vacasa.API.Test.BL.Implementation;

namespace TestVacasaBack.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductoDetalleController : ControllerBase
    {
        [HttpGet]
        public ProductoDetalleBE Get(string sCodigo)
        {
            try
            {
                var bl = new ProductoDetalleBL();
                var respuesta = bl.Obtener(sCodigo);
                return respuesta;
            }
            catch (Exception error)
            {
                throw error;
            }
        }
    }
}