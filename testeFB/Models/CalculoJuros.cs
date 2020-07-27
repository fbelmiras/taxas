using System;
using System.Threading;

namespace testeFB.Models
{
    /// <summary>
    /// Calcula juros 
    /// </summary>
    /// <param name="message"><see cref="CancellationToken"/></param>
    /// <param name="cancellationToken"></param>
     /// <returns></returns>
    public class CalculoJuros{
        public decimal CalcularJuros(decimal valorInicial, int meses) 
        => Math.Round((Convert.ToDecimal(valorInicial * ((decimal)Math.Pow(1 + ((double)new TaxaJuros().TaxaDeJuros), meses)))), 2);
    }

}