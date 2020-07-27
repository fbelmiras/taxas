using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using testeFB.Models;
using System.Net;

namespace testeFB.Controllers
{
    [ApiController]
    [Route("")]

    public class CalculoController : ControllerBase
    {
        private const string url = "https://github.com/fbelmiras/taxas.git";


        /// <summary>
        /// Calcula Juros
        /// </summary>
        /// <returns></returns>

        [HttpGet]
        [Route("calculajuros")]

        public decimal GetValorFinal([FromQuery] decimal valorInicial, [FromQuery] int meses) 
            => new CalculoJuros().CalcularJuros(valorInicial, meses);


        /// <summary>
        /// Recupara a url do projeto no GitHub
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Route("showmethecode")]
        public string ShowMeTheCode()
            => url;


    }
}