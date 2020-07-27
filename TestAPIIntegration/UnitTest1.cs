using System;
using Xunit;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestPlatform;
using System.Net.Http;
using testeFB;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.TestHost;


namespace TestAPIIntegration  
{
    
    
    public class IntegrationTest
    {
        private readonly TestServer _server;
        private readonly HttpClient _client;

        

        public IntegrationTest()
        {
            // Arrange
            _server = new TestServer(new WebHostBuilder().UseStartup<Startup>());
            _client = _server.CreateClient();
        }

        [Fact]
        public async Task ReturnTaxaJuros()
        {
            // Act
            var response = await _client.GetAsync("taxaJuros");
            response.EnsureSuccessStatusCode();
            var responseString = await response.Content.ReadAsStringAsync();
        }


        [Theory]
        [InlineData ( 100, 5)]
        public async Task ReturnCalculoJuros(decimal valorInicial, int meses)
        { 
            try{
                var response = await _client.GetAsync($"calculajuros/{(decimal)valorInicial}/{(int)meses}");
               // response.EnsureSuccessStatusCode();

                if (!response.IsSuccessStatusCode)
                {
                    var responseContent = response.Content == null
                        ? "NoContent"
                        : response.Content.ReadAsStringAsync().GetAwaiter().GetResult();
                    throw new HttpRequestException($"{response.StatusCode} (ReasonPhrase: {response.ReasonPhrase}, Content: {responseContent})");
                }

            }catch (HttpRequestException e){
                e.StackTrace.ToString();
            }         
           
        }
    }
}
