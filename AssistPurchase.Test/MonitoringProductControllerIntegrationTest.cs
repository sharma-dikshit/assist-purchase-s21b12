using AssistPurchase.Database;
using FluentAssertions;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using AssistPurchase.Models;
using System.Net.Http;
using Newtonsoft.Json;

namespace AssistPurchase.Test
{
    public class MonitoringProductControllerIntegrationTest
    {
        private readonly TestServer _sut;
        private static string url = "http://localhost:5000/api/MonitoringProduct";

        public MonitoringProductControllerIntegrationTest()
        {
            _sut = new TestServer();
        }
        readonly MonitoringProductDatabase _productDatabase = new MonitoringProductDatabase();

        [Fact]
        public async Task CheckRenderedProductCountWithDatabaseProductCount()
        {
            var response = await _sut.Client.GetAsync(url + "/all");
            response.EnsureSuccessStatusCode();
            Assert.Equal(4, _productDatabase.ProductDb.Count);
        }

        [Fact]
        public async Task WhenValidProductNumberEnteredCheckProductName()
        {
            var response = await _sut.Client.GetAsync(url + "/get/X3");
            var returnString = await response.Content.ReadAsStringAsync();
            Assert.Contains("IntelliVue", returnString);
        }

        [Fact]
        public async Task WhenInvalidProductNumberEntered()
        {
            var response = await _sut.Client.GetAsync(url + "/get/X8");
            response.StatusCode.Should().Be(HttpStatusCode.NotFound);
        }

        [Fact]
        public async Task WhenDeleteRequestSent()
        {
            var response = await _sut.Client.DeleteAsync(url + "/delete/X3");
            Assert.True(response.StatusCode == HttpStatusCode.OK);
        }
        

        [Fact]
        public async Task WhenDeleteRequestSentToIncorrectProduct()
        {
            var response = await _sut.Client.DeleteAsync(url + "/delete/XAA8");
            Assert.True(response.StatusCode == HttpStatusCode.NotFound);
        }

        [Fact]
        public async Task WhenNewProductEnteredSuccessfully()
        {
            var newProduct = new MonitoringProducts()
            {
                ProductNumber = "MXI450",
                ProductName = "IntelliVue",
                ProductDescription =
                    "The IntelliVue MXI450 combines powerful monitoring with flexible portability in one compact unit. Supplying comprehensive patient information at a glance, it can make a real difference when multiple patients and priorities need attention.",
                TouchScreen = "YES",
                WearableMonitor = "NO",
                AlarmManagement = "NO",
                Cost = "38790",
                ScreenSize = "12",
                ConnectivitySupport = "YES",
                SummarizeDataSupport = "YES",
                ScalableMeasurement = "NO",
                Compact = "NO"
            };
            //ReSharper disable all
            var response = await _sut.Client.PostAsync(url + "/new",new StringContent(JsonConvert.SerializeObject(newProduct),Encoding.UTF8,"application/json")); //ReSharper restore all
            response.StatusCode.Should().Be(HttpStatusCode.OK);
        }

        [Fact]
        public async Task UpdatingDataForAProductSuccessfully()
        {
            var modifiedProduct = new MonitoringProducts()
            {
                ProductNumber = "MX450",
                ProductName = "IntelliVue",
                ProductDescription =
                    "The IntelliVue MX450 combines powerful monitoring with flexible portability in one compact unit. Supplying comprehensive patient information at a glance, it can make a real difference when multiple patients and priorities need attention.",
                TouchScreen = "YES",
                WearableMonitor = "YES",//modified
                AlarmManagement = "NO",
                Cost = "38790",
                ScreenSize = "18",  //modified
                ConnectivitySupport = "YES",
                SummarizeDataSupport = "YES",
                ScalableMeasurement = "NO",
                Compact = "NO"
            };  //ReSharper disable all
            var response = await _sut.Client.PutAsync(url + "/update/MX450", new StringContent(JsonConvert.SerializeObject(modifiedProduct), Encoding.UTF8, "application/json")); //ReSharper restore all
            Assert.True(response.StatusCode == HttpStatusCode.OK);
        }

        [Fact]
        public async Task UpdatingDataForAnInvalidProduct()
        {
            var modifiedProduct = new MonitoringProducts()
            {
                ProductNumber = "MXI450", //invalid product number
                ProductName = "IntelliVue",
                ProductDescription =
                    "The IntelliVue MX450 combines powerful monitoring with flexible portability in one compact unit. Supplying comprehensive patient information at a glance, it can make a real difference when multiple patients and priorities need attention.",
                TouchScreen = "YES",
                WearableMonitor = "YES",
                AlarmManagement = "NO",
                Cost = "38790",
                ScreenSize = "18",  
                ConnectivitySupport = "YES",
                SummarizeDataSupport = "YES",
                ScalableMeasurement = "NO",
                Compact = "NO"
            }; //ReSharper disable all
            var response = await _sut.Client.PutAsync(url + "/update/MXI450", new StringContent(JsonConvert.SerializeObject(modifiedProduct), Encoding.UTF8, "application/json")); //ReSharper restore all
            Assert.True(response.StatusCode == HttpStatusCode.NotFound);
        }


    }
}
