using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace AssistToPurchaseUI.Admin
{
    /// <summary>
    /// Interaction logic for AdminAddService.xaml
    /// </summary>
    public partial class AdminAddService : Window
    {
        public AdminAddService()
        {
            InitializeComponent();
        }

        private void Selection_Click(object sender, RoutedEventArgs e)
        {
            AdminSelectionPortal Admin = new AdminSelectionPortal();
            Admin.Show();
            Close();
        }

        private void Reset_Click(object sender, RoutedEventArgs e)
        {
            ProductNumberTextBox.Text = "";
            ProductNameTextBox.Text = "";
            ProductDescriptionTextBox.Text = "";
            TouchScreenTextBox.Text = "";
            WearableMonitorTextBox.Text = "";
            AlarmManagementTextBox.Text = "";
            CostTextBox.Text = "";
            ScreenSizeTextBox.Text = "";
            ConnectivitySupportTextBox.Text = "";
            SummarizeDataSupportTextBox.Text = "";
            ScalableMeasurementTextBox.Text = "";
            CompactTextBox.Text = "";

        }

        private void Submit_Click(object sender, RoutedEventArgs e)
        {
            if (ProductNumberTextBox.Text.Length == 0)
            {
                errormessage.Text = "Enter Product Number.";
                ProductNumberTextBox.Focus();
            }
            else if (ProductNameTextBox.Text.Length == 0)
            {
                errormessage.Text = "Enter Product Name.";
                ProductNameTextBox.Focus();
            }
            else if (ProductDescriptionTextBox.Text.Length == 0)
            {
                errormessage.Text = "Enter Product Description.";
                ProductDescriptionTextBox.Focus();
            }
            else if (TouchScreenTextBox.Text.Length == 0)
            {
                errormessage.Text = "Does product have TouchScreen ?";
                TouchScreenTextBox.Focus();
            }
            else if (WearableMonitorTextBox.Text.Length == 0)
            {
                errormessage.Text = "Does product have WearableMonitor ?";
                WearableMonitorTextBox.Focus();
            }
            else if (AlarmManagementTextBox.Text.Length == 0)
            {
                errormessage.Text = "Does Product have Alarm System ?";
                AlarmManagementTextBox.Focus();
            }
            else if (CostTextBox.Text.Length == 0)
            {
                errormessage.Text = "Enter Product Cost.";
                CostTextBox.Focus();
            }
            else if (ScreenSizeTextBox.Text.Length == 0)
            {
                errormessage.Text = "Enter Screen Size";
                ScreenSizeTextBox.Focus();
            }
            else if (ConnectivitySupportTextBox.Text.Length == 0)
            {
                errormessage.Text = "Does Product have internet connectivity support?";
                ConnectivitySupportTextBox.Focus();
            }
            else if (SummarizeDataSupportTextBox.Text.Length == 0)
            {
                errormessage.Text = "Does Product Summarize data ?";
                SummarizeDataSupportTextBox.Focus();
            }
            else if (ScalableMeasurementTextBox.Text.Length == 0)
            {
                errormessage.Text = "Does Product Scalable ?";
                ScalableMeasurementTextBox.Focus();
            }
            else if (CompactTextBox.Text.Length == 0)
            {
                errormessage.Text = "Does product compact in size ?";
                CompactTextBox.Focus();
            }
            else
            {
                Models.MonitoringProducts _Model = new Models.MonitoringProducts();
                _Model.ProductNumber = ProductNumberTextBox.Text;
                _Model.ProductName = ProductNameTextBox.Text;
                _Model.ProductDescription = ProductDescriptionTextBox.Text;
                _Model.ScalableMeasurement = ScalableMeasurementTextBox.Text;
                _Model.ScreenSize = ScreenSizeTextBox.Text;
                _Model.SummarizeDataSupport = SummarizeDataSupportTextBox.Text;
                _Model.WearableMonitor = WearableMonitorTextBox.Text;
                _Model.ConnectivitySupport = ConnectivitySupportTextBox.Text;
                _Model.AlarmManagement = AlarmManagementTextBox.Text;
                _Model.Compact = CompactTextBox.Text;
                _Model.Cost = CostTextBox.Text;
                _Model.TouchScreen = TouchScreenTextBox.Text;

                HttpClient client = new HttpClient();
                string apiUrl = ConfigurationManager.AppSettings["MailApi"] + "MonitoringProduct/new";
                client.BaseAddress = new Uri(apiUrl);
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                var serializedProduct = JsonConvert.SerializeObject(_Model);
                var content = new StringContent(serializedProduct, Encoding.UTF8, "application/json");
                HttpResponseMessage response = client.PostAsync(apiUrl, content).Result;
                if (response.IsSuccessStatusCode)
                {
                    //var msg = Convert.ToString(response.Content);
                    MessageBox.Show("New Product "+_Model.ProductNumber+" Added Successfully");
                }
                else
                {
                    MessageBox.Show("Adding New Product failed, Please try again !!");
                }
            }
        }

        private void Cancel_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void Home_Click(object sender, RoutedEventArgs e)
        {
            WelcomePortal _Welcome = new WelcomePortal();
            _Welcome.Show();
            Close();
        }

    }
}
