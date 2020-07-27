using System;
using Xunit;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestPlatform;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using System.Net.Http;
using testeFB;

namespace TestAPI
{
    public class UnitTest1
    {
        [Fact]
        public void CalcularTaxaJurosAPI()
        {
            //Arranges
            var command = new testeFB.Models.CalculoJuros().CalcularJuros(100, 5);
            command = new testeFB.Models.CalculoJuros().CalcularJuros(2, 3);
        }

        public void TaxaJurosAPI()
        {
            //Arranges
            var command = new testeFB.Models.TaxaJuros().TaxaDeJuros;
        }

        
    }

    
}
