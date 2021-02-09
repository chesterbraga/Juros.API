using Microsoft.AspNetCore.Mvc;
using Juros.Business.Services;

namespace Juros.Calculos.API.Controllers
{    
    [ApiController]
    [ApiVersion("1.0")]
    [Route("api/v{version:apiVersion}")]
    public class CalculaJurosController : ControllerBase
    {
        private readonly ITaxaJurosService _taxaJurosService;
        private readonly ICalculoJurosService _calculoJurosService;

        public CalculaJurosController(ITaxaJurosService taxaJurosService, ICalculoJurosService calculoJurosService)
        {            
            _taxaJurosService = taxaJurosService;
            _calculoJurosService = calculoJurosService;
        }

        /// <summary>
        /// Calcular Juros
        /// </summary>        
        [Route("calculajuros")]
        [HttpGet]
        public ActionResult<decimal> CalcularJuros(decimal valorInicial, int tempo)
        {
            double taxa = _taxaJurosService.GetTaxaJuros().Result;
            return Ok(_calculoJurosService.Calcular(valorInicial, taxa, tempo));            
        }

        /// <summary>
        /// Show me the code
        /// </summary>
        [Route("showmethecode")]
        [HttpGet]
        public ActionResult<string> ShowMeTheCode()
        {
            return Ok(_calculoJurosService.ShowMeTheCode());
        }
    }
}