using System;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.TestHost;
using netcore_webapi_employee;
using Xunit;

namespace netcore_webapi_employee_tests
{
    public class PrimeWebShould
    {

        private readonly TestServer _server;
        private readonly HttpClient _client;

        public PrimeWebShould()
        {
            // Arrange
            _server = new TestServer(new WebHostBuilder()
               .UseStartup<Startup>());
            _client = _server.CreateClient();
        }

        [Fact]
        public async Task ReturnHelloWorldWithDefaultRequest()
        {
            // Act
            var response = await _client.GetAsync("/hello");
            response.EnsureSuccessStatusCode();
            var responseString = await response.Content.ReadAsStringAsync();
            // Assert
            Assert.Equal("Hello World!", responseString);
        }

        [Fact]
        public async Task ReturnHelloJimWithUserName()
        {
            // Act
            var response = await _client.GetAsync("/hello/Jim");
            response.EnsureSuccessStatusCode();
            var responseString = await response.Content.ReadAsStringAsync();
            // Assert
            Assert.Equal("Hello Jim", responseString);
        }
    }

}

