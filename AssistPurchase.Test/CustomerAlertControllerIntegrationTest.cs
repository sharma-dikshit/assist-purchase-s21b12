using AssistPurchase.Models;
using FluentAssertions;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace AssistPurchase.Test
{
    public class CustomerAlertControllerIntegrationTest
    {
        private readonly TestServer server;
        private static string url = "http://localhost:5000/api/CustomerAlert";

        //[Fact]
        //public async Task CustomerAuthenticationSuccessfull()
        //{
        //    var customer = new CustomerModel()
        //    {
        //        CustomerId = "A1",
        //        CustomerName = "Akash",
        //        CustomerEmailId = "akashspiman@gmail.com",
        //        CustomerPhoneNumber = "1256774",
        //        ProductName = "X3"
        //    };
        //    var response = await server.Client.PostAsync(url + "/CustomerAuthenticate/X3/A1", new StringContent(JsonConvert.SerializeObject(customer), Encoding.UTF8, "application/json"));
        //    var returnString = await response.Content.ReadAsStringAsync();
        //    response.StatusCode.Should().Be(HttpStatusCode.OK);
        //}

        //[Fact]
        //public async Task MailSentSuccessfully()
        //{
        //    var customer = new CustomerModel()
        //    {
        //        CustomerId = "A1",
        //        CustomerName = "Akash",
        //        CustomerEmailId = "akashspiman@gmail.com",
        //        CustomerPhoneNumber = "1223455",
        //        ProductName = "X3"
        //    };
        //    var response = await server.Client.PostAsync(url + "/sendAlert", new StringContent(JsonConvert.SerializeObject(customer), Encoding.UTF8, "application/json"));
        //    response.StatusCode.Should().Be(HttpStatusCode.OK);
        //}
    }
}
