using System.Net.Http;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.TestHost;

namespace AssistPurchase.Test
{
    public class TestServer
    {
        public HttpClient Client { get; set; }
        private Microsoft.AspNetCore.TestHost.TestServer server;

        public TestServer()
        {
            SetupClient();
        }

        public void SetupClient()
        {
            server = new Microsoft.AspNetCore.TestHost.TestServer(new WebHostBuilder().UseStartup<Startup>());
            Client = server.CreateClient();
        }
    }
}
