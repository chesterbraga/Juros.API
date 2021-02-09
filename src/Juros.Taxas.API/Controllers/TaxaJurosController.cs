using Microsoft.AspNetCore.Mvc;

namespace Juros.Taxas.API.Controllers
{
    [ApiVersion("1.0")]
    [Route("api/v{version:apiVersion}")]
    [ApiController]    
    public class TaxaJurosController : ControllerBase
    {
        /// <summary>
        /// Get Taxa de Juros
        /// </summary>
        [HttpGet]
        [Route("taxajuros")]
        public ActionResult<double> GetTaxaJuros()
        {
            return Ok(0.01);
        }
    }
}