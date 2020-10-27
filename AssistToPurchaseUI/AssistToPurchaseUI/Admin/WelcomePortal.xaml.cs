using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using AssistToPurchaseUI.Customer;
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
    /// Interaction logic for WelcomePortal.xaml
    /// </summary>
    public partial class WelcomePortal : Window
    {
        public WelcomePortal()
        {
            InitializeComponent();
        }
        private void Admin_Click(object sender, RoutedEventArgs e)
        {

            AdminSelectionPortal Admin = new AdminSelectionPortal();
            Admin.Show();
            Close();
        }

        private void Customer_Click(object sender, RoutedEventArgs e)
        {
            CustomerSelection _Select = new CustomerSelection();
            _Select.Show();
            Close();
        }
    }
}
