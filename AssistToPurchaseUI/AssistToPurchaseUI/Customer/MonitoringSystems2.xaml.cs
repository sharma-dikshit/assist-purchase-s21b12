using AssistToPurchaseUI.Admin;
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

namespace AssistToPurchaseUI.Customer
{
    /// <summary>
    /// Interaction logic for MonitoringSystems2.xaml
    /// </summary>
    public partial class MonitoringSystems2 : Window
    {
        public MonitoringSystems2()
        {
            InitializeComponent();
        }

        private void ScrCost_Click(object sender, RoutedEventArgs e)
        {


            ContactUstext.Visibility = Visibility.Visible; 
        }

        private void Contactus_Click(object sender, RoutedEventArgs e)
        {
            Customer_Registration _Registration = new Customer_Registration();
            _Registration.Show();
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
