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
    public class ProductoController : ControllerBase
    {
        [HttpGet]
        public List<ProductoBE> Get(string sProducto)
        {
            try
            {
                var bl = new ProductoBL();
                var respuesta = bl.Obtener(sProducto);
                return respuesta;
            }
            catch (Exception error)
            {
                throw error;
            }
        }
    }
}