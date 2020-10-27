using System;
using System.Collections.Generic;
using System.Linq;
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
                MessageBox.Show("Product Added Successfully");
                //Reset_Click();

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
