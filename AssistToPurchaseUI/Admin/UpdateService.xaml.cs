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
    /// Interaction logic for UpdateService.xaml
    /// </summary>
    public partial class UpdateService : Window
    {
        public UpdateService()
        {
            InitializeComponent();
        }

        private void Submit_Click(object sender, RoutedEventArgs e)
        {
            if (ProductNumberTextBox.Text.Length == 0)
            {
                errormessage.Text = "Enter Product Number.";
                ProductNumberTextBox.Focus();
            }
            else
            {

            }
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

        private void Cancel_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void Selection_Click(object sender, RoutedEventArgs e)
        {
            AdminSelectionPortal _Select = new AdminSelectionPortal();
            _Select.Show();
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
