using Microsoft.AspNetCore.Mvc;
using testeFB.Models;

namespace testeFB.Controllers
{
    [ApiController]
    [Route("")]

    /// <summary>
    /// Recupera o valor da taxa de juros
    /// </summary>
    /// <returns></returns>

    public class TaxaJurosController : ControllerBase
    {
        [HttpGet]
        [Route("taxaJuros")]

        public decimal GetTaxa() => new TaxaJuros().TaxaDeJuros;
    }
}