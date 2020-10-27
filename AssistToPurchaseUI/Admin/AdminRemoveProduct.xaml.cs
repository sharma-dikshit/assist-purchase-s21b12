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
    /// Interaction logic for AdminRemoveProduct.xaml
    /// </summary>
    public partial class AdminRemoveProduct : Window
    {
        public AdminRemoveProduct()
        {
            InitializeComponent();
        }
        private void Remove_Click(object sender, RoutedEventArgs e)
        {
            if (ProductNameDel.Text.Length == 0)
            {
                ErrorMesg.Text = "Please enter Product number";
                ProductNameDel.Focus();
            }
            else
            {
                MessageBox.Show("Product Removed Successfully");
                Close();
            }

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
