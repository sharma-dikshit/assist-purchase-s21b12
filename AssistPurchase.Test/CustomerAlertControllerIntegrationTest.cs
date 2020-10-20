using AssistPurchase.Models;
using FluentAssertions;
using Newtonsoft.Json;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace AssistPurchase.Test
{
    public class CustomerAlertControllerIntegrationTest
    {
        private readonly TestServer _server;
        private static string url = "http://localhost:5000/api/CustomerAlert";

        public CustomerAlertControllerIntegrationTest()
        {
            _server = new TestServer();
        }

        [Fact]
        public async Task ExistingCustomerAuthenticationSuccessfull()
        {
            var customer = new CustomerModel()
            {
                CustomerId = "A1",
                CustomerName = "Akash",
                CustomerEmailId = "akashspiman@gmail.com",
                CustomerPhoneNumber = "1256774",
                ProductName = "X3"
            }; //ReSharper disable all
            var response = await _server.Client.PostAsync(url + "/CustomerAuthenticate/X3/A1", new StringContent(JsonConvert.SerializeObject(customer), Encoding.UTF8, "application/json"));
            var returnString = await response.Content.ReadAsStringAsync();  //ReSharper restore all
            Assert.Contains("Existing Customer", returnString);
           
        }

        [Fact]
        public async Task NewCustomerAuthenticationSuccessfull()
        {
            var customer = new CustomerModel()
            {
                CustomerId = "A2",
                CustomerName = "Deeksha",
                CustomerEmailId = "xyz@abc.com",
                CustomerPhoneNumber = "875569454",
                ProductName = "MX40"
            }; //ReSharper disable all
            var response = await _server.Client.PostAsync(url + "/CustomerAuthenticate/MX40/A3", new StringContent(JsonConvert.SerializeObject(customer), Encoding.UTF8, "application/json"));
            var returnString = await response.Content.ReadAsStringAsync();  //ReSharper restore all
            Assert.Contains("New Customer", returnString);
        }

        [Fact]
        public async Task MailSentSuccessfully()
        {
            var customer = new CustomerModel()
            {
                CustomerId = "A1",
                CustomerName = "Akash",
                CustomerEmailId = "akashspiman@gmail.com",
                CustomerPhoneNumber = "1223455",
                ProductName = "X3"
            };//ReSharper disable all
            var response = await _server.Client.PostAsync(url + "/sendAlert", new StringContent(JsonConvert.SerializeObject(customer), Encoding.UTF8, "application/json")); //ReSharper restore all
            response.StatusCode.Should().Be(HttpStatusCode.OK);
        }
    }
}
