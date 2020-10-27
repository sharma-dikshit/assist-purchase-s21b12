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
    /// Interaction logic for AdminSelectionPortal.xaml
    /// </summary>
    public partial class AdminSelectionPortal : Window
    {
        public AdminSelectionPortal()
        {
            InitializeComponent();
        }
        private void Add_Service(object sender, RoutedEventArgs e)
        {
            AdminAddService Admin = new AdminAddService();
            Admin.Show();
            Close();
        }

        private void Update_Service(object sender, RoutedEventArgs e)
        {
            UpdateService _Update = new UpdateService();
            _Update.Show();
            Close();
        }

        private void Delete_Service(object sender, RoutedEventArgs e)
        {
            AdminRemoveProduct Remove = new AdminRemoveProduct();
            Remove.Show();
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
