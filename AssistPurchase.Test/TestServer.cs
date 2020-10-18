using System.Net.Http;
using Microsoft.AspNetCore.Hosting;

namespace AssistPurchase.Test
{
    public class TestServer
    {
        public HttpClient Client { get; private set; }
        private Microsoft.AspNetCore.TestHost.TestServer _server;

        public TestServer()
        {
            SetupClient();
        }

        void SetupClient()
        {
            _server = new Microsoft.AspNetCore.TestHost.TestServer(new WebHostBuilder().UseStartup<Startup>());
            Client = _server.CreateClient();
        }
    }
}
