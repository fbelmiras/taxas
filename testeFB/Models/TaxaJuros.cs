using System.ComponentModel.DataAnnotations;
using System.Threading.Tasks;

namespace testeFB.Models
{
    public class TaxaJuros
    {
        /// <summary>
        /// Recupera o valor da taxa de juros
        /// </summary>
        /// <returns></returns>

        public decimal TaxaDeJuros => 0.01M;    
    }       
}