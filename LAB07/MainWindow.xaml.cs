using Business;
using Entity;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace LAB07
{
    
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();   
        }

        CustomerBusiness customerBusiness = new CustomerBusiness();

        private void btn_list(object sender, RoutedEventArgs e)
        {
            string name = txtCustomerName.Text;

            List<Customer> customers = customerBusiness.getCustomersByName(name);

            dgCustomers.ItemsSource = customers;
        }

        private void btn_insert(object sender, RoutedEventArgs e)
        {
            InsertarWindow insertarWindow = new InsertarWindow();
            insertarWindow.Show();
        }
    }
}