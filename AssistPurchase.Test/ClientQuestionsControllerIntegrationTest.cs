using AssistPurchase.Database;
using FluentAssertions;
using Newtonsoft.Json;
using System.Threading.Tasks;
using Xunit;

namespace AssistPurchase.Test
{
    public class ClientQuestionsControllerIntegrationTest
    {
        private readonly TestServer _server;
        private static readonly string url = "http://localhost:5000/api/ClientQuestions/MonitoringProducts";

        public ClientQuestionsControllerIntegrationTest()
        {
            _server = new TestServer();
        }
        readonly MonitoringProductDatabase _productDatabase = new MonitoringProductDatabase();

        [Fact]
        public async Task CheckIfAllProductsAreRendered()
        {
            var response = await _server.Client.GetAsync(url);
            response.EnsureSuccessStatusCode();
            Assert.Equal(4, _productDatabase.ProductDb.Count);
        }

        [Fact]
        public async Task CorrectProductDescriptionIsRendered()
        {
            var response = await _server.Client.GetAsync(url + "/Description/X3");
            var responseText = await response.Content.ReadAsStringAsync();
            Assert.Equal("The Philips IntelliVue X3 is a compact, dual-purpose, transport patient monitor featuring intuitive smartPhone-style operation and offering a scalable set of clinical measurements.", responseText);
        }

        [Fact]
        public async Task WhenTouchScreenYesIsAnsweredByUser()
        {
            var response = await _server.Client.GetAsync(url + "/TouchScreen/YES");
            var responseText = JsonConvert.DeserializeObject<Task[]>(await response.Content.ReadAsStringAsync());
            responseText.Should().HaveCount(4);
        }

        [Fact]
        public async Task WhenTouchScreenNoIsAnsweredByUser()
        {
            var response = await _server.Client.GetAsync(url + "/TouchScreen/NO");
            var responseText = JsonConvert.DeserializeObject<Task[]>(await response.Content.ReadAsStringAsync());
            responseText.Should().HaveCount(0);
        }

        [Fact]
        public async Task WhenWearableMonitorYesIsAnsweredByUser()
        {
            var response = await _server.Client.GetAsync(url + "/WearableMonitor/YES");
            var responseText = JsonConvert.DeserializeObject<Task[]>(await response.Content.ReadAsStringAsync());
            responseText.Should().HaveCount(1);
        }

        [Fact]
        public async Task WhenWearableMonitorNoIsAnsweredByUser()
        {
            var response = await _server.Client.GetAsync(url + "/WearableMonitor/NO");
            var responseText = JsonConvert.DeserializeObject<Task[]>(await response.Content.ReadAsStringAsync());
            responseText.Should().HaveCount(3);
        }

        [Fact]
        public async Task WhenAlarmManagementYesIsAnsweredByUser()
        {
            var response = await _server.Client.GetAsync(url + "/AlarmManagement/YES");
            var responseText = JsonConvert.DeserializeObject<Task[]>(await response.Content.ReadAsStringAsync());
            responseText.Should().HaveCount(1);
        }

        [Fact]
        public async Task WhenAlarmManagementNoIsAnsweredByUser()
        {
            var response = await _server.Client.GetAsync(url + "/AlarmManagement/NO");
            var responseText = JsonConvert.DeserializeObject<Task[]>(await response.Content.ReadAsStringAsync());
            responseText.Should().HaveCount(3);
        }

        [Fact]
        public async Task WhenBelowPrice25000IsAnsweredByUser()
        {
            var response = await _server.Client.GetAsync(url + "/BelowPrice/25000");
            var responseText = JsonConvert.DeserializeObject<Task[]>(await response.Content.ReadAsStringAsync());
            responseText.Should().HaveCount(2);
        }

        [Fact]
        public async Task WhenAbovePrice25000IsAnsweredByUser()
        {
            var response = await _server.Client.GetAsync(url + "/AbovePrice/25000");
            var responseText = JsonConvert.DeserializeObject<Task[]>(await response.Content.ReadAsStringAsync());
            responseText.Should().HaveCount(2);
        }

        [Fact]
        public async Task WhenConnectivitySupportYesIsAnsweredByUser()
        {
            var response = await _server.Client.GetAsync(url + "/ConnectivitySupport/YES");
            var responseText = JsonConvert.DeserializeObject<Task[]>(await response.Content.ReadAsStringAsync());
            responseText.Should().HaveCount(2);
        }

        [Fact]
        public async Task WhenConnectivitySupportNoIsAnsweredByUser()
        {
            var response = await _server.Client.GetAsync(url + "/ConnectivitySupport/NO");
            var responseText = JsonConvert.DeserializeObject<Task[]>(await response.Content.ReadAsStringAsync());
            responseText.Should().HaveCount(2);
        }

        [Fact]
        public async Task WhenSummarizeDataSupportYesIsAnsweredByUser()
        {
            var response = await _server.Client.GetAsync(url + "/SummarizeDataSupport/YES");
            var responseText = JsonConvert.DeserializeObject<Task[]>(await response.Content.ReadAsStringAsync());
            responseText.Should().HaveCount(2);
        }

        [Fact]
        public async Task WhenSummerizeDataSupportNoIsAnsweredByUser()
        {
            var response = await _server.Client.GetAsync(url + "/SummarizeDataSupport/NO");
            var responseText = JsonConvert.DeserializeObject<Task[]>(await response.Content.ReadAsStringAsync());
            responseText.Should().HaveCount(2);
        }

        [Fact]
        public async Task WhenScalableMeasurementNoIsAnsweredByUser()
        {
            var response = await _server.Client.GetAsync(url + "/ScalableMeasurement/NO");
            var responseText = JsonConvert.DeserializeObject<Task[]>(await response.Content.ReadAsStringAsync());
            responseText.Should().HaveCount(2);
        }

        [Fact]
        public async Task WhenScalableMeasurementYesIsAnsweredByUser()
        {
            var response = await _server.Client.GetAsync(url + "/ScalableMeasurement/YES");
            var responseText = JsonConvert.DeserializeObject<Task[]>(await response.Content.ReadAsStringAsync());
            responseText.Should().HaveCount(2);
        }

        [Fact]
        public async Task WhenCompactYesIsAnsweredByUser()
        {
            var response = await _server.Client.GetAsync(url + "/Compact/YES");
            var responseText = JsonConvert.DeserializeObject<Task[]>(await response.Content.ReadAsStringAsync());
            responseText.Should().HaveCount(2);
        }

        [Fact]
        public async Task WhenCompactNoIsAnsweredByUser()
        {
            var response = await _server.Client.GetAsync(url + "/Compact/NO");
            var responseText = JsonConvert.DeserializeObject<Task[]>(await response.Content.ReadAsStringAsync());
            responseText.Should().HaveCount(2);
        }

        [Fact]
        public async Task WhenBelowScreenSize6IsAnsweredByUser()
        {
            var response = await _server.Client.GetAsync(url + "/BelowScreenSize/6");
            var responseText = JsonConvert.DeserializeObject<Task[]>(await response.Content.ReadAsStringAsync());
            responseText.Should().HaveCount(1);
        }

        [Fact]
        public async Task WhenAboveScreenSize6IsAnsweredByUser()
        {
            var response = await _server.Client.GetAsync(url + "/AboveScreenSize/6");
            var responseText = JsonConvert.DeserializeObject<Task[]>(await response.Content.ReadAsStringAsync());
            responseText.Should().HaveCount(3);
        }

    }
}
