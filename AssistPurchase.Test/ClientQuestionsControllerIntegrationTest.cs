using AssistPurchase.Database;
using FluentAssertions;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace AssistPurchase.Test
{
    public class ClientQuestionsControllerIntegrationTest
    {
        private readonly TestServer server;
        private readonly static string url = "http://localhost:5000/api/ClientQuestions/MonitoringProducts";

        public ClientQuestionsControllerIntegrationTest()
        {
            server = new TestServer();
        }
        MonitoringProductDatabase productDatabase = new MonitoringProductDatabase();

        [Fact]
        public async Task CheckIfAllProductsAreRendered()
        {
            var response = await server.Client.GetAsync(url);
            response.EnsureSuccessStatusCode();
            Assert.Equal(4, productDatabase.ProductDb.Count);
        }

        [Fact]
        public async Task CorrectProductDescriptionIsRendered()
        {
            var response = await server.Client.GetAsync(url + "/Description/X3");
            response.EnsureSuccessStatusCode();
            var responseText = await response.Content.ReadAsStringAsync();
            Assert.Equal("The Philips IntelliVue X3 is a compact, dual-purpose, transport patient monitor featuring intuitive smartPhone-style operation and offering a scalable set of clinical measurements.", responseText);
        }

        [Fact]
        public async Task WhenTouchScreenYesIsAnsweredByUser()
        {
            var response = await server.Client.GetAsync(url + "/TouchScreen/YES");
            response.EnsureSuccessStatusCode();
            var responseText = JsonConvert.DeserializeObject<Task[]>(await response.Content.ReadAsStringAsync());
            responseText.Should().HaveCount(4);
        }

        [Fact]
        public async Task WhenTouchScreenNoIsAnsweredByUser()
        {
            var response = await server.Client.GetAsync(url + "/TouchScreen/NO");
            response.EnsureSuccessStatusCode();
            var responseText = JsonConvert.DeserializeObject<Task[]>(await response.Content.ReadAsStringAsync());
            responseText.Should().HaveCount(0);
        }

        [Fact]
        public async Task WhenWearableMonitorYesIsAnsweredByUser()
        {
            var response = await server.Client.GetAsync(url + "/WearableMonitor/YES");
            response.EnsureSuccessStatusCode();
            var responseText = JsonConvert.DeserializeObject<Task[]>(await response.Content.ReadAsStringAsync());
            responseText.Should().HaveCount(1);
        }

        [Fact]
        public async Task WhenWearableMonitorNoIsAnsweredByUser()
        {
            var response = await server.Client.GetAsync(url + "/WearableMonitor/NO");
            response.EnsureSuccessStatusCode();
            var responseText = JsonConvert.DeserializeObject<Task[]>(await response.Content.ReadAsStringAsync());
            responseText.Should().HaveCount(3);
        }

        [Fact]
        public async Task WhenAlarmManagementYesIsAnsweredByUser()
        {
            var response = await server.Client.GetAsync(url + "/AlarmManagement/YES");
            response.EnsureSuccessStatusCode();
            var responseText = JsonConvert.DeserializeObject<Task[]>(await response.Content.ReadAsStringAsync());
            responseText.Should().HaveCount(1);
        }

        [Fact]
        public async Task WhenAlarmManagementNoIsAnsweredByUser()
        {
            var response = await server.Client.GetAsync(url + "/AlarmManagement/NO");
            response.EnsureSuccessStatusCode();
            var responseText = JsonConvert.DeserializeObject<Task[]>(await response.Content.ReadAsStringAsync());
            responseText.Should().HaveCount(3);
        }

        [Fact]
        public async Task WhenBelowPrice25000IsAnsweredByUser()
        {
            var response = await server.Client.GetAsync(url + "/BelowPrice/25000");
            response.EnsureSuccessStatusCode();
            var responseText = JsonConvert.DeserializeObject<Task[]>(await response.Content.ReadAsStringAsync());
            responseText.Should().HaveCount(2);
        }

        [Fact]
        public async Task WhenAbovePrice25000IsAnsweredByUser()
        {
            var response = await server.Client.GetAsync(url + "/AbovePrice/25000");
            response.EnsureSuccessStatusCode();
            var responseText = JsonConvert.DeserializeObject<Task[]>(await response.Content.ReadAsStringAsync());
            responseText.Should().HaveCount(2);
        }

        [Fact]
        public async Task WhenConnectivitySupportYesIsAnsweredByUser()
        {
            var response = await server.Client.GetAsync(url + "/ConnectivitySupport/YES");
            response.EnsureSuccessStatusCode();
            var responseText = JsonConvert.DeserializeObject<Task[]>(await response.Content.ReadAsStringAsync());
            responseText.Should().HaveCount(2);
        }

        [Fact]
        public async Task WhenConnectivitySupportNoIsAnsweredByUser()
        {
            var response = await server.Client.GetAsync(url + "/ConnectivitySupport/NO");
            response.EnsureSuccessStatusCode();
            var responseText = JsonConvert.DeserializeObject<Task[]>(await response.Content.ReadAsStringAsync());
            responseText.Should().HaveCount(2);
        }

        [Fact]
        public async Task WhenSummarizeDataSupportYesIsAnsweredByUser()
        {
            var response = await server.Client.GetAsync(url + "/SummarizeDataSupport/YES");
            response.EnsureSuccessStatusCode();
            var responseText = JsonConvert.DeserializeObject<Task[]>(await response.Content.ReadAsStringAsync());
            responseText.Should().HaveCount(2);
        }

        [Fact]
        public async Task WhenSummerizeDataSupportNoIsAnsweredByUser()
        {
            var response = await server.Client.GetAsync(url + "/SummarizeDataSupport/NO");
            response.EnsureSuccessStatusCode();
            var responseText = JsonConvert.DeserializeObject<Task[]>(await response.Content.ReadAsStringAsync());
            responseText.Should().HaveCount(2);
        }

        [Fact]
        public async Task WhenScalableMeasurementNoIsAnsweredByUser()
        {
            var response = await server.Client.GetAsync(url + "/ScalableMeasurement/NO");
            response.EnsureSuccessStatusCode();
            var responseText = JsonConvert.DeserializeObject<Task[]>(await response.Content.ReadAsStringAsync());
            responseText.Should().HaveCount(2);
        }

        [Fact]
        public async Task WhenScalableMeasurementYesIsAnsweredByUser()
        {
            var response = await server.Client.GetAsync(url + "/ScalableMeasurement/YES");
            response.EnsureSuccessStatusCode();
            var responseText = JsonConvert.DeserializeObject<Task[]>(await response.Content.ReadAsStringAsync());
            responseText.Should().HaveCount(2);
        }

        [Fact]
        public async Task WhenCompactYesIsAnsweredByUser()
        {
            var response = await server.Client.GetAsync(url + "/Compact/YES");
            response.EnsureSuccessStatusCode();
            var responseText = JsonConvert.DeserializeObject<Task[]>(await response.Content.ReadAsStringAsync());
            responseText.Should().HaveCount(2);
        }

        [Fact]
        public async Task WhenCompactNoIsAnsweredByUser()
        {
            var response = await server.Client.GetAsync(url + "/Compact/NO");
            response.EnsureSuccessStatusCode();
            var responseText = JsonConvert.DeserializeObject<Task[]>(await response.Content.ReadAsStringAsync());
            responseText.Should().HaveCount(2);
        }

        
    }
}
